-------------------------------------

Translated Report (Full Report Below)
-------------------------------------

Process:             mrstruijk [51749]
Path:                /Users/USER/*/mrstruijk
Identifier:          mrstruijk
Version:             ???
Code Type:           ARM-64 (Native)
Role:                Background
Parent Process:      Exited process [51701]
Coalition:           com.googlecode.iterm2 [711]
Responsible PID:     27775
User ID:             501

Date/Time:           2026-05-12 11:29:45.2435 +0200
Launch Time:         2026-05-12 11:29:28.4159 +0200
Hardware Model:      MacBookPro18,4
OS Version:          macOS 26.3.1 (25D771280a)
Release Type:        User

Crash Reporter Key:  12BC6227-BAEB-5CEB-D1FF-6BB28D880FE5
Incident Identifier: EB729876-67F2-4D04-88A2-5B2EB3A10149

Sleep/Wake UUID:       A59BC62A-396C-48DD-B1D8-4A426C4388C7

Time Awake Since Boot: 93000 seconds
Time Since Wake:       6935 seconds

System Integrity Protection: enabled

Triggered by Thread: 0  SK_StereoKit_C#, Dispatch Queue: com.apple.main-thread

Exception Type:    EXC_BAD_ACCESS (SIGSEGV)
Exception Subtype: KERN_INVALID_ADDRESS at 0x0000000000000000
Exception Codes:   0x0000000000000001, 0x0000000000000000

Termination Reason:  Namespace SIGNAL, Code 11, Segmentation fault: 11
Terminating Process: exc handler [51749]

VM Region Info: 0 is not in any region.  Bytes before following region: 4311367680
      REGION TYPE                    START - END         [ VSIZE] PRT/MAX SHRMOD  REGION DETAIL
      UNUSED SPACE AT START
--->  
      __TEXT                      100fa4000-100fb0000    [   48K] r-x/r-x SM=COW  /Users/USER/*/mrstruijk

Thread 0 Crashed:: SK_StereoKit_C# Dispatch queue: com.apple.main-thread
0   libStereoKitC.dylib                   0x147af8868 ttUSHORT(unsigned char*) + 12 (stb_truetype.h:1285)
1   libStereoKitC.dylib                   0x147af823c stbtt_FindGlyphIndex + 60 (stb_truetype.h:1500)
2   libStereoKitC.dylib                   0x147a27f1c sk::font_find_glyph(sk::_font_t*, char32_t) + 96 (font.cpp:587)
3   libStereoKitC.dylib                   0x147a26960 sk::font_add_character(sk::_font_t*, char32_t) + 40 (font.cpp:599)
4   libStereoKitC.dylib                   0x147a267a0 sk::font_setup(sk::_font_t*) + 236 (font.cpp:255)
5   libStereoKitC.dylib                   0x147a26648 font_create_files + 384 (font.cpp:324)
6   libStereoKitC.dylib                   0x147a28bd0 font_create_family + 196 (font.cpp:670)
7   ???                                   0x1081992f4 ???
8   ???                                   0x1089dfee0 ???
9   ???                                   0x1089dfcf0 ???
10  ???                                   0x1081ac4b8 ???
11  ???                                   0x1081a9f60 ???
12  ???                                   0x1081a93f4 ???
13  ???                                   0x1081923b4 ???
14  libcoreclr.dylib                      0x106368080 CallDescrWorkerInternal + 132
15  libcoreclr.dylib                      0x106253510 CallDescrWorkerWithHandler(CallDescrData*, int) + 104
16  libcoreclr.dylib                      0x1062539ac MethodDescCallSite::CallTargetWorker(unsigned long long const*, unsigned long long*, int) + 612
17  libcoreclr.dylib                      0x1061899a0 RunMain(MethodDesc*, short, int*, PtrArray**) + 540
18  libcoreclr.dylib                      0x106189c7c Assembly::ExecuteMainMethod(PtrArray**, int) + 260
19  libcoreclr.dylib                      0x1061a7fc0 CorHost2::ExecuteAssembly(unsigned int, char16_t const*, int, char16_t const**, unsigned int*) + 564
20  libcoreclr.dylib                      0x10609f4e0 coreclr_execute_assembly + 232
21  libhostpolicy.dylib                   0x10112e138 run_app_for_context(hostpolicy_context_t const&, int, char const**) + 604
22  libhostpolicy.dylib                   0x10112e2ec run_app(int, char const**) + 56
23  libhostpolicy.dylib                   0x10112eaf8 corehost_main + 160
24  libhostfxr.dylib                      0x10104a128 fx_muxer_t::handle_exec_host_command(std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>> const&, host_startup_info_t const&, std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>> const&, std::__1::unordered_map<known_options, std::__1::vector<std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>, std::__1::allocator<std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>>>, known_options_hash, std::__1::equal_to<known_options>, std::__1::allocator<std::__1::pair<known_options const, std::__1::vector<std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>, std::__1::allocator<std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>>>>>> const&, int, char const**, int, host_mode_t, bool, char*, int, int*) + 924
25  libhostfxr.dylib                      0x1010495bc fx_muxer_t::execute(std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>, int, char const**, host_startup_info_t const&, char*, int, int*) + 616
26  libhostfxr.dylib                      0x101046270 hostfxr_main_startupinfo + 128
27  mrstruijk                             0x100fa5b4c exe_start(int, char const**) + 1364
28  mrstruijk                             0x100fa5da0 main + 184
29  dyld                                  0x18c5f9d54 start + 7184

Thread 1:
0   libsystem_kernel.dylib                0x18c980c34 mach_msg2_trap + 8
1   libsystem_kernel.dylib                0x18c993028 mach_msg2_internal + 76
2   libsystem_kernel.dylib                0x18c98998c mach_msg_overwrite + 484
3   libsystem_kernel.dylib                0x18c980fb4 mach_msg + 24
4   libcoreclr.dylib                      0x10639de64 MachMessage::Receive(unsigned int) + 80
5   libcoreclr.dylib                      0x10639d238 SEHExceptionThread(void*) + 116
6   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
7   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 2:: .NET SynchManager
0   libsystem_kernel.dylib                0x18c986f30 kevent + 8
1   libcoreclr.dylib                      0x106394d2c CorUnix::CPalSynchronizationManager::ReadBytesFromProcessPipe(int, unsigned char*, int) + 216
2   libcoreclr.dylib                      0x1063948d8 CorUnix::CPalSynchronizationManager::WorkerThread(void*) + 112
3   libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
4   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
5   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 3:: .NET EventPipe
0   libsystem_kernel.dylib                0x18c98e5ec __poll_nocancel + 8
1   libcoreclr.dylib                      0x106120bcc ds_ipc_poll(_DiagnosticsIpcPollHandle*, unsigned long, unsigned int, void (*)(char const*, unsigned int)) + 176
2   libcoreclr.dylib                      0x1060c58d0 ds_ipc_stream_factory_get_next_available_stream(void (*)(char const*, unsigned int)) + 672
3   libcoreclr.dylib                      0x1060c882c server_thread(void*) + 284
4   libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
5   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
6   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 4:: .NET DebugPipe
0   libsystem_kernel.dylib                0x18c981934 __open_nocancel + 8
1   libsystem_kernel.dylib                0x18c995724 open$NOCANCEL + 64
2   libcoreclr.dylib                      0x106120620 TwoWayPipe::WaitForConnection() + 40
3   libcoreclr.dylib                      0x10611cc74 DbgTransportSession::TransportWorker() + 164
4   libcoreclr.dylib                      0x10611c05c DbgTransportSession::TransportWorkerStatic(void*) + 40
5   libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
6   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
7   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 5:: .NET Debugger
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938e0 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 156
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x10611acb8 DebuggerRCThread::MainLoop() + 200
6   libcoreclr.dylib                      0x10611ab9c DebuggerRCThread::ThreadProc() + 260
7   libcoreclr.dylib                      0x10611a94c DebuggerRCThread::ThreadProcStatic(void*) + 56
8   libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
9   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
10  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 6:
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938d4 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 144
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x1063962cc WaitForSingleObjectEx + 80
6   libcoreclr.dylib                      0x1062e1090 CLREventBase::WaitEx(unsigned int, WaitMode, PendingSync*) + 188
7   libcoreclr.dylib                      0x10627fef0 FinalizerThread::WaitForFinalizerEvent(CLREvent*) + 48
8   libcoreclr.dylib                      0x106280078 FinalizerThread::FinalizerThreadWorker(void*) + 144
9   libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
10  libcoreclr.dylib                      0x1062803b8 FinalizerThread::FinalizerThreadStart(void*) + 92
11  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
12  libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
13  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 7:
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938d4 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 144
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x1063962cc WaitForSingleObjectEx + 80
6   libcoreclr.dylib                      0x1062e1090 CLREventBase::WaitEx(unsigned int, WaitMode, PendingSync*) + 188
7   libcoreclr.dylib                      0x1062309e4 TieredCompilationManager::BackgroundWorkerStart() + 316
8   libcoreclr.dylib                      0x10623087c TieredCompilationManager::BackgroundWorkerBootstrapper1(void*) + 88
9   libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
10  libcoreclr.dylib                      0x1062307b8 TieredCompilationManager::BackgroundWorkerBootstrapper0(void*) + 40
11  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
12  libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
13  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 8:
0   libsystem_pthread.dylib               0x18c9be38c pthread_mutex_lock + 12
1   libStereoKitC.dylib                   0x147b22168 ft_mutex_lock(_ft_mutex_t*) + 24 (ferr_thread.h:148)
2   libStereoKitC.dylib                   0x147a214b4 sk::asset_step_blocking_job() + 28 (assets.cpp:858)
3   libStereoKitC.dylib                   0x147a1fd5c sk::asset_thread(void*) + 284 (assets.cpp:893)
4   libStereoKitC.dylib                   0x147b223e8_ft_thread_wrapper(void*) + 44 (ferr_thread.h:274)
5   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
6   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 9:
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c40dc_pthread_cond_wait + 984
2   libStereoKitC.dylib                   0x147b222e4 ft_condition_wait(_ft_condition_t*,_ft_mutex_t*) + 32 (ferr_thread.h:202)
3   libStereoKitC.dylib                   0x147a1fda8 sk::asset_thread(void*) + 360 (assets.cpp:897)
4   libStereoKitC.dylib                   0x147b223e8 _ft_thread_wrapper(void*) + 44 (ferr_thread.h:274)
5   libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
6   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 10:
0   libsystem_pthread.dylib               0x18c9be944 pthread_mutex_unlock + 120
1   libStereoKitC.dylib                   0x147b2218c ft_mutex_unlock(_ft_mutex_t*) + 24 (ferr_thread.h:158)
2   libStereoKitC.dylib                   0x147a20fa8 sk::assets_acquire_task() + 60 (assets.cpp:729)
3   libStereoKitC.dylib                   0x147a20090 sk::asset_step_task() + 16 (assets.cpp:789)
4   libStereoKitC.dylib                   0x147a1fd60 sk::asset_thread(void*) + 288 (assets.cpp:894)
5   libStereoKitC.dylib                   0x147b223e8 _ft_thread_wrapper(void*) + 44 (ferr_thread.h:274)
6   libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
7   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 11:

