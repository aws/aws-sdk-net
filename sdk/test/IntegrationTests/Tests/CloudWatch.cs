using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudWatch : TestBase<AmazonCloudWatchClient>
    {
        const string ALARM_BASENAME = "SDK-TEST-ALARM-";

        [ClassCleanup]
        public static void Cleanup()
        {
            var describeResult = Client.DescribeAlarms(new DescribeAlarmsRequest());
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
                Client.DeleteAlarms(delete);
            }
            BaseClean();
        }

        [TestMethod]
        [TestCategory("CloudWatch")]
        public void UseDoubleForData()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE", false);
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

                Client.PutMetricData(new PutMetricDataRequest()
                {
                    Namespace = "SDK-TEST-CloudWatchAppender",
                    MetricData = data
                });

                Thread.Sleep(1000);
                GetMetricStatisticsResponse gmsRes = Client.GetMetricStatistics(new GetMetricStatisticsRequest()
                {
                    Namespace = "SDK-TEST-CloudWatchAppender",
                    MetricName = "SDK-TEST-CloudWatchAppender",
                    StartTime = DateTime.Today.AddDays(-2),
                    Period = 60 * 60,
                    Statistics = new List<string> { "Maximum" },
                    EndTime = DateTime.Today.AddDays(2)
                });

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
                Thread.CurrentThread.CurrentCulture = currentCulture;
            }
        }

        [TestMethod]
        [TestCategory("CloudWatch")]
        [ExpectedException(typeof(InvalidParameterCombinationException))]
        public void CWExceptionTest()
        {
            try
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
                var getMetricResult = Client.GetMetricStatistics(getMetricRequest);
            }
            catch (AmazonCloudWatchException e)
            {
                AssertValidException(e);
                Assert.AreEqual<string>("InvalidParameterCombination", e.ErrorCode);
                throw e;
            }
        }

        [TestMethod]
        [TestCategory("CloudWatch")]
        public void BasicCRUD()
        {
            var listResult = Client.ListMetrics(new ListMetricsRequest());
            Assert.IsNotNull(listResult);
            if (listResult.NextToken != null && listResult.NextToken.Length > 0)
            {
                listResult = Client.ListMetrics(new ListMetricsRequest() { NextToken = listResult.NextToken });
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
            var getMetricResult = Client.GetMetricStatistics(getMetricRequest);
            Assert.IsNotNull(getMetricResult);
            Assert.IsTrue(getMetricResult.Datapoints.Count >= 0);
            Assert.IsNotNull(getMetricResult.Label);
        }

        [TestMethod]
        [TestCategory("CloudWatch")]
        public void AlarmTest()
        {
            var alarmName = ALARM_BASENAME + DateTime.Now.Ticks;
            var putResponse = Client.PutMetricAlarm(new PutMetricAlarmRequest()
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
            });
            try
            {
                var describeResponse = Client.DescribeAlarms(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });

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



                var setResponse = Client.SetAlarmState(new SetAlarmStateRequest()
                {
                    AlarmName = alarmName,
                    StateValue = "ALARM",
                    StateReason = "Just Testing"
                });

                describeResponse = Client.DescribeAlarms(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });
                alarm = describeResponse.MetricAlarms[0];
                Assert.IsTrue("ALARM".Equals(alarm.StateValue) || "INSUFFICIENT_DATA".Equals(alarm.StateValue));
                if ("ALARM".Equals(alarm.StateValue))
                {
                    Assert.AreEqual("Just Testing", alarm.StateReason);
                }

                Client.EnableAlarmActions(new EnableAlarmActionsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });

                describeResponse = Client.DescribeAlarms(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });
                alarm = describeResponse.MetricAlarms[0];
                Assert.IsTrue(alarm.ActionsEnabled);

                Client.DisableAlarmActions(new DisableAlarmActionsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });

                describeResponse = Client.DescribeAlarms(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });
                alarm = describeResponse.MetricAlarms[0];
                Assert.IsFalse(alarm.ActionsEnabled);

                var describeMetricResponse = Client.DescribeAlarmsForMetric(new DescribeAlarmsForMetricRequest()
                {
                    MetricName = "CPU",
                    Namespace = "MyNamespace"
                });

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

                var describeHistory = Client.DescribeAlarmHistory(new DescribeAlarmHistoryRequest()
                {
                    AlarmName = alarmName
                });

                Assert.IsTrue(describeHistory.AlarmHistoryItems.Count > 0);
            }
            finally
            {
                Client.DeleteAlarms(new DeleteAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });
            }
        }

        const int ONE_WEEK_IN_MILLISECONDS = 1000 * 60 * 60 * 24 * 7;
        const int ONE_HOUR_IN_MILLISECONDS = 1000 * 60 * 60;

        /**
         * Tests that we can call the ListMetrics operation and correctly understand
         * the response.
         */
        [TestMethod]
        [TestCategory("CloudWatch")]
        public void TestListMetrics()
        {
            var result = Client.ListMetrics(new ListMetricsRequest());

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
                result = Client.ListMetrics(new ListMetricsRequest() { NextToken = result.NextToken });
                Assert.IsTrue(result.Metrics.Count > 0);
            }
        }




        /**
         * Tests that we can call the GetMetricStatistics operation and correctly
         * understand the response.
         */
        [TestMethod]
        [TestCategory("CloudWatch")]
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
            var result = Client.GetMetricStatistics(request);

            AssertNotEmpty(result.Label);
            Assert.AreEqual(measureName, result.Label);
            Assert.IsNotNull(result.Datapoints);
        }

        /**
         * Tests setting the state for an alarm and reading its history.
         */
        [TestMethod]
        [TestCategory("CloudWatch")]
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
            Client.SetAlarmState(setAlarmStateRequest);
            setAlarmStateRequest = new SetAlarmStateRequest()
            {
                AlarmName = rq2.AlarmName,
                StateValue = "ALARM",
                StateReason = "manual"
            };

            Client.SetAlarmState(setAlarmStateRequest);

            var describeResult = Client
                    .DescribeAlarmsForMetric(
                        new DescribeAlarmsForMetricRequest()
                        {
                            Dimensions = rq1.Dimensions,
                            MetricName = metricName,
                            Namespace = rq1.Namespace
                        });

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

            var historyResult = Client.DescribeAlarmHistory(alarmHistoryRequest);
            Assert.IsTrue(historyResult.AlarmHistoryItems.Count > 0);
        }

        /**
         * Tests disabling and enabling alarms
         */
        [TestMethod]
        [TestCategory("CloudWatch")]
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
            Client.DisableAlarmActions(disable);

            var describeResult = Client.DescribeAlarmsForMetric(new DescribeAlarmsForMetricRequest()
            {
                Dimensions = rq1.Dimensions,
                MetricName = metricName,
                Namespace = rq1.Namespace
            });

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
            Client.EnableAlarmActions(enable);

            describeResult = Client.DescribeAlarmsForMetric(new DescribeAlarmsForMetricRequest()
            {
                Dimensions = rq1.Dimensions,
                MetricName = metricName,
                Namespace = rq1.Namespace
            });

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
        [TestMethod]
        [TestCategory("CloudWatch")]
        public void TestDescribeAlarms()
        {
            string metricName = this.GetType().Name + DateTime.Now.Ticks;

            PutMetricAlarmRequest[] rqs = CreateTwoNewAlarms(metricName);

            PutMetricAlarmRequest rq1 = rqs[0];
            PutMetricAlarmRequest rq2 = rqs[1];

            /*
             * Describe them 
             */
            var describeResult = Client.DescribeAlarmsForMetric(new DescribeAlarmsForMetricRequest()
            {
                Dimensions = rq1.Dimensions,
                MetricName = metricName,
                Namespace = rq1.Namespace
            });

            Assert.AreEqual(2, describeResult.MetricAlarms.Count);
            foreach (MetricAlarm alarm in describeResult.MetricAlarms)
            {
                Assert.IsTrue(rq1.AlarmName.Equals(alarm.AlarmName) || rq2.AlarmName.Equals(alarm.AlarmName));
                Assert.IsTrue(alarm.ActionsEnabled);
            }
        }

        [TestMethod]
        [TestCategory("CloudWatch")]
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

            Client.PutMetricData(new PutMetricDataRequest()
            {
                Namespace = nameSpace,
                MetricData = data
            });

            Thread.Sleep(1 * 1000);
            GetMetricStatisticsResponse gmsRes = Client.GetMetricStatistics(new GetMetricStatisticsRequest()
            {
                Namespace = nameSpace,
                MetricName = metricName,
                StartTime = ts.AddDays(-1),
                Period = 60 * 60,
                Statistics = new List<string> { "Minimum", "Maximum" },
                EndTime = ts.AddDays(1)
            });

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

            Client.PutMetricAlarm(rqs[0]);

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
            Client.PutMetricAlarm(rqs[1]);
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
