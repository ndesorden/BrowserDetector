﻿using BenchmarkDotNet.Attributes;
using Shyjus.BrowserDetector;
using System;

namespace BrowserDetector.Benchmarks
{
    [MemoryDiagnoser]
    public class DetectorBenchmarks
    {
        readonly string chromeWindows = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.87 Safari/537.36";
        readonly string safariWindows = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/534.57.2 (KHTML, like Gecko) Version/5.1.7 Safari/534.57.2";
        [Benchmark]
        public string Chrome_Windows()
        {
            return Detector.GetBrowser(chromeWindows.AsSpan()).Name;
        }

        [Benchmark]
        public string Safari_Windows()
        {
            return Detector.GetBrowser(safariWindows.AsSpan()).Name;
        }
    }
}