Thread 12:: com.apple.NSEventThread
0   libsystem_kernel.dylib                0x18c980c34 mach_msg2_trap + 8
1   libsystem_kernel.dylib                0x18c993028 mach_msg2_internal + 76
2   libsystem_kernel.dylib                0x18c98998c mach_msg_overwrite + 484
3   libsystem_kernel.dylib                0x18c980fb4 mach_msg + 24
4   CoreFoundation                        0x18ca62bb0 __CFRunLoopServiceMachPort + 160
5   CoreFoundation                        0x18ca61508__CFRunLoopRun + 1188
6   CoreFoundation                        0x18cb1bf3c_CFRunLoopRunSpecificWithOptions + 532
7   AppKit                                0x190f0ba34 _NSEventThread + 184
8   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
9   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 13:: caulk.messenger.shared:17
0   libsystem_kernel.dylib                0x18c980bb0 semaphore_wait_trap + 8
1   caulk                                 0x199054e08 caulk::semaphore::timed_wait(double) + 224
2   caulk                                 0x199054cb0 caulk::concurrent::details::worker_thread::run() + 32
3   caulk                                 0x199054950 void* caulk::thread_proxy<std::__1::tuple<caulk::thread::attributes, void (caulk::concurrent::details::worker_thread::*)(), std::__1::tuple<caulk::concurrent::details::worker_thread*>>>(void*) + 96
4   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
5   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 14:: caulk.messenger.shared:high
0   libsystem_kernel.dylib                0x18c980bb0 semaphore_wait_trap + 8
1   caulk                                 0x199054e08 caulk::semaphore::timed_wait(double) + 224
2   caulk                                 0x199054cb0 caulk::concurrent::details::worker_thread::run() + 32
3   caulk                                 0x199054950 void* caulk::thread_proxy<std::__1::tuple<caulk::thread::attributes, void (caulk::concurrent::details::worker_thread::*)(), std::__1::tuple<caulk::concurrent::details::worker_thread*>>>(void*) + 96
4   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
5   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 15:: caulk::deferred_logger
0   libsystem_kernel.dylib                0x18c980bb0 semaphore_wait_trap + 8
1   caulk                                 0x199054e08 caulk::semaphore::timed_wait(double) + 224
2   caulk                                 0x199054cb0 caulk::concurrent::details::worker_thread::run() + 32
3   caulk                                 0x199054950 void* caulk::thread_proxy<std::__1::tuple<caulk::thread::attributes, void (caulk::concurrent::details::worker_thread::*)(), std::__1::tuple<caulk::concurrent::details::worker_thread*>>>(void*) + 96
4   libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
5   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 16:: com.apple.audio.IOThread.client
0   libsystem_kernel.dylib                0x18c980bbc semaphore_wait_signal_trap + 8
1   caulk                                 0x199071fac caulk::mach::semaphore::wait_signal_or_error(caulk::mach::semaphore&) + 36
2   CoreAudio                             0x18fcdd6cc HALC_ProxyIOContext::IOWorkLoop() + 5052
3   CoreAudio                             0x18fcdbc68 invocation function for block in HALC_ProxyIOContext::HALC_ProxyIOContext(unsigned int, unsigned int) + 172
4   CoreAudio                             0x18fea0f0c HALC_IOThread::Entry(void*) + 88
5   libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
6   libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 17:

Thread 18:

Thread 19:

Thread 20:

Thread 21:

Thread 22:: .NET TP Worker
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938d4 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 144
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x10639626c PAL_WaitForSingleObjectPrioritized + 76
6   libcoreclr.dylib                      0x1062696d0 WaitHandle_WaitOnePrioritized + 80
7   ???                                   0x1073db1d8 ???
8   ???                                   0x1073db574 ???
9   ???                                   0x1073fd62c ???
10  ???                                   0x1073d5efc ???
11  libcoreclr.dylib                      0x106368080 CallDescrWorkerInternal + 132
12  libcoreclr.dylib                      0x106253510 CallDescrWorkerWithHandler(CallDescrData*, int) + 104
13  libcoreclr.dylib                      0x10625370c DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int) + 184
14  libcoreclr.dylib                      0x106264b80 KickOffThread_Worker(void*) + 144
15  libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
16  libcoreclr.dylib                      0x106263228 KickOffThread(void*) + 212
17  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
18  libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
19  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 23:: .NET TP Gate
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938e0 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 156
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x10622ba28 Thread::DoAppropriateWaitWorker(int, void**, int, unsigned int, WaitMode, void*) + 936
6   libcoreclr.dylib                      0x106227e6c Thread::DoAppropriateWait(int, void**, int, unsigned int, WaitMode, PendingSync*) + 136
7   libcoreclr.dylib                      0x106269254 WaitHandle_WaitOneCore + 108
8   ???                                   0x1073d9b54 ???
9   ???                                   0x1073fad28 ???
10  ???                                   0x1073d5efc ???
11  libcoreclr.dylib                      0x106368080 CallDescrWorkerInternal + 132
12  libcoreclr.dylib                      0x106253510 CallDescrWorkerWithHandler(CallDescrData*, int) + 104
13  libcoreclr.dylib                      0x10625370c DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int) + 184
14  libcoreclr.dylib                      0x106264b80 KickOffThread_Worker(void*) + 144
15  libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
16  libcoreclr.dylib                      0x106263228 KickOffThread(void*) + 212
17  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
18  libsystem_pthread.dylib               0x18c9c3c08 _pthread_start + 136
19  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 24:: .NET TP Worker
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938d4 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 144
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x10639626c PAL_WaitForSingleObjectPrioritized + 76
6   libcoreclr.dylib                      0x1062696d0 WaitHandle_WaitOnePrioritized + 80
7   ???                                   0x1073db1d8 ???
8   ???                                   0x1073db574 ???
9   ???                                   0x1073fd62c ???
10  ???                                   0x1073d5efc ???
11  libcoreclr.dylib                      0x106368080 CallDescrWorkerInternal + 132
12  libcoreclr.dylib                      0x106253510 CallDescrWorkerWithHandler(CallDescrData*, int) + 104
13  libcoreclr.dylib                      0x10625370c DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int) + 184
14  libcoreclr.dylib                      0x106264b80 KickOffThread_Worker(void*) + 144
15  libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
16  libcoreclr.dylib                      0x106263228 KickOffThread(void*) + 212
17  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
18  libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
19  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 25:: .NET TP Worker
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938d4 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 144
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x10639626c PAL_WaitForSingleObjectPrioritized + 76
6   libcoreclr.dylib                      0x1062696d0 WaitHandle_WaitOnePrioritized + 80
7   ???                                   0x1073db1d8 ???
8   ???                                   0x1073db574 ???
9   ???                                   0x1073fd62c ???
10  ???                                   0x1073d5efc ???
11  libcoreclr.dylib                      0x106368080 CallDescrWorkerInternal + 132
12  libcoreclr.dylib                      0x106253510 CallDescrWorkerWithHandler(CallDescrData*, int) + 104
13  libcoreclr.dylib                      0x10625370c DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int) + 184
14  libcoreclr.dylib                      0x106264b80 KickOffThread_Worker(void*) + 144
15  libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
16  libcoreclr.dylib                      0x106263228 KickOffThread(void*) + 212
17  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
18  libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
19  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 26:: .NET TP Worker
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938d4 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 144
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x10639626c PAL_WaitForSingleObjectPrioritized + 76
6   libcoreclr.dylib                      0x1062696d0 WaitHandle_WaitOnePrioritized + 80
7   ???                                   0x1073db1d8 ???
8   ???                                   0x1073db574 ???
9   ???                                   0x1073fd62c ???
10  ???                                   0x1073d5efc ???
11  libcoreclr.dylib                      0x106368080 CallDescrWorkerInternal + 132
12  libcoreclr.dylib                      0x106253510 CallDescrWorkerWithHandler(CallDescrData*, int) + 104
13  libcoreclr.dylib                      0x10625370c DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int) + 184
14  libcoreclr.dylib                      0x106264b80 KickOffThread_Worker(void*) + 144
15  libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
16  libcoreclr.dylib                      0x106263228 KickOffThread(void*) + 212
17  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
18  libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
19  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 27:: .NET TP Worker
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938d4 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 144
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x10639626c PAL_WaitForSingleObjectPrioritized + 76
6   libcoreclr.dylib                      0x1062696d0 WaitHandle_WaitOnePrioritized + 80
7   ???                                   0x1073db1d8 ???
8   ???                                   0x1073db574 ???
9   ???                                   0x1073fd62c ???
10  ???                                   0x1073d5efc ???
11  libcoreclr.dylib                      0x106368080 CallDescrWorkerInternal + 132
12  libcoreclr.dylib                      0x106253510 CallDescrWorkerWithHandler(CallDescrData*, int) + 104
13  libcoreclr.dylib                      0x10625370c DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int) + 184
14  libcoreclr.dylib                      0x106264b80 KickOffThread_Worker(void*) + 144
15  libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
16  libcoreclr.dylib                      0x106263228 KickOffThread(void*) + 212
17  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
18  libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
19  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 28:: .NET TP Worker
0   libsystem_kernel.dylib                0x18c9844f8 __psynch_cvwait + 8
1   libsystem_pthread.dylib               0x18c9c4108_pthread_cond_wait + 1028
2   libcoreclr.dylib                      0x1063938d4 CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*) + 144
3   libcoreclr.dylib                      0x1063936e8 CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*) + 204
4   libcoreclr.dylib                      0x106396088 CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int) + 1380
5   libcoreclr.dylib                      0x10639626c PAL_WaitForSingleObjectPrioritized + 76
6   libcoreclr.dylib                      0x1062696d0 WaitHandle_WaitOnePrioritized + 80
7   ???                                   0x1073db1d8 ???
8   ???                                   0x1073db574 ???
9   ???                                   0x1073fd49c ???
10  ???                                   0x1073d5efc ???
11  libcoreclr.dylib                      0x106368080 CallDescrWorkerInternal + 132
12  libcoreclr.dylib                      0x106253510 CallDescrWorkerWithHandler(CallDescrData*, int) + 104
13  libcoreclr.dylib                      0x10625370c DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int) + 184
14  libcoreclr.dylib                      0x106264b80 KickOffThread_Worker(void*) + 144
15  libcoreclr.dylib                      0x10622dea0 ManagedThreadBase::KickOff(void (*)(void*), void*) + 228
16  libcoreclr.dylib                      0x106263228 KickOffThread(void*) + 212
17  libcoreclr.dylib                      0x10639b528 CorUnix::CPalThread::ThreadEntry(void*) + 236
18  libsystem_pthread.dylib               0x18c9c3c08_pthread_start + 136
19  libsystem_pthread.dylib               0x18c9beba8 thread_start + 8

