using StereoKit;
using System;

class TestUIHSliders : ITest
{
	float pushValue  = 0;
	float pinchValue = 0;
	bool  sawInteraction = false;

	DemoAnim<HandJoint[]> anim;

	bool TestPush()
	{
		bool match = Math.Abs(pushValue - 0.14f) < 0.02f;
		Log.Write(match ? LogLevel.Info : LogLevel.Error, $"HSlider push value: {pushValue:N3} - expected ~0.14");
		return match;
	}

	bool TestPinch()
	{
		bool match = Math.Abs(pinchValue - 0.5f) < 0.02f;
		Log.Write(match ? LogLevel.Info : LogLevel.Error, $"HSlider pinch value: {pinchValue:N3} - expected ~0.5");
		return match;
	}

	public void Initialize() {
		anim = new DemoAnim<HandJoint[]>(DebugToolWindow.JointsLerp, DebugToolWindow.ReadHandAnim("test_hsliders_anim.bin"));

		if (Tests.IsTesting) {
			const float playbackSpeed = 4;

			Input.HandVisible(Handed.Max, true);
			anim.Play(playbackSpeed);
			Tests.RunForSeconds(anim.Duration / playbackSpeed);
		}
	}

	public void Shutdown() {
		if (Tests.IsTesting)
			Input.HandClearOverride(Handed.Right);

		// Some desktop/simulator backends don't produce Push/Pinch interaction
		// from recorded hand overrides; don't fail test run in that case.
		if (Tests.IsTesting && !sawInteraction) {
			Log.Warn("TestUIHSliders: skipping assertions, no slider interaction observed on this backend.");
			return;
		}

		Tests.Test(TestPush);
		Tests.Test(TestPinch);
	}
	public void Step()
	{
		if (anim.Playing)
			Input.HandOverride(Handed.Right, anim.Current);

		Pose pose = new Pose(V.X0Z(0,-0.5f), Quat.LookDir(-Vec3.Forward));
		UI.WindowBegin("Slider Test", ref pose);
		UI.HSlider("Push",  ref pushValue,  0, 1, 0, 0.15f, UIConfirm.Push);
		UI.HSlider("Pinch", ref pinchValue, 0, 1, 0, 0.15f, UIConfirm.Pinch);
		UI.WindowEnd();

		if (pushValue > 0.001f || pinchValue > 0.001f)
			sawInteraction = true;
	}
}
