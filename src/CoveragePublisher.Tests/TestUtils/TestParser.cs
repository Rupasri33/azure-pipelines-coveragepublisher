﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Pipelines.CoveragePublisher.Model;
using Microsoft.Azure.Pipelines.CoveragePublisher.Parsers;

namespace CoveragePublisher.Tests
{

    public class TestParser: Parser
    {
        public TestParser(PublisherConfiguration config, ITelemetryDataCollector telemetryDataCollector) : base(config, telemetryDataCollector) { }
        
        protected override void GenerateHTMLReport(ICoverageParserTool tool)
        {
            GenerateReport(tool);
        }

        public virtual void GenerateReport(ICoverageParserTool tool)
        {
            base.GenerateHTMLReport(tool);
        }
    }
}