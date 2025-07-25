﻿using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSSDKDocSamples.CloudWatch
{
    class CloudWatchSamples : ISample
    {
        public static async Task CWGetMetricStatistics()
        {
            var dimension = new Dimension
            {
                Name = "InstanceType",
                Value = "m1.small"
            };
            #region CWGetMetricStatistics
            var client = new AmazonCloudWatchClient();

            var request = new GetMetricStatisticsRequest
            {
                Dimensions = new List<Dimension>() { dimension },
                EndTime = DateTime.Today,
                MetricName = "CPUUtilization",
                Namespace = "AWS/EC2",
                // Get statistics by day.
                Period = (int)TimeSpan.FromDays(1).TotalSeconds,
                // Get statistics for the past month.
                StartTime = DateTime.Today.Subtract(TimeSpan.FromDays(30)),
                Statistics = new List<string>() { "Minimum" },
                Unit = StandardUnit.Percent
            };

            var response = await client.GetMetricStatisticsAsync(request);

            if (response.Datapoints != null)
            {
                foreach (var point in response.Datapoints)
                {
                    Console.WriteLine(point.Timestamp.Value.ToShortDateString() +
                      " " + point.Minimum + "%");
                }
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task CWPutMetricData()
        {
            #region CWPutMetricData
            var client = new AmazonCloudWatchClient();

            var dimension = new Dimension
            {
                Name = "Desktop Machine Metrics",
                Value = "Virtual Desktop Machine Usage"
            };

            var metric1 = new MetricDatum
            {
                Dimensions = new List<Dimension>() { dimension },
                MetricName = "Desktop Machines Online",
                StatisticValues = new StatisticSet(),
                Timestamp = DateTime.Today,
                Unit = StandardUnit.Count,
                Value = 14
            };

            var metric2 = new MetricDatum
            {
                Dimensions = new List<Dimension>() { dimension },
                MetricName = "Desktop Machines Offline",
                StatisticValues = new StatisticSet(),
                Timestamp = DateTime.Today,
                Unit = StandardUnit.Count,
                Value = 7
            };

            var metric3 = new MetricDatum
            {
                Dimensions = new List<Dimension>() { dimension },
                MetricName = "Desktop Machines Online",
                StatisticValues = new StatisticSet(),
                Timestamp = DateTime.Today,
                Unit = StandardUnit.Count,
                Value = 12
            };

            var metric4 = new MetricDatum
            {
                Dimensions = new List<Dimension>() { dimension },
                MetricName = "Desktop Machines Offline",
                StatisticValues = new StatisticSet(),
                Timestamp = DateTime.Today,
                Unit = StandardUnit.Count,
                Value = 9
            };

            var request = new PutMetricDataRequest
            {
                MetricData = new List<MetricDatum>() { metric1, metric2,
          metric3, metric4 },
                Namespace = "Example.com Custom Metrics"
            };

            await client.PutMetricDataAsync(request);
            #endregion
        }

        public static async Task CWListMetrics()
        {
            #region CWListMetrics
            var client = new AmazonCloudWatchClient();

            var filter = new DimensionFilter
            {
                Name = "InstanceType",
                Value = "t1.micro"
            };

            var request = new ListMetricsRequest
            {
                Dimensions = new List<DimensionFilter>() { filter },
                MetricName = "CPUUtilization",
                Namespace = "AWS/EC2"
            };

            var response = new ListMetricsResponse();

            do
            {
                response = await client.ListMetricsAsync(request);

                if (response.Metrics != null)
                {
                    foreach (var metric in response.Metrics)
                    {
                        Console.WriteLine(metric.MetricName +
                          " (" + metric.Namespace + ")");

                        foreach (var dimension in metric.Dimensions)
                        {
                            Console.WriteLine("  " + dimension.Name + ": "
                              + dimension.Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No metrics found.");
                }

                request.NextToken = response.NextToken;

            } while (!string.IsNullOrEmpty(response.NextToken));
            #endregion

            Console.ReadLine();
        }

        public static async Task CWDescribeAlarms()
        {
            #region CWDescribeAlarms
            var client = new AmazonCloudWatchClient();

            var request = new DescribeAlarmsRequest
            {
                AlarmNames = new List<string>()
                    { 
                        "awseb-e-b36EXAMPLE-stack-CloudwatchAlarmLow-1KAKH4EXAMPLE" 
                    },
                MaxRecords = 1,
                StateValue = StateValue.ALARM
            };

            var response = new DescribeAlarmsResponse();

            do
            {
                response = await client.DescribeAlarmsAsync(request);

                if (response.MetricAlarms != null)
                {
                    foreach (var alarm in response.MetricAlarms)
                    {
                        Console.WriteLine(alarm.AlarmName);
                        Console.WriteLine(alarm.AlarmDescription);
                        Console.WriteLine(alarm.MetricName + " " +
                            alarm.ComparisonOperator + " " + alarm.Threshold);
                        Console.WriteLine();
                    }
                }

                request.NextToken = response.NextToken;

            } while (!string.IsNullOrEmpty(response.NextToken));
            #endregion

            Console.ReadLine();
        }

        public static async Task CWDescribeAlarmHistory()
        {
            #region CWDescribeAlarmHistory
            var client = new AmazonCloudWatchClient();

            var request = new DescribeAlarmHistoryRequest
            {
                AlarmName =
                "awseb-e-kkbEXAMPLE-stack-CloudwatchAlarmLow-1WVXD9EXAMPLE",
                EndDate = DateTime.Today,
                HistoryItemType = HistoryItemType.Action,
                MaxRecords = 1,
                StartDate = DateTime.Today.Subtract(TimeSpan.FromDays(30))
            };

            var response = new DescribeAlarmHistoryResponse();

            do
            {
                response = await client.DescribeAlarmHistoryAsync(request);

                if (response.AlarmHistoryItems != null)
                {
                    foreach (var item in response.AlarmHistoryItems)
                    {
                        Console.WriteLine(item.AlarmName);
                        Console.WriteLine(item.HistorySummary);
                        Console.WriteLine();
                    }
                }

                request.NextToken = response.NextToken;

            } while (!string.IsNullOrEmpty(response.NextToken));
            #endregion

            Console.ReadLine();
        }

        public static async Task CWPutMetricAlarm()
        {
            #region CWPutMetricAlarm
            var client = new AmazonCloudWatchClient();

            var dimension = new Dimension
            {
                Name = "Desktop Machine Metrics",
                Value = "Virtual Desktop Machine Usage"
            };

            var request = new PutMetricAlarmRequest
            {
                ActionsEnabled = true,
                AlarmActions = new List<string>()
                    { 
                        "arn:aws:sns:us-east-1:80398EXAMPLE:CodingTestResults" 
                    },
                AlarmDescription = "Too many instances offline",
                AlarmName = "Offline Instances",
                ComparisonOperator = ComparisonOperator.GreaterThanOrEqualToThreshold,
                Dimensions = new List<Dimension>() { dimension },
                EvaluationPeriods = 1,
                MetricName = "Desktop Machines Offline",
                Namespace = "Example.com Custom Metrics",
                Period = (int)TimeSpan.FromMinutes(5).TotalSeconds,
                Statistic = new Statistic("Maximum"),
                Threshold = 5,
                Unit = StandardUnit.Count
            };

            await client.PutMetricAlarmAsync(request);
            #endregion
        }

        public static async Task CWDescribeAlarmsForMetric()
        {
            #region CWDescribeAlarmsForMetric
            var client = new AmazonCloudWatchClient();

            var dimension = new Dimension
            {
                Name = "AutoScalingGroupName",
                Value = "awseb-e-kkbEXAMPLE-stack-AutoScalingGroup-F4TAUEXAMPLE"
            };

            var request = new DescribeAlarmsForMetricRequest
            {
                Dimensions = new List<Dimension>() { dimension },
                MetricName = "NetworkOut",
                Namespace = "AWS/EC2"
            };

            var response = await client.DescribeAlarmsForMetricAsync(request);

            if (response.MetricAlarms != null)
            {
                foreach (var alarm in response.MetricAlarms)
                {
                    Console.WriteLine();
                    Console.WriteLine(alarm.AlarmName);
                    Console.WriteLine(alarm.AlarmDescription);
                    Console.WriteLine(alarm.MetricName + " " +
                      alarm.ComparisonOperator + " " + alarm.Threshold);
                }
            }
            else
            {
                Console.WriteLine("No alarms.");
            }
            #endregion

            Console.ReadLine();
        }

        public static async Task CWDeleteAlarms()
        {
            #region CWDeleteAlarms
            var client = new AmazonCloudWatchClient();

            var request = new DeleteAlarmsRequest
            {
                AlarmNames = new List<string>() { "t1.microCPUUtilization" }
            };

            await client.DeleteAlarmsAsync(request);
            #endregion
        }

        public static async Task CWSetAlarmState()
        {
            #region CWSetAlarmState
            var client = new AmazonCloudWatchClient();

            var request = new SetAlarmStateRequest
            {
                AlarmName = "Offline Instances",
                StateReason = "Too many instances are offline.",
                StateValue = StateValue.ALARM
            };

            await client.SetAlarmStateAsync(request);
            #endregion
        }

        public static async Task CWEnableAlarmActions()
        {
            #region CWEnableAlarmActions
            var client = new AmazonCloudWatchClient();

            var request = new EnableAlarmActionsRequest
            {
                AlarmNames = new List<string>()
                    { 
                        "awseb-e-kkbEXAMPLE-stack-CloudwatchAlarmLow-1WVXD9EXAMPLE" 
                    }
            };

            await client.EnableAlarmActionsAsync(request);
            #endregion
        }

        public static async Task CWDisableAlarmActions()
        {
            #region CWDisableAlarmActions
            var client = new AmazonCloudWatchClient();

            var request = new DisableAlarmActionsRequest
            {
                AlarmNames = new List<string>()
                    { 
                        "awseb-e-kkbEXAMPLE-stack-CloudwatchAlarmLow-1WVXD9EXAMPLE" 
                    }
            };

            await client.DisableAlarmActionsAsync(request);
            #endregion
        }

        #region ISample Members
        public virtual Task Run()
        {
            return Task.CompletedTask;
        }
        #endregion
    }
}