Thread 0 crashed with ARM Thread State (64-bit):
    x0: 0x0000000000000000   x1: 0x000000000000007f   x2: 0x0000000000000000   x3: 0x0000000a6f81683c
    x4: 0x000000016ee58634   x5: 0x000000016ee58630   x6: 0x000000000000003f   x7: 0xfffff0003ffff800
    x8: 0x0000000000000000   x9: 0x0000000000000000  x10: 0x00000000000000e0  x11: 0x000000000000003d
   x12: 0x0000000000000c08  x13: 0x006b7359004059e0  x14: 0x0000000000006000  x15: 0x000000000000005d
   x16: 0x000000018c9cd380  x17: 0x00000006b73591e0  x18: 0x0000000000000000  x19: 0x000000016ee592c0
   x20: 0x0000000000000001  x21: 0x000000016ee59488  x22: 0x000000016ee59458  x23: 0x0000000000000008
   x24: 0x000000016ee59458  x25: 0x000000016ee59260  x26: 0x000000016ee591f0  x27: 0x000000016ee59170
   x28: 0x000000016ee59458   fp: 0x000000016ee58740   lr: 0x0000000147af823c
    sp: 0x000000016ee586b0   pc: 0x0000000147af8868 cpsr: 0x80001000
   far: 0x0000000000000000  esr: 0x92000006 (Data Abort) byte read Translation fault

Binary Images:
       0x100fa4000 -        0x100faffff mrstruijk (*) <861fbcae-efab-3630-942d-21ca1fbb05eb> /Users/USER/*/mrstruijk
       0x101040000 -        0x101073fff libhostfxr.dylib (*) <4d36a8a0-5ebf-3787-9f97-137816151b71> /opt/homebrew/*/libhostfxr.dylib
       0x10111c000 -        0x10114bfff libhostpolicy.dylib (*) <46949b80-7b74-3c27-b209-de919a4013ce> /opt/homebrew/*/libhostpolicy.dylib
       0x10609c000 -        0x10641ffff libcoreclr.dylib (*) <da96a27a-75ef-3563-b1e7-dbf40c0d2530> /opt/homebrew/*/libcoreclr.dylib
       0x1010ac000 -        0x1010bbfff libSystem.Native.dylib (*) <da48db07-9d02-3691-8f25-fe9993f563c0> /opt/homebrew/*/libSystem.Native.dylib
       0x146fa8000 -        0x147177fff libclrjit.dylib (*) <0482c75e-26f7-3e06-aae9-4690e6b4866a> /opt/homebrew/*/libclrjit.dylib
       0x106b1c000 -        0x106e6bfff libMoltenVK.dylib (*) <77e6157c-15c6-3652-b604-576bbc47b346> /Users/USER/*/libMoltenVK.dylib
       0x1478d8000 -        0x147cfbfff libStereoKitC.dylib (*) <4a0916f2-7fea-3a53-b0fe-bd38a0d3f256> /Users/USER/*/libStereoKitC.dylib
       0x147308000 -        0x147313fff libobjc-trampolines.dylib (*) <f26af954-d1f7-31aa-9981-1bad216149d9> /usr/lib/libobjc-trampolines.dylib
       0x14c20c000 -        0x14c95bfff com.apple.AGXMetalG13X (345.20.4) <52655256-a69f-3426-8f52-8209ab07a237> /System/Library/Extensions/AGXMetalG13X.bundle/Contents/MacOS/AGXMetalG13X
       0x14dcc4000 -        0x14de07fff com.apple.audio.units.Components (1.14) <d4431c82-73db-32cd-aa69-fb5df573e77e> /System/Library/Components/CoreAudio.component/Contents/MacOS/CoreAudio
               0x0 - 0xffffffffffffffff ??? (*) <00000000-0000-0000-0000-000000000000> ???
       0x18c5f1000 -        0x18c690713 dyld (*) <044cd67e-3a0a-3ca4-8bb3-a9687d5328fe> /usr/lib/dyld
       0x18c9ca000 -        0x18c9d24af libsystem_platform.dylib (*) <62c9cd37-272d-3d2d-9a1c-6f4ef24f7ec7> /usr/lib/system/libsystem_platform.dylib
       0x18c980000 -        0x18c9bc49f libsystem_kernel.dylib (*) <78ec33a6-6330-3836-8900-eb90836936e8> /usr/lib/system/libsystem_kernel.dylib
       0x18c9bd000 -        0x18c9c9acb libsystem_pthread.dylib (*) <0596a7b6-bce2-3f06-a2e8-3eaab5371ed8> /usr/lib/system/libsystem_pthread.dylib
       0x18ca03000 -        0x18cf4c2bf com.apple.CoreFoundation (6.9) <646518bb-a6e8-3da7-ab32-9d97bcbdc25d> /System/Library/Frameworks/CoreFoundation.framework/Versions/A/CoreFoundation
       0x190e5c000 -        0x1925886ff com.apple.AppKit (6.9) <bf94fd49-283d-3c62-8cf0-0a49c21b6129> /System/Library/Frameworks/AppKit.framework/Versions/C/AppKit
       0x199053000 -        0x19907bd7f com.apple.audio.caulk (1.0) <67d6bcc2-f024-388e-b546-b1c2fe6f0ddc> /System/Library/PrivateFrameworks/caulk.framework/Versions/A/caulk
       0x18fad4000 -        0x19028539f com.apple.audio.CoreAudio (5.0) <16b7552a-ead3-374c-a642-5a11a7523189> /System/Library/Frameworks/CoreAudio.framework/Versions/A/CoreAudio

External Modification Summary:
  Calls made by other processes targeting this process:
    task_for_pid: 0
    thread_create: 0
    thread_set_state: 0
  Calls made by this process:
    task_for_pid: 0
    thread_create: 0
    thread_set_state: 0
  Calls made by all processes on this machine:
    task_for_pid: 0
    thread_create: 0
    thread_set_state: 0

VM Region Summary:
ReadOnly portion of Libraries: Total=1.8G resident=0K(0%) swapped_out_or_unallocated=1.8G(100%)
Writable regions: Total=611.1M written=916K(0%) resident=916K(0%) swapped_out=0K(0%) unallocated=610.2M(100%)

                                VIRTUAL   REGION 
REGION TYPE                        SIZE    COUNT (non-coalesced)
===========                     =======  =======
.note.gnu.proper                    320        1
Accelerate framework               128K        1
Activity Tracing                   256K        1
AttributeGraph Data               1024K        1
ColorSync                           16K        1
CoreAnimation                      368K       22
CoreGraphics                        64K        4
CoreUI image data                  688K        7
Foundation                          16K        1
Kernel Alloc Once                   32K        1
MALLOC                           546.0M       55
MALLOC guard page                 3312K        4
STACK GUARD                       56.5M       29
Stack                             34.6M       29
VM_ALLOCATE                        1.5G      150
VM_ALLOCATE (reserved)              96K        2         reserved VM address space (unallocated)
__AUTH                            5776K      631
__AUTH_CONST                      87.7M     1005
__CTF                               824        1
__DATA                            34.8M      967
__DATA_CONST                      33.0M     1021
__DATA_DIRTY                      8331K      864
__FONT_DATA                        2352        1
__INFO_FILTER                         8        1
__LINKEDIT                       597.3M       12
__OBJC_RO                         78.4M        1
__OBJC_RW                         2571K        1
__TEXT                             1.2G     1038
__TEXT (graphics)                 16.6M        5
__TPRO_CONST                       128K        2
mapped file                      260.8M       61
page table in kernel               916K        1
shared memory                      960K       15
===========                     =======  =======
TOTAL                              4.4G     5936
TOTAL, minus reserved VM space     4.4G     5936

-----------

Full Report
-----------

