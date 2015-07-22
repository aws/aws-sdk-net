using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

using Amazon;
using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class CloudWatch : TestBase<AmazonCloudWatchClient>
    {
        const string ALARM_BASENAME = "SDK-TEST-ALARM-";

        [OneTimeTearDown]
        public void Cleanup()
        {
            var describeResult = Client.DescribeAlarmsAsync(new DescribeAlarmsRequest()).Result;
            List<string> toDelete = new List<string>();
            foreach (MetricAlarm alarm in describeResult.MetricAlarms)
            {
                if (alarm.MetricName.StartsWith(ALARM_BASENAME) || alarm.AlarmName.StartsWith("An Alarm Name 2"))
                {
                    toDelete.Add(alarm.AlarmName);
                }
            }
            if (toDelete.Count > 0)
            {
                DeleteAlarmsRequest delete = new DeleteAlarmsRequest() { AlarmNames = toDelete };
                Client.DeleteAlarmsAsync(delete).Wait();
            }
            BaseClean();
        }

        [Test]
        [Category("CloudWatch")]
        public void UseDoubleForData()
        {
            var currentCulture = CultureInfo.DefaultThreadCurrentCulture;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sv-SE");
            try
            {
                var data = new List<MetricDatum> 
                { 
                    new MetricDatum() 
                    {
                        MetricName="SDK-TEST-CloudWatchAppender", 
                        Unit="Seconds", 
                        Timestamp=DateTime.Now,
                        Value=1.1
                    }
                };

                Client.PutMetricDataAsync(new PutMetricDataRequest()
                {
                    Namespace = "SDK-TEST-CloudWatchAppender",
                    MetricData = data
                }).Wait();

                UtilityMethods.Sleep(TimeSpan.FromSeconds(1));
                GetMetricStatisticsResponse gmsRes = Client.GetMetricStatisticsAsync(new GetMetricStatisticsRequest()
                {
                    Namespace = "SDK-TEST-CloudWatchAppender",
                    MetricName = "SDK-TEST-CloudWatchAppender",
                    StartTime = DateTime.Today.AddDays(-2),
                    Period = 60 * 60,
                    Statistics = new List<string> { "Maximum" },
                    EndTime = DateTime.Today.AddDays(2)
                }).Result;

                bool found = false;
                foreach (var dp in gmsRes.Datapoints)
                {
                    if (dp.Maximum == 1.1)
                    {
                        found = true;
                        break;
                    }
                }
                Assert.IsTrue(found, "Did not found the 1.1 value");
            }
            finally
            {
                CultureInfo.DefaultThreadCurrentCulture = currentCulture;
            }
        }

        [Test]
        [Category("CloudWatch")]
        public void CWExceptionTest()
        {
            GetMetricStatisticsRequest getMetricRequest = new GetMetricStatisticsRequest()
            {
                MetricName = "CPUUtilization",
                Namespace = "AWS/EC2",
                StartTime = DateTime.Parse("2008-02-26T19:00:00+00:00"),
                EndTime = DateTime.Parse("2011-02-26T19:00:00+00:00"),
                Statistics = new List<string> { "Average" },
                Unit = "Percent",
                Period = 60
            };
            var exception = AssertExtensions.ExpectExceptionAsync<InvalidParameterCombinationException>(Client.GetMetricStatisticsAsync(getMetricRequest)).Result;
            AssertValidException(exception);
            Assert.AreEqual("InvalidParameterCombination", exception.ErrorCode);
        }

        [Test]
        [Category("CloudWatch")]
        public void BasicCRUD()
        {
            var listResult = Client.ListMetricsAsync(new ListMetricsRequest()).Result;
            Assert.IsNotNull(listResult);
            if (listResult.NextToken != null && listResult.NextToken.Length > 0)
            {
                listResult = Client.ListMetricsAsync(new ListMetricsRequest() { NextToken = listResult.NextToken }).Result;
                Assert.IsTrue(listResult.Metrics.Count > 0);
            }

            GetMetricStatisticsRequest getMetricRequest = new GetMetricStatisticsRequest()
            {
                MetricName = "NetworkIn",
                Namespace = "AWS/EC2",
                StartTime = DateTime.Parse("2008-01-01T19:00:00+00:00"),
                EndTime = DateTime.Parse("2009-12-01T19:00:00+00:00"),
                Statistics = new List<string> { "Average" },
                Unit = "Percent",
                Period = 42000,
            };
            var getMetricResult = Client.GetMetricStatisticsAsync(getMetricRequest).Result;
            Assert.IsNotNull(getMetricResult);
            Assert.IsTrue(getMetricResult.Datapoints.Count >= 0);
            Assert.IsNotNull(getMetricResult.Label);
        }

        [Test]
        [Category("CloudWatch")]
        public void AlarmTest()
        {
            var alarmName = ALARM_BASENAME + DateTime.Now.Ticks;
            var putResponse = Client.PutMetricAlarmAsync(new PutMetricAlarmRequest()
            {
                AlarmName = alarmName,
                Threshold = 100,
                Period = 120,
                EvaluationPeriods = 60,
                Namespace = "MyNamespace",
                Unit = "Percent",
                MetricName = "CPU",
                Statistic = "Average",
                ComparisonOperator = "GreaterThanThreshold",
                AlarmDescription = "This is very important"
            }).Result;
            try
            {
                var describeResponse = Client.DescribeAlarmsAsync(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                }).Result;

                Assert.AreEqual(1, describeResponse.MetricAlarms.Count);
                MetricAlarm alarm = describeResponse.MetricAlarms[0];
                Assert.AreEqual(100, alarm.Threshold);
                Assert.AreEqual(120, alarm.Period);
                Assert.AreEqual(60, alarm.EvaluationPeriods);
                Assert.AreEqual("MyNamespace", alarm.Namespace);
                Assert.AreEqual(StandardUnit.Percent, alarm.Unit);
                Assert.AreEqual(Statistic.Average, alarm.Statistic);
                Assert.AreEqual(ComparisonOperator.GreaterThanThreshold, alarm.ComparisonOperator);
                Assert.AreEqual("This is very important", alarm.AlarmDescription);



                var setResponse = Client.SetAlarmStateAsync(new SetAlarmStateRequest()
                {
                    AlarmName = alarmName,
                    StateValue = "ALARM",
                    StateReason = "Just Testing"
                }).Result;

                describeResponse = Client.DescribeAlarmsAsync(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                }).Result;
                alarm = describeResponse.MetricAlarms[0];
                Assert.IsTrue("ALARM".Equals(alarm.StateValue) || "INSUFFICIENT_DATA".Equals(alarm.StateValue));
                if ("ALARM".Equals(alarm.StateValue))
                {
                    Assert.AreEqual("Just Testing", alarm.StateReason);
                }

                Client.EnableAlarmActionsAsync(new EnableAlarmActionsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                }).Wait();

                describeResponse = Client.DescribeAlarmsAsync(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                }).Result;
                alarm = describeResponse.MetricAlarms[0];
                Assert.IsTrue(alarm.ActionsEnabled);

                Client.DisableAlarmActionsAsync(new DisableAlarmActionsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                }).Wait();

                describeResponse = Client.DescribeAlarmsAsync(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                }).Result;
                alarm = describeResponse.MetricAlarms[0];
                Assert.IsFalse(alarm.ActionsEnabled);

                var describeMetricResponse = Client.DescribeAlarmsForMetricAsync(new DescribeAlarmsForMetricRequest()
                {
                    MetricName = "CPU",
                    Namespace = "MyNamespace"
                }).Result;

                alarm = null;
                foreach (var a in describeMetricResponse.MetricAlarms)
                {
                    if (a.AlarmName.Equals(alarmName))
                    {
                        alarm = a;
                        break;
                    }
                }

                Assert.IsNotNull(alarm);

                var describeHistory = Client.DescribeAlarmHistoryAsync(new DescribeAlarmHistoryRequest()
                {
                    AlarmName = alarmName
                }).Result;

                Assert.IsTrue(describeHistory.AlarmHistoryItems.Count > 0);
            }
            finally
            {
                Client.DeleteAlarmsAsync(new DeleteAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                }).Wait();
            }
        }

        const int ONE_WEEK_IN_MILLISECONDS = 1000 * 60 * 60 * 24 * 7;
        const int ONE_HOUR_IN_MILLISECONDS = 1000 * 60 * 60;

        /**
         * Tests that we can call the ListMetrics operation and correctly understand
         * the response.
         */
        [Test]
        [Category("CloudWatch")]
        public void TestListMetrics()
        {
            var result = Client.ListMetricsAsync(new ListMetricsRequest()).Result;

            bool seenDimensions = false;
            Assert.IsTrue(result.Metrics.Count > 0);
            foreach (Metric metric in result.Metrics)
            {
                AssertNotEmpty(metric.MetricName);
                AssertNotEmpty(metric.Namespace);

                foreach (Dimension dimension in metric.Dimensions)
                {
                    seenDimensions = true;
                    AssertNotEmpty(dimension.Name);
                    AssertNotEmpty(dimension.Value);
                }
            }
            Assert.IsTrue(seenDimensions);

            if (!string.IsNullOrEmpty(result.NextToken))
            {
                result = Client.ListMetricsAsync(new ListMetricsRequest() { NextToken = result.NextToken }).Result;
                Assert.IsTrue(result.Metrics.Count > 0);
            }
        }




        /**
         * Tests that we can call the GetMetricStatistics operation and correctly
         * understand the response.
         */
        [Test]
        [Category("CloudWatch")]
        public void TestGetMetricStatistics()
        {
            string measureName = "CPUUtilization";

            GetMetricStatisticsRequest request = new GetMetricStatisticsRequest()
            {
                StartTime = DateTime.Now.AddMilliseconds(-ONE_WEEK_IN_MILLISECONDS),
                Namespace = "AWS/EC2",
                Period = 60 * 60,
                Dimensions = new List<Dimension>
                {
                    new Dimension{ Name="InstanceType",Value="m1.small"}
                },
                MetricName = measureName,
                Statistics = new List<string> { "Average", "Maximum", "Minimum", "Sum" },
                EndTime = DateTime.Now
            };
            var result = Client.GetMetricStatisticsAsync(request).Result;

            AssertNotEmpty(result.Label);
            Assert.AreEqual(measureName, result.Label);
            Assert.IsNotNull(result.Datapoints);
        }

        /**
         * Tests setting the state for an alarm and reading its history.
         */
        [Test]
        [Category("CloudWatch")]
        public void TestSetAlarmStateAndHistory()
        {
            String metricName = this.GetType().Name + DateTime.Now.Ticks;

            PutMetricAlarmRequest[] rqs = CreateTwoNewAlarms(metricName);

            PutMetricAlarmRequest rq1 = rqs[0];
            PutMetricAlarmRequest rq2 = rqs[1];

            /*
             * Set the state
             */
            SetAlarmStateRequest setAlarmStateRequest = new SetAlarmStateRequest()
            {
                AlarmName = rq1.AlarmName,
                StateValue = "ALARM",
                StateReason = "manual"
            };
            Client.SetAlarmStateAsync(setAlarmStateRequest).Wait();
            setAlarmStateRequest = new SetAlarmStateRequest()
            {
                AlarmName = rq2.AlarmName,
                StateValue = "ALARM",
                StateReason = "manual"
            };

            Client.SetAlarmStateAsync(setAlarmStateRequest).Wait();

            var describeResult = Client
                    .DescribeAlarmsForMetricAsync(
                        new DescribeAlarmsForMetricRequest()
                        {
                            Dimensions = rq1.Dimensions,
                            MetricName = metricName,
                            Namespace = rq1.Namespace
                        }).Result;

            Assert.AreEqual(2, describeResult.MetricAlarms.Count);

            foreach (MetricAlarm alarm in describeResult.MetricAlarms)
            {
                Assert.IsTrue(rq1.AlarmName.Equals(alarm.AlarmName)
                        || rq2.AlarmName.Equals(alarm.AlarmName));

                Assert.IsTrue("ALARM".Equals(alarm.StateValue) || "INSUFFICIENT_DATA".Equals(alarm.StateValue));
                if ("ALARM".Equals(alarm.StateValue))
                {
                    Assert.AreEqual(setAlarmStateRequest.StateReason, alarm.StateReason);
                }
            }

            /*
             * Get the history
             */
            DescribeAlarmHistoryRequest alarmHistoryRequest = new DescribeAlarmHistoryRequest()
            {
                AlarmName = rq1.AlarmName,
                HistoryItemType = "StateUpdate"
            };

            var historyResult = Client.DescribeAlarmHistoryAsync(alarmHistoryRequest).Result;
            Assert.IsTrue(historyResult.AlarmHistoryItems.Count > 0);
        }

        /**
         * Tests disabling and enabling alarms
         */
        [Test]
        [Category("CloudWatch")]
        public void TestDisableEnableAlarms()
        {
            String metricName = this.GetType().Name + DateTime.Now.Ticks;

            PutMetricAlarmRequest[] rqs = CreateTwoNewAlarms(metricName);

            PutMetricAlarmRequest rq1 = rqs[0];
            PutMetricAlarmRequest rq2 = rqs[1];

            /*
             * Disable
             */
            DisableAlarmActionsRequest disable = new DisableAlarmActionsRequest()
            {
                AlarmNames = new List<string> { rq1.AlarmName, rq2.AlarmName }
            };
            Client.DisableAlarmActionsAsync(disable).Wait();

            var describeResult = Client.DescribeAlarmsForMetricAsync(new DescribeAlarmsForMetricRequest()
            {
                Dimensions = rq1.Dimensions,
                MetricName = metricName,
                Namespace = rq1.Namespace
            }).Result;

            Assert.AreEqual(2, describeResult.MetricAlarms.Count);
            foreach (MetricAlarm alarm in describeResult.MetricAlarms)
            {
                Assert.IsTrue(rq1.AlarmName.Equals(alarm.AlarmName) || rq2.AlarmName.Equals(alarm.AlarmName));
                Assert.IsFalse(alarm.ActionsEnabled);
            }

            /*
             * Enable
             */
            EnableAlarmActionsRequest enable = new EnableAlarmActionsRequest()
            {
                AlarmNames = new List<string> { rq1.AlarmName, rq2.AlarmName }
            };
            Client.EnableAlarmActionsAsync(enable).Wait();

            describeResult = Client.DescribeAlarmsForMetricAsync(new DescribeAlarmsForMetricRequest()
            {
                Dimensions = rq1.Dimensions,
                MetricName = metricName,
                Namespace = rq1.Namespace
            }).Result;

            Assert.AreEqual(2, describeResult.MetricAlarms.Count);
            foreach (MetricAlarm alarm in describeResult.MetricAlarms)
            {
                Assert.IsTrue(rq1.AlarmName.Equals(alarm.AlarmName)
                        || rq2.AlarmName.Equals(alarm.AlarmName));
                Assert.IsTrue(alarm.ActionsEnabled);
            }
        }

        /**
         * Tests creating alarms and describing them
         */
        [Test]
        [Category("CloudWatch")]
        public void TestDescribeAlarms()
        {
            string metricName = this.GetType().Name + DateTime.Now.Ticks;

            PutMetricAlarmRequest[] rqs = CreateTwoNewAlarms(metricName);

            PutMetricAlarmRequest rq1 = rqs[0];
            PutMetricAlarmRequest rq2 = rqs[1];

            /*
             * Describe them 
             */
            var describeResult = Client.DescribeAlarmsForMetricAsync(new DescribeAlarmsForMetricRequest()
            {
                Dimensions = rq1.Dimensions,
                MetricName = metricName,
                Namespace = rq1.Namespace
            }).Result;

            Assert.AreEqual(2, describeResult.MetricAlarms.Count);
            foreach (MetricAlarm alarm in describeResult.MetricAlarms)
            {
                Assert.IsTrue(rq1.AlarmName.Equals(alarm.AlarmName) || rq2.AlarmName.Equals(alarm.AlarmName));
                Assert.IsTrue(alarm.ActionsEnabled);
            }
        }

        [Test]
        [Category("CloudWatch")]
        public void TestPutMetricData()
        {
            string metricName = "DotNetSDKTestMetric";
            string nameSpace = "AWS-EC2";

            List<MetricDatum> data = new List<MetricDatum>();

            DateTime ts = DateTime.Now;

            data.Add(new MetricDatum()
            {
                MetricName = metricName,
                Timestamp = ts.AddHours(-1),
                Unit = "None",
                Value = 23.0
            });

            data.Add(new MetricDatum()
            {
                MetricName = metricName,
                Timestamp = ts,
                Unit = "None",
                Value = 21.0
            });

            data.Add(new MetricDatum()
            {
                MetricName = metricName,
                Timestamp = DateTime.Now.AddHours(1),
                Unit = "None",
                Value = 22.0
            });

            Client.PutMetricDataAsync(new PutMetricDataRequest()
            {
                Namespace = nameSpace,
                MetricData = data
            }).Wait();

            UtilityMethods.Sleep(TimeSpan.FromSeconds(1));
            GetMetricStatisticsResponse gmsRes = Client.GetMetricStatisticsAsync(new GetMetricStatisticsRequest()
            {
                Namespace = nameSpace,
                MetricName = metricName,
                StartTime = ts.AddDays(-1),
                Period = 60 * 60,
                Statistics = new List<string> { "Minimum", "Maximum" },
                EndTime = ts.AddDays(1)
            }).Result;

            Assert.IsTrue(gmsRes.Datapoints.Count > 0);
        }

        /**
         * Creates two alarms on the metric name given and returns the two requests
         * as an array.
         */
        private PutMetricAlarmRequest[] CreateTwoNewAlarms(String metricName)
        {
            PutMetricAlarmRequest[] rqs = new PutMetricAlarmRequest[2];

            /*
             * Put two metric alarms
             */
            rqs[0] = new PutMetricAlarmRequest()
            {
                ActionsEnabled = true,
                AlarmDescription = "Some alarm description",
                AlarmName = ALARM_BASENAME + metricName,
                ComparisonOperator = "GreaterThanThreshold",
                Dimensions = new List<Dimension>
                    {
                        new Dimension{Name="InstanceType",Value="m1.small"}
                    },
                EvaluationPeriods = 1,
                MetricName = metricName,
                Namespace = "AWS/EC2",
                Period = 60,
                Statistic = "Average",
                Threshold = 1.0,
                Unit = "Count"
            };

            Client.PutMetricAlarmAsync(rqs[0]).Wait();

            rqs[1] = new PutMetricAlarmRequest()
            {
                ActionsEnabled = true,
                AlarmDescription = "Some alarm description 2",
                AlarmName = "An Alarm Name 2" + metricName,
                ComparisonOperator = "GreaterThanThreshold",
                Dimensions = new List<Dimension>
                    {
                        new Dimension{Name="InstanceType",Value="m1.small"}
                    },
                EvaluationPeriods = 1,
                MetricName = metricName,
                Namespace = "AWS/EC2",
                Period = 60,
                Statistic = "Average",
                Threshold = 2.0,
                Unit = "Count"
            };
            Client.PutMetricAlarmAsync(rqs[1]).Wait();
            return rqs;
        }

        void AssertNotEmpty(String s)
        {
            Assert.IsNotNull(s);
            Assert.IsTrue(s.Length > 0);
        }
        private void AssertValidException(AmazonCloudWatchException e)
        {
            Assert.IsNotNull(e);
            Assert.IsNotNull(e.ErrorCode);
            Assert.IsNotNull(e.ErrorType);
            Assert.IsNotNull(e.Message);
            Assert.IsNotNull(e.RequestId);
            Assert.IsNotNull(e.StatusCode);
            Assert.IsTrue(e.ErrorCode.Length > 0);
            Assert.IsTrue(e.Message.Length > 0);
            Assert.IsTrue(e.RequestId.Length > 0);
        }
    }
}
