/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.CloudWatch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   MetricAlarm Unmarshaller
     /// </summary>
    internal class MetricAlarmUnmarshaller : IUnmarshaller<MetricAlarm, XmlUnmarshallerContext>, IUnmarshaller<MetricAlarm, JsonUnmarshallerContext> 
    {
        public MetricAlarm Unmarshall(XmlUnmarshallerContext context) 
        {
            MetricAlarm metricAlarm = new MetricAlarm();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("AlarmName", targetDepth))
                    {
                        metricAlarm.AlarmName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AlarmArn", targetDepth))
                    {
                        metricAlarm.AlarmArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AlarmDescription", targetDepth))
                    {
                        metricAlarm.AlarmDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AlarmConfigurationUpdatedTimestamp", targetDepth))
                    {
                        metricAlarm.AlarmConfigurationUpdatedTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ActionsEnabled", targetDepth))
                    {
                        metricAlarm.ActionsEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OKActions/member", targetDepth))
                    {
                        metricAlarm.OKActions.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("AlarmActions/member", targetDepth))
                    {
                        metricAlarm.AlarmActions.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("InsufficientDataActions/member", targetDepth))
                    {
                        metricAlarm.InsufficientDataActions.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("StateValue", targetDepth))
                    {
                        metricAlarm.StateValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StateReason", targetDepth))
                    {
                        metricAlarm.StateReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StateReasonData", targetDepth))
                    {
                        metricAlarm.StateReasonData = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StateUpdatedTimestamp", targetDepth))
                    {
                        metricAlarm.StateUpdatedTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MetricName", targetDepth))
                    {
                        metricAlarm.MetricName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Namespace", targetDepth))
                    {
                        metricAlarm.Namespace = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Statistic", targetDepth))
                    {
                        metricAlarm.Statistic = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Dimensions/member", targetDepth))
                    {
                        metricAlarm.Dimensions.Add(DimensionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Period", targetDepth))
                    {
                        metricAlarm.Period = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Unit", targetDepth))
                    {
                        metricAlarm.Unit = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EvaluationPeriods", targetDepth))
                    {
                        metricAlarm.EvaluationPeriods = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Threshold", targetDepth))
                    {
                        metricAlarm.Threshold = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ComparisonOperator", targetDepth))
                    {
                        metricAlarm.ComparisonOperator = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return metricAlarm;
                }
            }
                        


            return metricAlarm;
        }

        public MetricAlarm Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static MetricAlarmUnmarshaller instance;

        public static MetricAlarmUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new MetricAlarmUnmarshaller();

            return instance;
        }
    }
}
    
