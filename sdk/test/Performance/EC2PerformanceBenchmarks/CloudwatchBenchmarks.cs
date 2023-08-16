/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using Amazon.S3.Model;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.Benchmarks
{
    [MemoryDiagnoser]

    public class CloudwatchBenchmarks
    {
        private IAmazonCloudWatch _cloudWatchClient;
        private List<MetricDatum> _metrics;
        private PutMetricDataRequest _putMetricDataRequest;
        private const string Namespace = "CloudwatchBenchmarks";

        [GlobalSetup(Target = nameof(CloudWatchPutMetricDataAsync))]
        public async Task SetupForPutMetricData()
        {
            _cloudWatchClient = new AmazonCloudWatchClient();
            _metrics = new List<MetricDatum>();
            List<MetricDatum> customData = new List<MetricDatum>();
            Random rnd = new Random();

            // Add 10 random values up to 100
            var utcNowMinus15 = DateTime.UtcNow.AddMinutes(-15);
            var customMetricName = "testMetric";
            for (int i = 0; i < 20; i++)
            {
                var metricValue = rnd.Next(0, 100);
                customData.Add(
                    new MetricDatum
                    {
                        MetricName = customMetricName,
                        Value = metricValue,
                        TimestampUtc = utcNowMinus15.AddMinutes(i),
                        Dimensions = new List<Dimension>
                        {
                            new Dimension {Name = "dimension1", Value = "value1"},
                            new Dimension {Name= "dimension2", Value = "value2"},
                            new Dimension {Name= "dimension3", Value = "value3"},
                            new Dimension {Name= "dimension4", Value = "value4"},
                            new Dimension {Name= "dimension5", Value = "value5"},
                            new Dimension {Name= "dimension6", Value = "value6"},
                            new Dimension {Name= "dimension7", Value = "value7"},
                            new Dimension {Name= "dimension8", Value = "value8"},
                            new Dimension {Name= "dimension9", Value = "value9"},
                            new Dimension {Name= "dimension10", Value = "value10"},
                        }
                    }
                );
            }
            _putMetricDataRequest = new PutMetricDataRequest
            {
                MetricData = customData,
                Namespace = Namespace
            };
        }

        /// <summary>
        /// Test CloudWatch Put Metric Data Async with 20 metricdatums with 10 dimensions
        /// </summary>
        [Benchmark]
        public async Task CloudWatchPutMetricDataAsync()
        {
            await _cloudWatchClient.PutMetricDataAsync(_putMetricDataRequest).ConfigureAwait(false);
        }
    }
}