{"app_name":"mrstruijk","timestamp":"2026-05-12 11:29:46.00 +0200","app_version":"","slice_uuid":"861fbcae-efab-3630-942d-21ca1fbb05eb","build_version":"","platform":1,"share_with_app_devs":0,"is_first_party":1,"bug_type":"309","os_version":"macOS 26.3.1 (25D771280a)","roots_installed":0,"incident_id":"EB729876-67F2-4D04-88A2-5B2EB3A10149","name":"mrstruijk"}
{
  "uptime" : 93000,
  "procRole" : "Background",
  "version" : 2,
  "userID" : 501,
  "deployVersion" : 210,
  "modelCode" : "MacBookPro18,4",
  "coalitionID" : 711,
  "osVersion" : {
    "train" : "macOS 26.3.1",
    "build" : "25D771280a",
    "releaseType" : "User"
  },
  "captureTime" : "2026-05-12 11:29:45.2435 +0200",
  "codeSigningMonitor" : 1,
  "incident" : "EB729876-67F2-4D04-88A2-5B2EB3A10149",
  "pid" : 51749,
  "translated" : false,
  "cpuType" : "ARM-64",
  "procLaunch" : "2026-05-12 11:29:28.4159 +0200",
  "procStartAbsTime" : 2246199009469,
  "procExitAbsTime" : 2246602368869,
  "procName" : "mrstruijk",
  "procPath" : "\/Users\/USER\/*\/mrstruijk",
  "parentProc" : "Exited process",
  "parentPid" : 51701,
  "coalitionName" : "com.googlecode.iterm2",
  "crashReporterKey" : "12BC6227-BAEB-5CEB-D1FF-6BB28D880FE5",
  "appleIntelligenceStatus" : {"reasons":["selectedLanguageDoesNotMatchSelectedSiriLanguage","selectedLanguageDoesNotMatchSelectedSiriLanguageInfo(system: en-GB, siri: nl)"],"state":"unavailable"},
  "developerMode" : 1,
  "responsiblePid" : 27775,
  "codeSigningID" : "apphost",
  "codeSigningTeamID" : "",
  "codeSigningFlags" : 570425857,
  "codeSigningValidationCategory" : 10,
  "codeSigningTrustLevel" : 4294967295,
  "codeSigningAuxiliaryInfo" : 0,
  "instructionByteStream" : {"beforePC":"AwsAsGOsHpFkYgWUoMNfuP17SKn\/QwKRwANf1v9DANHgBwD56AdA+Q==","atPC":"CQFAOegHQPkIBUA5CCEJCwA9ABL\/QwCRwANf1v9DANHgBwD56AdA+Q=="},
  "bootSessionUUID" : "F83CE823-E8D2-48AA-A3EB-545EF4CFA94A",
  "wakeTime" : 6935,
  "sleepWakeUUID" : "A59BC62A-396C-48DD-B1D8-4A426C4388C7",
  "sip" : "enabled",
  "vmRegionInfo" : "0 is not in any region.  Bytes before following region: 4311367680\n      REGION TYPE                    START - END         [ VSIZE] PRT\/MAX SHRMOD  REGION DETAIL\n      UNUSED SPACE AT START\n--->  \n      __TEXT                      100fa4000-100fb0000    [   48K] r-x\/r-x SM=COW  \/Users\/USER\/*\/mrstruijk",
  "exception" : {"codes":"0x0000000000000001, 0x0000000000000000","rawCodes":[1,0],"type":"EXC_BAD_ACCESS","signal":"SIGSEGV","subtype":"KERN_INVALID_ADDRESS at 0x0000000000000000"},
  "termination" : {"flags":0,"code":11,"namespace":"SIGNAL","indicator":"Segmentation fault: 11","byProc":"exc handler","byPid":51749},
  "vmregioninfo" : "0 is not in any region.  Bytes before following region: 4311367680\n      REGION TYPE                    START - END         [ VSIZE] PRT\/MAX SHRMOD  REGION DETAIL\n      UNUSED SPACE AT START\n--->  \n      __TEXT                      100fa4000-100fb0000    [   48K] r-x\/r-x SM=COW  \/Users\/USER\/*\/mrstruijk",
  "extMods" : {"caller":{"thread_create":0,"thread_set_state":0,"task_for_pid":0},"system":{"thread_create":0,"thread_set_state":0,"task_for_pid":0},"targeted":{"thread_create":0,"thread_set_state":0,"task_for_pid":0},"warnings":0},
  "faultingThread" : 0,
  "threads" : [{"threadState":{"x":[{"value":0},{"value":127},{"value":0},{"value":44820424764},{"value":6155503156},{"value":6155503152},{"value":63},{"value":18446726482597246976},{"value":0},{"value":0},{"value":224},{"value":61},{"value":3080},{"value":30244648601541088},{"value":24576},{"value":93},{"value":6654055296,"symbolLocation":0,"symbol":"_platform_memmove"},{"value":28843545056},{"value":0},{"value":6155506368},{"value":1},{"value":6155506824},{"value":6155506776},{"value":8},{"value":6155506776},{"value":6155506272},{"value":6155506160},{"value":6155506032},{"value":6155506776}],"flavor":"ARM_THREAD_STATE64","lr":{"value":5497651772},"cpsr":{"value":2147487744},"fp":{"value":6155503424},"sp":{"value":6155503280},"esr":{"value":2449473542,"description":"(Data Abort) byte read Translation fault"},"pc":{"value":5497653352,"matchesCrashFrame":1},"far":{"value":0}},"id":4325468,"triggered":true,"name":"SK_StereoKit_C#","queue":"com.apple.main-thread","frames":[{"imageOffset":2230376,"sourceLine":1285,"sourceFile":"stb_truetype.h","symbol":"ttUSHORT(unsigned char*)","imageIndex":7,"symbolLocation":12},{"imageOffset":2228796,"sourceLine":1500,"sourceFile":"stb_truetype.h","symbol":"stbtt_FindGlyphIndex","imageIndex":7,"symbolLocation":60},{"imageOffset":1376028,"sourceLine":587,"sourceFile":"font.cpp","symbol":"sk::font_find_glyph(sk::_font_t*, char32_t)","imageIndex":7,"symbolLocation":96},{"imageOffset":1370464,"sourceLine":599,"sourceFile":"font.cpp","symbol":"sk::font_add_character(sk::_font_t*, char32_t)","imageIndex":7,"symbolLocation":40},{"imageOffset":1370016,"sourceLine":255,"sourceFile":"font.cpp","symbol":"sk::font_setup(sk::_font_t*)","imageIndex":7,"symbolLocation":236},{"imageOffset":1369672,"sourceLine":324,"sourceFile":"font.cpp","symbol":"font_create_files","imageIndex":7,"symbolLocation":384},{"imageOffset":1379280,"sourceLine":670,"sourceFile":"font.cpp","symbol":"font_create_family","imageIndex":7,"symbolLocation":196},{"imageOffset":4430861044,"imageIndex":11},{"imageOffset":4439539424,"imageIndex":11},{"imageOffset":4439538928,"imageIndex":11},{"imageOffset":4430939320,"imageIndex":11},{"imageOffset":4430929760,"imageIndex":11},{"imageOffset":4430926836,"imageIndex":11},{"imageOffset":4430832564,"imageIndex":11},{"imageOffset":2932864,"symbol":"CallDescrWorkerInternal","symbolLocation":132,"imageIndex":3},{"imageOffset":1799440,"symbol":"CallDescrWorkerWithHandler(CallDescrData*, int)","symbolLocation":104,"imageIndex":3},{"imageOffset":1800620,"symbol":"MethodDescCallSite::CallTargetWorker(unsigned long long const*, unsigned long long*, int)","symbolLocation":612,"imageIndex":3},{"imageOffset":973216,"symbol":"RunMain(MethodDesc*, short, int*, PtrArray**)","symbolLocation":540,"imageIndex":3},{"imageOffset":973948,"symbol":"Assembly::ExecuteMainMethod(PtrArray**, int)","symbolLocation":260,"imageIndex":3},{"imageOffset":1097664,"symbol":"CorHost2::ExecuteAssembly(unsigned int, char16_t const*, int, char16_t const**, unsigned int*)","symbolLocation":564,"imageIndex":3},{"imageOffset":13536,"symbol":"coreclr_execute_assembly","symbolLocation":232,"imageIndex":3},{"imageOffset":74040,"symbol":"run_app_for_context(hostpolicy_context_t const&, int, char const**)","symbolLocation":604,"imageIndex":2},{"imageOffset":74476,"symbol":"run_app(int, char const**)","symbolLocation":56,"imageIndex":2},{"imageOffset":76536,"symbol":"corehost_main","symbolLocation":160,"imageIndex":2},{"imageOffset":41256,"symbol":"fx_muxer_t::handle_exec_host_command(std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>> const&, host_startup_info_t const&, std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>> const&, std::__1::unordered_map<known_options, std::__1::vector<std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>, std::__1::allocator<std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>>>, known_options_hash, std::__1::equal_to<known_options>, std::__1::allocator<std::__1::pair<known_options const, std::__1::vector<std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>, std::__1::allocator<std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>>>>>> const&, int, char const**, int, host_mode_t, bool, char*, int, int*)","symbolLocation":924,"imageIndex":1},{"imageOffset":38332,"symbol":"fx_muxer_t::execute(std::__1::basic_string<char, std::__1::char_traits<char>, std::__1::allocator<char>>, int, char const**, host_startup_info_t const&, char*, int, int*)","symbolLocation":616,"imageIndex":1},{"imageOffset":25200,"symbol":"hostfxr_main_startupinfo","symbolLocation":128,"imageIndex":1},{"imageOffset":6988,"symbol":"exe_start(int, char const**)","symbolLocation":1364,"imageIndex":0},{"imageOffset":7584,"symbol":"main","symbolLocation":184,"imageIndex":0},{"imageOffset":36180,"symbol":"start","symbolLocation":7184,"imageIndex":12}]},{"id":4325469,"frames":[{"imageOffset":3124,"symbol":"mach_msg2_trap","symbolLocation":8,"imageIndex":14},{"imageOffset":77864,"symbol":"mach_msg2_internal","symbolLocation":76,"imageIndex":14},{"imageOffset":39308,"symbol":"mach_msg_overwrite","symbolLocation":484,"imageIndex":14},{"imageOffset":4020,"symbol":"mach_msg","symbolLocation":24,"imageIndex":14},{"imageOffset":3153508,"symbol":"MachMessage::Receive(unsigned int)","symbolLocation":80,"imageIndex":3},{"imageOffset":3150392,"symbol":"SEHExceptionThread(void*)","symbolLocation":116,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}],"threadState":{"x":[{"value":268451845},{"value":17179869190},{"value":2147488018},{"value":31898722140971},{"value":10329396346880},{"value":31898722107392},{"value":5356},{"value":0},{"value":0},{"value":17179869184},{"value":5356},{"value":0},{"value":2405},{"value":0},{"value":7427},{"value":10},{"value":18446744073709551569},{"value":12550879322},{"value":0},{"value":0},{"value":5356},{"value":31898722107392},{"value":10329396346880},{"value":31898722140971},{"value":6156057664},{"value":2147488018},{"value":17179869190},{"value":18446744073709550527},{"value":6}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6653816872},"cpsr":{"value":4096},"fp":{"value":6156054848},"sp":{"value":6156054768},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653742132},"far":{"value":0}}},{"id":4325470,"name":".NET SynchManager","threadState":{"x":[{"value":4},{"value":0},{"value":1},{"value":4318423980},{"value":1},{"value":0},{"value":0},{"value":0},{"value":6157692624},{"value":4293967296},{"value":1000000},{"value":0},{"value":897308867665942},{"value":879712386652180},{"value":1024000},{"value":11},{"value":363},{"value":838959124},{"value":0},{"value":6157692767},{"value":1},{"value":4294967295},{"value":4318423936},{"value":250},{"value":0},{"value":0},{"value":1},{"value":18446744073708551616},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":4399385900},"cpsr":{"value":1610616832},"fp":{"value":6157692736},"sp":{"value":6157692592},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653767472},"far":{"value":0}},"frames":[{"imageOffset":28464,"symbol":"kevent","symbolLocation":8,"imageIndex":14},{"imageOffset":3116332,"symbol":"CorUnix::CPalSynchronizationManager::ReadBytesFromProcessPipe(int, unsigned char*, int)","symbolLocation":216,"imageIndex":3},{"imageOffset":3115224,"symbol":"CorUnix::CPalSynchronizationManager::WorkerThread(void*)","symbolLocation":112,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325471,"name":".NET EventPipe","threadState":{"x":[{"value":4},{"value":0},{"value":4294967295},{"value":1},{"value":0},{"value":6159314320},{"value":125},{"value":0},{"value":4318430124},{"value":4318434456},{"value":1},{"value":2},{"value":9},{"value":3587495604487722849},{"value":64},{"value":0},{"value":417},{"value":2},{"value":0},{"value":4318430112},{"value":4396497592,"symbolLocation":0,"symbol":"server_warning_callback(char const*, unsigned int)"},{"value":1},{"value":4318434416},{"value":4294967295},{"value":4399703460},{"value":500},{"value":1},{"value":4294967295},{"value":6159314448}],"flavor":"ARM_THREAD_STATE64","lr":{"value":4396813260},"cpsr":{"value":1610616832},"fp":{"value":6159314352},"sp":{"value":6159314272},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653797868},"far":{"value":0}},"frames":[{"imageOffset":58860,"symbol":"__poll_nocancel","symbolLocation":8,"imageIndex":14},{"imageOffset":543692,"symbol":"ds_ipc_poll(_DiagnosticsIpcPollHandle*, unsigned long, unsigned int, void (*)(char const*, unsigned int))","symbolLocation":176,"imageIndex":3},{"imageOffset":170192,"symbol":"ds_ipc_stream_factory_get_next_available_stream(void (*)(char const*, unsigned int))","symbolLocation":672,"imageIndex":3},{"imageOffset":182316,"symbol":"server_thread(void*)","symbolLocation":284,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325472,"name":".NET DebugPipe","threadState":{"x":[{"value":4},{"value":0},{"value":0},{"value":4318456528},{"value":4318456512},{"value":14},{"value":0},{"value":0},{"value":1},{"value":17850767997333012595},{"value":8796093029888},{"value":26388279074304},{"value":3},{"value":5805},{"value":180},{"value":0},{"value":398},{"value":8491675936},{"value":0},{"value":0},{"value":4318453852},{"value":0},{"value":0},{"value":6160936624},{"value":6160936320},{"value":4020},{"value":4318454388},{"value":4318454400},{"value":3}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6653826852},"cpsr":{"value":1610616832},"fp":{"value":6160936160},"sp":{"value":6160936112},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653745460},"far":{"value":0}},"frames":[{"imageOffset":6452,"symbol":"__open_nocancel","symbolLocation":8,"imageIndex":14},{"imageOffset":87844,"symbol":"open$NOCANCEL","symbolLocation":64,"imageIndex":14},{"imageOffset":542240,"symbol":"TwoWayPipe::WaitForConnection()","symbolLocation":40,"imageIndex":3},{"imageOffset":527476,"symbol":"DbgTransportSession::TransportWorker()","symbolLocation":164,"imageIndex":3},{"imageOffset":524380,"symbol":"DbgTransportSession::TransportWorkerStatic(void*)","symbolLocation":40,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325473,"name":".NET Debugger","threadState":{"x":[{"value":260},{"value":0},{"value":0},{"value":0},{"value":0},{"value":160},{"value":0},{"value":0},{"value":1},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":4318456984},{"value":4318457048},{"value":1},{"value":0},{"value":0},{"value":0},{"value":1},{"value":256},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6162557984},"sp":{"value":6162557840},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}},"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111136,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":156,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":519352,"symbol":"DebuggerRCThread::MainLoop()","symbolLocation":200,"imageIndex":3},{"imageOffset":519068,"symbol":"DebuggerRCThread::ThreadProc()","symbolLocation":260,"imageIndex":3},{"imageOffset":518476,"symbol":"DebuggerRCThread::ThreadProcStatic(void*)","symbolLocation":56,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325474,"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111124,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":144,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void*const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":3121868,"symbol":"WaitForSingleObjectEx","symbolLocation":80,"imageIndex":3},{"imageOffset":2379920,"symbol":"CLREventBase::WaitEx(unsigned int, WaitMode, PendingSync*)","symbolLocation":188,"imageIndex":3},{"imageOffset":1982192,"symbol":"FinalizerThread::WaitForFinalizerEvent(CLREvent*)","symbolLocation":48,"imageIndex":3},{"imageOffset":1982584,"symbol":"FinalizerThread::FinalizerThreadWorker(void*)","symbolLocation":144,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1983416,"symbol":"FinalizerThread::FinalizerThreadStart(void*)","symbolLocation":92,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}],"threadState":{"x":[{"value":260},{"value":0},{"value":29952},{"value":0},{"value":0},{"value":160},{"value":1},{"value":999999000},{"value":29953},{"value":0},{"value":256},{"value":1099511628034},{"value":1099511628034},{"value":256},{"value":0},{"value":1099511628032},{"value":305},{"value":8491667320},{"value":0},{"value":44808864216},{"value":44808864280},{"value":1},{"value":999999000},{"value":1},{"value":29952},{"value":29953},{"value":30208},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6164178992},"sp":{"value":6164178848},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}}},{"id":4325475,"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111124,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":144,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":3121868,"symbol":"WaitForSingleObjectEx","symbolLocation":80,"imageIndex":3},{"imageOffset":2379920,"symbol":"CLREventBase::WaitEx(unsigned int, WaitMode, PendingSync*)","symbolLocation":188,"imageIndex":3},{"imageOffset":1657316,"symbol":"TieredCompilationManager::BackgroundWorkerStart()","symbolLocation":316,"imageIndex":3},{"imageOffset":1656956,"symbol":"TieredCompilationManager::BackgroundWorkerBootstrapper1(void*)","symbolLocation":88,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1656760,"symbol":"TieredCompilationManager::BackgroundWorkerBootstrapper0(void*)","symbolLocation":40,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}],"threadState":{"x":[{"value":260},{"value":0},{"value":32512},{"value":0},{"value":0},{"value":160},{"value":3},{"value":999999000},{"value":33025},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":44808868824},{"value":44808868888},{"value":1},{"value":999999000},{"value":3},{"value":32512},{"value":33025},{"value":33280},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6165801600},"sp":{"value":6165801456},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}}},{"id":4325476,"frames":[{"imageOffset":5004,"symbol":"pthread_mutex_lock","symbolLocation":12,"imageIndex":15},{"imageOffset":2400616,"sourceLine":148,"sourceFile":"ferr_thread.h","symbol":"ft_mutex_lock(_ft_mutex_t*)","imageIndex":7,"symbolLocation":24},{"imageOffset":1348788,"sourceLine":858,"sourceFile":"assets.cpp","symbol":"sk::asset_step_blocking_job()","imageIndex":7,"symbolLocation":28},{"imageOffset":1342812,"sourceLine":893,"sourceFile":"assets.cpp","symbol":"sk::asset_thread(void*)","imageIndex":7,"symbolLocation":284},{"imageOffset":2401256,"sourceLine":274,"sourceFile":"ferr_thread.h","symbol":"_ft_thread_wrapper(void*)","imageIndex":7,"symbolLocation":44},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}],"threadState":{"x":[{"value":44811947584},{"value":44821479296},{"value":0},{"value":0},{"value":2},{"value":6166375791},{"value":6166375695},{"value":18446726482597246976},{"value":5499830272,"symbolLocation":1590,"symbol":"basist::g_bc7_mode_6_optimal_endpoints"},{"value":1},{"value":17},{"value":14848904536572162},{"value":14848904536572160},{"value":14848904536572162},{"value":3457024},{"value":256},{"value":6653993856,"symbolLocation":0,"symbol":"pthread_mutex_lock"},{"value":8491667336},{"value":0},{"value":6166376448},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":5497823592},"cpsr":{"value":2147487744},"fp":{"value":6166376128},"sp":{"value":6166376128},"esr":{"value":2449473542,"description":"(Data Abort) byte read Translation fault"},"pc":{"value":6653993868},"far":{"value":0}}},{"id":4325477,"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28892,"symbol":"_pthread_cond_wait","symbolLocation":984,"imageIndex":15},{"imageOffset":2400996,"sourceLine":202,"sourceFile":"ferr_thread.h","symbol":"ft_condition_wait(_ft_condition_t*, _ft_mutex_t*)","imageIndex":7,"symbolLocation":32},{"imageOffset":1342888,"sourceLine":897,"sourceFile":"assets.cpp","symbol":"sk::asset_thread(void*)","imageIndex":7,"symbolLocation":360},{"imageOffset":2401256,"sourceLine":274,"sourceFile":"ferr_thread.h","symbol":"_ft_thread_wrapper(void*)","imageIndex":7,"symbolLocation":44},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}],"threadState":{"x":[{"value":260},{"value":0},{"value":96512},{"value":0},{"value":0},{"value":160},{"value":0},{"value":0},{"value":6166949496},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":44821478976},{"value":44808192192},{"value":6166950112},{"value":0},{"value":0},{"value":96512},{"value":96513},{"value":96768},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017756},"cpsr":{"value":1610616832},"fp":{"value":6166949616},"sp":{"value":6166949472},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}}},{"id":4325478,"frames":[{"imageOffset":6468,"symbol":"pthread_mutex_unlock","symbolLocation":120,"imageIndex":15},{"imageOffset":2400652,"sourceLine":158,"sourceFile":"ferr_thread.h","symbol":"ft_mutex_unlock(_ft_mutex_t*)","imageIndex":7,"symbolLocation":24},{"imageOffset":1347496,"sourceLine":729,"sourceFile":"assets.cpp","symbol":"sk::assets_acquire_task()","imageIndex":7,"symbolLocation":60},{"imageOffset":1343632,"sourceLine":789,"sourceFile":"assets.cpp","symbol":"sk::asset_step_task()","imageIndex":7,"symbolLocation":16},{"imageOffset":1342816,"sourceLine":894,"sourceFile":"assets.cpp","symbol":"sk::asset_thread(void*)","imageIndex":7,"symbolLocation":288},{"imageOffset":2401256,"sourceLine":274,"sourceFile":"ferr_thread.h","symbol":"_ft_thread_wrapper(void*)","imageIndex":7,"symbolLocation":44},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}],"threadState":{"x":[{"value":0},{"value":44821479104},{"value":0},{"value":0},{"value":2},{"value":160},{"value":0},{"value":0},{"value":44811947680},{"value":14848904536572162},{"value":14848904536572160},{"value":14848904536572162},{"value":3457280},{"value":14848904536572160},{"value":119008512},{"value":256},{"value":6653995212,"symbolLocation":0,"symbol":"pthread_mutex_unlock"},{"value":8491667328},{"value":0},{"value":6167523328},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":5497823628},"cpsr":{"value":1610616832},"fp":{"value":6167522912},"sp":{"value":6167522912},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653995332},"far":{"value":0}}},{"id":4325479,"frames":[],"threadState":{"x":[{"value":6168096768},{"value":15363},{"value":6167560192},{"value":0},{"value":409604},{"value":18446744073709551615},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":0},"cpsr":{"value":4096},"fp":{"value":0},"sp":{"value":6168096768},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653995924},"far":{"value":0}}},{"id":4325489,"name":"com.apple.NSEventThread","threadState":{"x":[{"value":268451845},{"value":21592279046},{"value":8589934592},{"value":108864536051712},{"value":0},{"value":108864536051712},{"value":2},{"value":4294967295},{"value":0},{"value":17179869184},{"value":0},{"value":2},{"value":0},{"value":0},{"value":25347},{"value":0},{"value":18446744073709551569},{"value":8491669208},{"value":0},{"value":4294967295},{"value":2},{"value":108864536051712},{"value":0},{"value":108864536051712},{"value":6170386568},{"value":8589934592},{"value":21592279046},{"value":18446744073709550527},{"value":4412409862}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6653816872},"cpsr":{"value":4096},"fp":{"value":6170386416},"sp":{"value":6170386336},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653742132},"far":{"value":0}},"frames":[{"imageOffset":3124,"symbol":"mach_msg2_trap","symbolLocation":8,"imageIndex":14},{"imageOffset":77864,"symbol":"mach_msg2_internal","symbolLocation":76,"imageIndex":14},{"imageOffset":39308,"symbol":"mach_msg_overwrite","symbolLocation":484,"imageIndex":14},{"imageOffset":4020,"symbol":"mach_msg","symbolLocation":24,"imageIndex":14},{"imageOffset":392112,"symbol":"__CFRunLoopServiceMachPort","symbolLocation":160,"imageIndex":16},{"imageOffset":386312,"symbol":"__CFRunLoopRun","symbolLocation":1188,"imageIndex":16},{"imageOffset":1150780,"symbol":"_CFRunLoopRunSpecificWithOptions","symbolLocation":532,"imageIndex":16},{"imageOffset":719412,"symbol":"_NSEventThread","symbolLocation":184,"imageIndex":17},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325498,"name":"caulk.messenger.shared:17","threadState":{"x":[{"value":14},{"value":29494347610},{"value":0},{"value":6170964074},{"value":29494347584},{"value":25},{"value":0},{"value":0},{"value":0},{"value":4294967295},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":18446744073709551580},{"value":8491671712},{"value":0},{"value":44809234528},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6862229000},"cpsr":{"value":2147487744},"fp":{"value":6170963840},"sp":{"value":6170963808},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653742000},"far":{"value":0}},"frames":[{"imageOffset":2992,"symbol":"semaphore_wait_trap","symbolLocation":8,"imageIndex":14},{"imageOffset":7688,"symbol":"caulk::semaphore::timed_wait(double)","symbolLocation":224,"imageIndex":18},{"imageOffset":7344,"symbol":"caulk::concurrent::details::worker_thread::run()","symbolLocation":32,"imageIndex":18},{"imageOffset":6480,"symbol":"void*caulk::thread_proxy<std::__1::tuple<caulk::thread::attributes, void (caulk::concurrent::details::worker_thread::*)(), std::__1::tuple<caulk::concurrent::details::worker_thread*>>>(void*)","symbolLocation":96,"imageIndex":18},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325499,"name":"caulk.messenger.shared:high","threadState":{"x":[{"value":14},{"value":63235},{"value":63235},{"value":15},{"value":4294967295},{"value":0},{"value":0},{"value":0},{"value":0},{"value":4294967295},{"value":1},{"value":44795188968},{"value":0},{"value":0},{"value":0},{"value":0},{"value":18446744073709551580},{"value":8491671712},{"value":0},{"value":44809234304},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6862229000},"cpsr":{"value":2147487744},"fp":{"value":6171537280},"sp":{"value":6171537248},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653742000},"far":{"value":0}},"frames":[{"imageOffset":2992,"symbol":"semaphore_wait_trap","symbolLocation":8,"imageIndex":14},{"imageOffset":7688,"symbol":"caulk::semaphore::timed_wait(double)","symbolLocation":224,"imageIndex":18},{"imageOffset":7344,"symbol":"caulk::concurrent::details::worker_thread::run()","symbolLocation":32,"imageIndex":18},{"imageOffset":6480,"symbol":"void* caulk::thread_proxy<std::__1::tuple<caulk::thread::attributes, void (caulk::concurrent::details::worker_thread::*)(), std::__1::tuple<caulk::concurrent::details::worker_thread*>>>(void*)","symbolLocation":96,"imageIndex":18},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325541,"name":"caulk::deferred_logger","threadState":{"x":[{"value":14},{"value":44822127639},{"value":0},{"value":6172110951},{"value":44822127616},{"value":22},{"value":0},{"value":0},{"value":0},{"value":4294967295},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":18446744073709551580},{"value":8491671712},{"value":0},{"value":44809330616},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6862229000},"cpsr":{"value":2147487744},"fp":{"value":6172110720},"sp":{"value":6172110688},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653742000},"far":{"value":0}},"frames":[{"imageOffset":2992,"symbol":"semaphore_wait_trap","symbolLocation":8,"imageIndex":14},{"imageOffset":7688,"symbol":"caulk::semaphore::timed_wait(double)","symbolLocation":224,"imageIndex":18},{"imageOffset":7344,"symbol":"caulk::concurrent::details::worker_thread::run()","symbolLocation":32,"imageIndex":18},{"imageOffset":6480,"symbol":"void*caulk::thread_proxy<std::__1::tuple<caulk::thread::attributes, void (caulk::concurrent::details::worker_thread::*)(), std::__1::tuple<caulk::concurrent::details::worker_thread*>>>(void*)","symbolLocation":96,"imageIndex":18},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325542,"name":"com.apple.audio.IOThread.client","threadState":{"x":[{"value":14},{"value":95747},{"value":0},{"value":0},{"value":0},{"value":32},{"value":5601771584},{"value":18446726482597246976},{"value":1},{"value":17850767997333012595},{"value":1099511628032},{"value":1099511628034},{"value":48},{"value":3840},{"value":0},{"value":5572051312},{"value":18446744073709551579},{"value":8491671720},{"value":0},{"value":44816407352},{"value":44816407344},{"value":44816407376},{"value":1},{"value":44821291232},{"value":1646},{"value":0},{"value":6712845541},{"value":44816407344},{"value":44816406528}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6862348204},"cpsr":{"value":1610616832},"fp":{"value":6172683520},"sp":{"value":6172683504},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653742012},"far":{"value":0}},"frames":[{"imageOffset":3004,"symbol":"semaphore_wait_signal_trap","symbolLocation":8,"imageIndex":14},{"imageOffset":126892,"symbol":"caulk::mach::semaphore::wait_signal_or_error(caulk::mach::semaphore&)","symbolLocation":36,"imageIndex":18},{"imageOffset":2135756,"symbol":"HALC_ProxyIOContext::IOWorkLoop()","symbolLocation":5052,"imageIndex":19},{"imageOffset":2129000,"symbol":"invocation function for block in HALC_ProxyIOContext::HALC_ProxyIOContext(unsigned int, unsigned int)","symbolLocation":172,"imageIndex":19},{"imageOffset":3985164,"symbol":"HALC_IOThread::Entry(void*)","symbolLocation":88,"imageIndex":19},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325569,"frames":[],"threadState":{"x":[{"value":6173831168},{"value":105987},{"value":6173294592},{"value":0},{"value":409604},{"value":18446744073709551615},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":0},"cpsr":{"value":4096},"fp":{"value":0},"sp":{"value":6173831168},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653995924},"far":{"value":0}}},{"id":4325571,"frames":[],"threadState":{"x":[{"value":6174978048},{"value":106243},{"value":6174441472},{"value":0},{"value":409604},{"value":18446744073709551615},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":0},"cpsr":{"value":4096},"fp":{"value":0},"sp":{"value":6174978048},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653995924},"far":{"value":0}}},{"id":4325572,"frames":[],"threadState":{"x":[{"value":6175551488},{"value":106755},{"value":6175014912},{"value":0},{"value":409604},{"value":18446744073709551615},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":0},"cpsr":{"value":4096},"fp":{"value":0},"sp":{"value":6175551488},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653995924},"far":{"value":0}}},{"id":4325573,"frames":[],"threadState":{"x":[{"value":6176124928},{"value":107011},{"value":6175588352},{"value":0},{"value":409604},{"value":18446744073709551615},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":0},"cpsr":{"value":4096},"fp":{"value":0},"sp":{"value":6176124928},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653995924},"far":{"value":0}}},{"id":4325574,"frames":[],"threadState":{"x":[{"value":6176698368},{"value":0},{"value":6176161792},{"value":0},{"value":278532},{"value":18446744073709551615},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0},{"value":0}],"flavor":"ARM_THREAD_STATE64","lr":{"value":0},"cpsr":{"value":4096},"fp":{"value":0},"sp":{"value":6176698368},"esr":{"value":0},"pc":{"value":6653995924},"far":{"value":0}}},{"id":4325940,"name":".NET TP Worker","threadState":{"x":[{"value":260},{"value":0},{"value":0},{"value":0},{"value":0},{"value":160},{"value":19},{"value":999999000},{"value":1},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":44798514136},{"value":44798514200},{"value":1},{"value":999999000},{"value":19},{"value":0},{"value":1},{"value":256},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6169716528},"sp":{"value":6169716384},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}},"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111124,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":144,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":3121772,"symbol":"PAL_WaitForSingleObjectPrioritized","symbolLocation":76,"imageIndex":3},{"imageOffset":1890000,"symbol":"WaitHandle_WaitOnePrioritized","symbolLocation":80,"imageIndex":3},{"imageOffset":4416451032,"imageIndex":11},{"imageOffset":4416451956,"imageIndex":11},{"imageOffset":4416591404,"imageIndex":11},{"imageOffset":4416429820,"imageIndex":11},{"imageOffset":2932864,"symbol":"CallDescrWorkerInternal","symbolLocation":132,"imageIndex":3},{"imageOffset":1799440,"symbol":"CallDescrWorkerWithHandler(CallDescrData*, int)","symbolLocation":104,"imageIndex":3},{"imageOffset":1799948,"symbol":"DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int)","symbolLocation":184,"imageIndex":3},{"imageOffset":1870720,"symbol":"KickOffThread_Worker(void*)","symbolLocation":144,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1864232,"symbol":"KickOffThread(void*)","symbolLocation":212,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325941,"name":".NET TP Gate","threadState":{"x":[{"value":260},{"value":0},{"value":768},{"value":0},{"value":0},{"value":160},{"value":0},{"value":0},{"value":1281},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":44798509528},{"value":44798509592},{"value":1},{"value":0},{"value":0},{"value":768},{"value":1281},{"value":1536},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6172993040},"sp":{"value":6172992896},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}},"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111136,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":156,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void*const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":1636904,"symbol":"Thread::DoAppropriateWaitWorker(int, void**, int, unsigned int, WaitMode, void*)","symbolLocation":936,"imageIndex":3},{"imageOffset":1621612,"symbol":"Thread::DoAppropriateWait(int, void**, int, unsigned int, WaitMode, PendingSync*)","symbolLocation":136,"imageIndex":3},{"imageOffset":1888852,"symbol":"WaitHandle_WaitOneCore","symbolLocation":108,"imageIndex":3},{"imageOffset":4416445268,"imageIndex":11},{"imageOffset":4416580904,"imageIndex":11},{"imageOffset":4416429820,"imageIndex":11},{"imageOffset":2932864,"symbol":"CallDescrWorkerInternal","symbolLocation":132,"imageIndex":3},{"imageOffset":1799440,"symbol":"CallDescrWorkerWithHandler(CallDescrData*, int)","symbolLocation":104,"imageIndex":3},{"imageOffset":1799948,"symbol":"DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int)","symbolLocation":184,"imageIndex":3},{"imageOffset":1870720,"symbol":"KickOffThread_Worker(void*)","symbolLocation":144,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1864232,"symbol":"KickOffThread(void*)","symbolLocation":212,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325942,"name":".NET TP Worker","threadState":{"x":[{"value":260},{"value":0},{"value":0},{"value":0},{"value":0},{"value":160},{"value":20},{"value":0},{"value":1},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":44798511064},{"value":44798511128},{"value":1},{"value":0},{"value":20},{"value":0},{"value":1},{"value":256},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6178318128},"sp":{"value":6178317984},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}},"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111124,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":144,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":3121772,"symbol":"PAL_WaitForSingleObjectPrioritized","symbolLocation":76,"imageIndex":3},{"imageOffset":1890000,"symbol":"WaitHandle_WaitOnePrioritized","symbolLocation":80,"imageIndex":3},{"imageOffset":4416451032,"imageIndex":11},{"imageOffset":4416451956,"imageIndex":11},{"imageOffset":4416591404,"imageIndex":11},{"imageOffset":4416429820,"imageIndex":11},{"imageOffset":2932864,"symbol":"CallDescrWorkerInternal","symbolLocation":132,"imageIndex":3},{"imageOffset":1799440,"symbol":"CallDescrWorkerWithHandler(CallDescrData*, int)","symbolLocation":104,"imageIndex":3},{"imageOffset":1799948,"symbol":"DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int)","symbolLocation":184,"imageIndex":3},{"imageOffset":1870720,"symbol":"KickOffThread_Worker(void*)","symbolLocation":144,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1864232,"symbol":"KickOffThread(void*)","symbolLocation":212,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325943,"name":".NET TP Worker","threadState":{"x":[{"value":260},{"value":0},{"value":0},{"value":0},{"value":0},{"value":160},{"value":19},{"value":999999000},{"value":1},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":44798517208},{"value":44798517272},{"value":1},{"value":999999000},{"value":19},{"value":0},{"value":1},{"value":256},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6179940144},"sp":{"value":6179940000},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}},"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111124,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":144,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void*const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":3121772,"symbol":"PAL_WaitForSingleObjectPrioritized","symbolLocation":76,"imageIndex":3},{"imageOffset":1890000,"symbol":"WaitHandle_WaitOnePrioritized","symbolLocation":80,"imageIndex":3},{"imageOffset":4416451032,"imageIndex":11},{"imageOffset":4416451956,"imageIndex":11},{"imageOffset":4416591404,"imageIndex":11},{"imageOffset":4416429820,"imageIndex":11},{"imageOffset":2932864,"symbol":"CallDescrWorkerInternal","symbolLocation":132,"imageIndex":3},{"imageOffset":1799440,"symbol":"CallDescrWorkerWithHandler(CallDescrData*, int)","symbolLocation":104,"imageIndex":3},{"imageOffset":1799948,"symbol":"DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int)","symbolLocation":184,"imageIndex":3},{"imageOffset":1870720,"symbol":"KickOffThread_Worker(void*)","symbolLocation":144,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1864232,"symbol":"KickOffThread(void*)","symbolLocation":212,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325944,"name":".NET TP Worker","threadState":{"x":[{"value":260},{"value":0},{"value":1667584},{"value":0},{"value":0},{"value":160},{"value":20},{"value":0},{"value":1667585},{"value":0},{"value":256},{"value":1099511628034},{"value":1099511628034},{"value":256},{"value":0},{"value":1099511628032},{"value":305},{"value":8491667320},{"value":0},{"value":44798518744},{"value":44798518808},{"value":1},{"value":0},{"value":20},{"value":1667584},{"value":1667585},{"value":1667840},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6181562160},"sp":{"value":6181562016},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}},"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111124,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":144,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":3121772,"symbol":"PAL_WaitForSingleObjectPrioritized","symbolLocation":76,"imageIndex":3},{"imageOffset":1890000,"symbol":"WaitHandle_WaitOnePrioritized","symbolLocation":80,"imageIndex":3},{"imageOffset":4416451032,"imageIndex":11},{"imageOffset":4416451956,"imageIndex":11},{"imageOffset":4416591404,"imageIndex":11},{"imageOffset":4416429820,"imageIndex":11},{"imageOffset":2932864,"symbol":"CallDescrWorkerInternal","symbolLocation":132,"imageIndex":3},{"imageOffset":1799440,"symbol":"CallDescrWorkerWithHandler(CallDescrData*, int)","symbolLocation":104,"imageIndex":3},{"imageOffset":1799948,"symbol":"DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int)","symbolLocation":184,"imageIndex":3},{"imageOffset":1870720,"symbol":"KickOffThread_Worker(void*)","symbolLocation":144,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1864232,"symbol":"KickOffThread(void*)","symbolLocation":212,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325945,"name":".NET TP Worker","threadState":{"x":[{"value":260},{"value":0},{"value":92672},{"value":0},{"value":0},{"value":160},{"value":19},{"value":999999000},{"value":92673},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":44798520280},{"value":44798520344},{"value":1},{"value":999999000},{"value":19},{"value":92672},{"value":92673},{"value":92928},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6183184176},"sp":{"value":6183184032},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}},"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111124,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":144,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void*const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":3121772,"symbol":"PAL_WaitForSingleObjectPrioritized","symbolLocation":76,"imageIndex":3},{"imageOffset":1890000,"symbol":"WaitHandle_WaitOnePrioritized","symbolLocation":80,"imageIndex":3},{"imageOffset":4416451032,"imageIndex":11},{"imageOffset":4416451956,"imageIndex":11},{"imageOffset":4416591404,"imageIndex":11},{"imageOffset":4416429820,"imageIndex":11},{"imageOffset":2932864,"symbol":"CallDescrWorkerInternal","symbolLocation":132,"imageIndex":3},{"imageOffset":1799440,"symbol":"CallDescrWorkerWithHandler(CallDescrData*, int)","symbolLocation":104,"imageIndex":3},{"imageOffset":1799948,"symbol":"DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int)","symbolLocation":184,"imageIndex":3},{"imageOffset":1870720,"symbol":"KickOffThread_Worker(void*)","symbolLocation":144,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1864232,"symbol":"KickOffThread(void*)","symbolLocation":212,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]},{"id":4325960,"name":".NET TP Worker","threadState":{"x":[{"value":260},{"value":0},{"value":0},{"value":0},{"value":0},{"value":160},{"value":19},{"value":999999000},{"value":1},{"value":0},{"value":0},{"value":2},{"value":2},{"value":0},{"value":0},{"value":0},{"value":305},{"value":8491667320},{"value":0},{"value":44798515672},{"value":44798515736},{"value":1},{"value":999999000},{"value":19},{"value":0},{"value":1},{"value":256},{"value":1},{"value":1}],"flavor":"ARM_THREAD_STATE64","lr":{"value":6654017800},"cpsr":{"value":2684358656},"fp":{"value":6184806192},"sp":{"value":6184806048},"esr":{"value":1442840704,"description":"(Syscall)"},"pc":{"value":6653756664},"far":{"value":0}},"frames":[{"imageOffset":17656,"symbol":"__psynch_cvwait","symbolLocation":8,"imageIndex":14},{"imageOffset":28936,"symbol":"_pthread_cond_wait","symbolLocation":1028,"imageIndex":15},{"imageOffset":3111124,"symbol":"CorUnix::CPalSynchronizationManager::ThreadNativeWait(CorUnix::_ThreadNativeWaitData*, unsigned int, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":144,"imageIndex":3},{"imageOffset":3110632,"symbol":"CorUnix::CPalSynchronizationManager::BlockThread(CorUnix::CPalThread*, unsigned int, bool, bool, CorUnix::ThreadWakeupReason*, unsigned int*)","symbolLocation":204,"imageIndex":3},{"imageOffset":3121288,"symbol":"CorUnix::InternalWaitForMultipleObjectsEx(CorUnix::CPalThread*, unsigned int, void* const*, int, unsigned int, int, int)","symbolLocation":1380,"imageIndex":3},{"imageOffset":3121772,"symbol":"PAL_WaitForSingleObjectPrioritized","symbolLocation":76,"imageIndex":3},{"imageOffset":1890000,"symbol":"WaitHandle_WaitOnePrioritized","symbolLocation":80,"imageIndex":3},{"imageOffset":4416451032,"imageIndex":11},{"imageOffset":4416451956,"imageIndex":11},{"imageOffset":4416591004,"imageIndex":11},{"imageOffset":4416429820,"imageIndex":11},{"imageOffset":2932864,"symbol":"CallDescrWorkerInternal","symbolLocation":132,"imageIndex":3},{"imageOffset":1799440,"symbol":"CallDescrWorkerWithHandler(CallDescrData*, int)","symbolLocation":104,"imageIndex":3},{"imageOffset":1799948,"symbol":"DispatchCallSimple(unsigned long*, unsigned int, unsigned long, unsigned int)","symbolLocation":184,"imageIndex":3},{"imageOffset":1870720,"symbol":"KickOffThread_Worker(void*)","symbolLocation":144,"imageIndex":3},{"imageOffset":1646240,"symbol":"ManagedThreadBase::KickOff(void (*)(void*), void*)","symbolLocation":228,"imageIndex":3},{"imageOffset":1864232,"symbol":"KickOffThread(void*)","symbolLocation":212,"imageIndex":3},{"imageOffset":3142952,"symbol":"CorUnix::CPalThread::ThreadEntry(void*)","symbolLocation":236,"imageIndex":3},{"imageOffset":27656,"symbol":"_pthread_start","symbolLocation":136,"imageIndex":15},{"imageOffset":7080,"symbol":"thread_start","symbolLocation":8,"imageIndex":15}]}],
  "usedImages" : [
  {
    "source" : "P",
    "arch" : "arm64",
    "base" : 4311367680,
    "size" : 49152,
    "uuid" : "861fbcae-efab-3630-942d-21ca1fbb05eb",
    "path" : "\/Users\/USER\/*\/mrstruijk",
    "name" : "mrstruijk"
  },
  {
    "source" : "P",
    "arch" : "arm64",
    "base" : 4312006656,
    "size" : 212992,
    "uuid" : "4d36a8a0-5ebf-3787-9f97-137816151b71",
    "path" : "\/opt\/homebrew\/*\/libhostfxr.dylib",
    "name" : "libhostfxr.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64",
    "base" : 4312907776,
    "size" : 196608,
    "uuid" : "46949b80-7b74-3c27-b209-de919a4013ce",
    "path" : "\/opt\/homebrew\/*\/libhostpolicy.dylib",
    "name" : "libhostpolicy.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64",
    "base" : 4396269568,
    "size" : 3686400,
    "uuid" : "da96a27a-75ef-3563-b1e7-dbf40c0d2530",
    "path" : "\/opt\/homebrew\/*\/libcoreclr.dylib",
    "name" : "libcoreclr.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64",
    "base" : 4312449024,
    "size" : 65536,
    "uuid" : "da48db07-9d02-3691-8f25-fe9993f563c0",
    "path" : "\/opt\/homebrew\/*\/libSystem.Native.dylib",
    "name" : "libSystem.Native.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64",
    "base" : 5485789184,
    "size" : 1900544,
    "uuid" : "0482c75e-26f7-3e06-aae9-4690e6b4866a",
    "path" : "\/opt\/homebrew\/*\/libclrjit.dylib",
    "name" : "libclrjit.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64",
    "base" : 4407279616,
    "size" : 3473408,
    "uuid" : "77e6157c-15c6-3652-b604-576bbc47b346",
    "path" : "\/Users\/USER\/*\/libMoltenVK.dylib",
    "name" : "libMoltenVK.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64",
    "base" : 5495422976,
    "size" : 4341760,
    "uuid" : "4a0916f2-7fea-3a53-b0fe-bd38a0d3f256",
    "path" : "\/Users\/USER\/*\/libStereoKitC.dylib",
    "name" : "libStereoKitC.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 5489328128,
    "size" : 49152,
    "uuid" : "f26af954-d1f7-31aa-9981-1bad216149d9",
    "path" : "\/usr\/lib\/libobjc-trampolines.dylib",
    "name" : "libobjc-trampolines.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 5572182016,
    "CFBundleShortVersionString" : "345.20.4",
    "CFBundleIdentifier" : "com.apple.AGXMetalG13X",
    "size" : 7667712,
    "uuid" : "52655256-a69f-3426-8f52-8209ab07a237",
    "path" : "\/System\/Library\/Extensions\/AGXMetalG13X.bundle\/Contents\/MacOS\/AGXMetalG13X",
    "name" : "AGXMetalG13X",
    "CFBundleVersion" : "345.20.4"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 5600198656,
    "CFBundleShortVersionString" : "1.14",
    "CFBundleIdentifier" : "com.apple.audio.units.Components",
    "size" : 1327104,
    "uuid" : "d4431c82-73db-32cd-aa69-fb5df573e77e",
    "path" : "\/System\/Library\/Components\/CoreAudio.component\/Contents\/MacOS\/CoreAudio",
    "name" : "CoreAudio",
    "CFBundleVersion" : "1.14"
  },
  {
    "size" : 0,
    "source" : "A",
    "base" : 0,
    "uuid" : "00000000-0000-0000-0000-000000000000"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 6650007552,
    "size" : 653076,
    "uuid" : "044cd67e-3a0a-3ca4-8bb3-a9687d5328fe",
    "path" : "\/usr\/lib\/dyld",
    "name" : "dyld"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 6654042112,
    "size" : 33968,
    "uuid" : "62c9cd37-272d-3d2d-9a1c-6f4ef24f7ec7",
    "path" : "\/usr\/lib\/system\/libsystem_platform.dylib",
    "name" : "libsystem_platform.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 6653739008,
    "size" : 246944,
    "uuid" : "78ec33a6-6330-3836-8900-eb90836936e8",
    "path" : "\/usr\/lib\/system\/libsystem_kernel.dylib",
    "name" : "libsystem_kernel.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 6653988864,
    "size" : 51916,
    "uuid" : "0596a7b6-bce2-3f06-a2e8-3eaab5371ed8",
    "path" : "\/usr\/lib\/system\/libsystem_pthread.dylib",
    "name" : "libsystem_pthread.dylib"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 6654275584,
    "CFBundleShortVersionString" : "6.9",
    "CFBundleIdentifier" : "com.apple.CoreFoundation",
    "size" : 5542592,
    "uuid" : "646518bb-a6e8-3da7-ab32-9d97bcbdc25d",
    "path" : "\/System\/Library\/Frameworks\/CoreFoundation.framework\/Versions\/A\/CoreFoundation",
    "name" : "CoreFoundation",
    "CFBundleVersion" : "4302"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 6725943296,
    "CFBundleShortVersionString" : "6.9",
    "CFBundleIdentifier" : "com.apple.AppKit",
    "size" : 24299264,
    "uuid" : "bf94fd49-283d-3c62-8cf0-0a49c21b6129",
    "path" : "\/System\/Library\/Frameworks\/AppKit.framework\/Versions\/C\/AppKit",
    "name" : "AppKit",
    "CFBundleVersion" : "2685.40.108"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 6862221312,
    "CFBundleShortVersionString" : "1.0",
    "CFBundleIdentifier" : "com.apple.audio.caulk",
    "size" : 167296,
    "uuid" : "67d6bcc2-f024-388e-b546-b1c2fe6f0ddc",
    "path" : "\/System\/Library\/PrivateFrameworks\/caulk.framework\/Versions\/A\/caulk",
    "name" : "caulk"
  },
  {
    "source" : "P",
    "arch" : "arm64e",
    "base" : 6705463296,
    "CFBundleShortVersionString" : "5.0",
    "CFBundleIdentifier" : "com.apple.audio.CoreAudio",
    "size" : 8065952,
    "uuid" : "16b7552a-ead3-374c-a642-5a11a7523189",
    "path" : "\/System\/Library\/Frameworks\/CoreAudio.framework\/Versions\/A\/CoreAudio",
    "name" : "CoreAudio",
    "CFBundleVersion" : "5.0"
  }
],
  "sharedCache" : {
  "base" : 6648922112,
  "size" : 5820792832,
  "uuid" : "f3e3cb1b-1c09-3cc5-ad72-f0800f1f475f"
},
  "vmSummary" : "ReadOnly portion of Libraries: Total=1.8G resident=0K(0%) swapped_out_or_unallocated=1.8G(100%)\nWritable regions: Total=611.1M written=916K(0%) resident=916K(0%) swapped_out=0K(0%) unallocated=610.2M(100%)\n\n                                VIRTUAL   REGION \nREGION TYPE                        SIZE    COUNT (non-coalesced) \n===========                     =======  ======= \n.note.gnu.proper                    320        1 \nAccelerate framework               128K        1 \nActivity Tracing                   256K        1 \nAttributeGraph Data               1024K        1 \nColorSync                           16K        1 \nCoreAnimation                      368K       22 \nCoreGraphics                        64K        4 \nCoreUI image data                  688K        7 \nFoundation                          16K        1 \nKernel Alloc Once                   32K        1 \nMALLOC                           546.0M       55 \nMALLOC guard page                 3312K        4 \nSTACK GUARD                       56.5M       29 \nStack                             34.6M       29 \nVM_ALLOCATE                        1.5G      150 \nVM_ALLOCATE (reserved)              96K        2         reserved VM address space (unallocated)\n__AUTH                            5776K      631 \n__AUTH_CONST                      87.7M     1005 \n__CTF                               824        1 \n__DATA                            34.8M      967 \n__DATA_CONST                      33.0M     1021 \n__DATA_DIRTY                      8331K      864 \n__FONT_DATA                        2352        1 \n__INFO_FILTER                         8        1 \n__LINKEDIT                       597.3M       12 \n__OBJC_RO                         78.4M        1 \n__OBJC_RW                         2571K        1 \n__TEXT                             1.2G     1038 \n__TEXT (graphics)                 16.6M        5 \n__TPRO_CONST                       128K        2 \nmapped file                      260.8M       61 \npage table in kernel               916K        1 \nshared memory                      960K       15 \n===========                     =======  ======= \nTOTAL                              4.4G     5936 \nTOTAL, minus reserved VM space     4.4G     5936 \n",
  "legacyInfo" : {
  "threadTriggered" : {
    "name" : "SK_StereoKit_C#",
    "queue" : "com.apple.main-thread"
  }
},
  "logWritingSignature" : "e0201738d6a4af91a38c0cc907ff8065d630e706",
  "roots_installed" : 0,
  "bug_type" : "309",
  "trmStatus" : 1,
  "trialInfo" : {
  "rollouts" : [
    {
      "rolloutId" : "6246d6a916a70b047e454124",
      "factorPackIds" : [

      ],
      "deploymentId" : 240000010
    },
    {
      "rolloutId" : "645eb1d0417dab722a215927",
      "factorPackIds" : [

      ],
      "deploymentId" : 240000005
    }
  ],
  "experiments" : [

  ]
}
}

Model: MacBookPro18,4, BootROM 13822.81.10, proc 10:8:2:0 processors, 64 GB, SMC
Graphics: Apple M1 Max, Apple M1 Max, Built-In
Display: LU28R55, 6016 x 3384, Main, MirrorOff, Online
Display: PHL 243S5L, 1080 x 1920, MirrorOff, Online
Display: PL2492H, 1920 x 1080 (1080p FHD - Full High Definition), MirrorOff, Online
Memory Module: LPDDR5, Hynix
AirPort: spairport_wireless_card_type_wifi (0x14E4, 0x4387), wl0: Dec  6 2025 00:29:24 version 20.131.5.0.8.7.216 FWID 01-a22d1730
IO80211_driverkit-1540.16 "IO80211_driverkit-1540.16" Jan 27 2026 21:02:00
AirPort:
Bluetooth: Version (null), 0 services, 0 devices, 0 incoming serial ports
Network Service: Wi-Fi, AirPort, en0
Thunderbolt Bus: MacBook Pro, Apple Inc.
Thunderbolt Bus: MacBook Pro, Apple Inc.
Thunderbolt Bus: MacBook Pro, Apple Inc.
