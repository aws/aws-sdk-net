using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using System.Web.Profile;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime;
using System.Net;

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
        public void PutMetricDataWithNonStreamingPayload()
        {
            var random = new Random();

            var request = new PutMetricDataRequest()
            {
                Namespace = "compression-test",
                MetricData = new List<MetricDatum>()
                {
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow, Unit = StandardUnit.Count, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(2), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(4), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(6), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(8), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(10), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                }
            };


            var config = Client.Config as ClientConfig;
            config.RequestMinCompressionSizeBytes = 0;

            var response = Client.PutMetricData(request);

            Assert.IsFalse(Client.Config.DisableRequestCompression);
            Assert.AreEqual(response.HttpStatusCode, HttpStatusCode.OK);
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
            Assert.IsNotNull(getMetricResult.Label);
        }

        [TestMethod]
        [TestCategory("CloudWatch")]
        public void AlarmTest()
        {
            var alarmName = ALARM_BASENAME + DateTime.UtcNow.Ticks;
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
                Assert.IsTrue(alarm.ActionsEnabled.Value);

                Client.DisableAlarmActions(new DisableAlarmActionsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });

                describeResponse = Client.DescribeAlarms(new DescribeAlarmsRequest()
                {
                    AlarmNames = new List<string> { alarmName }
                });
                alarm = describeResponse.MetricAlarms[0];
                Assert.IsFalse(alarm.ActionsEnabled.Value);

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
            foreach (Amazon.CloudWatch.Model.Metric metric in result.Metrics)
            {
                AssertNotEmpty(metric.MetricName);
                AssertNotEmpty(metric.Namespace);

                if (metric.Dimensions != null)
                {
                    foreach (Dimension dimension in metric.Dimensions)
                    {
                        seenDimensions = true;
                        AssertNotEmpty(dimension.Name);
                        AssertNotEmpty(dimension.Value);
                    }
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
                StartTime = DateTime.UtcNow.AddMilliseconds(-ONE_WEEK_IN_MILLISECONDS),
                Namespace = "AWS/EC2",
                Period = 60 * 60,
                Dimensions = new List<Dimension>
                {
                    new Dimension{ Name="InstanceType",Value="m1.small"}
                },
                MetricName = measureName,
                Statistics = new List<string> { "Average", "Maximum", "Minimum", "Sum" },
                EndTime = DateTime.UtcNow
            };
            var result = Client.GetMetricStatistics(request);

            AssertNotEmpty(result.Label);
            Assert.AreEqual(measureName, result.Label);
        }

        /**
         * Tests setting the state for an alarm and reading its history.
         */
        [TestMethod]
        [TestCategory("CloudWatch")]
        public void TestSetAlarmStateAndHistory()
        {
            String metricName = this.GetType().Name + DateTime.UtcNow.Ticks;

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
            String metricName = this.GetType().Name + DateTime.UtcNow.Ticks;

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
                Assert.IsFalse(alarm.ActionsEnabled.Value);
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
                Assert.IsTrue(alarm.ActionsEnabled.Value);
            }
        }

        /**
         * Tests creating alarms and describing them
         */
        [TestMethod]
        [TestCategory("CloudWatch")]
        public void TestDescribeAlarms()
        {
            string metricName = this.GetType().Name + DateTime.UtcNow.Ticks;

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
                Assert.IsTrue(alarm.ActionsEnabled.Value);
            }
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
