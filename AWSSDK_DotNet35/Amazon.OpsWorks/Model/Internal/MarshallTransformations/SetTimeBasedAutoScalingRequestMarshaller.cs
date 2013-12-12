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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Set Time Based Auto Scaling Request Marshaller
    /// </summary>       
    internal class SetTimeBasedAutoScalingRequestMarshaller : IMarshaller<IRequest, SetTimeBasedAutoScalingRequest> 
    {
        

        public IRequest Marshall(SetTimeBasedAutoScalingRequest setTimeBasedAutoScalingRequest) 
        {

            IRequest request = new DefaultRequest(setTimeBasedAutoScalingRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.SetTimeBasedAutoScaling";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (setTimeBasedAutoScalingRequest != null && setTimeBasedAutoScalingRequest.IsSetInstanceId()) 
                {
                    writer.WritePropertyName("InstanceId");
                    writer.Write(setTimeBasedAutoScalingRequest.InstanceId);
                }

                if (setTimeBasedAutoScalingRequest != null) 
                {
                    WeeklyAutoScalingSchedule autoScalingSchedule = setTimeBasedAutoScalingRequest.AutoScalingSchedule;
                    if (autoScalingSchedule != null)
                    {
                        writer.WritePropertyName("AutoScalingSchedule");
                        writer.WriteObjectStart();
                        if (autoScalingSchedule != null) 
                        {
                            if (autoScalingSchedule.Monday != null && autoScalingSchedule.Monday.Count > 0)
                            {
                                writer.WritePropertyName("Monday");
                                writer.WriteObjectStart();
                                foreach (string autoScalingScheduleMondayKey in autoScalingSchedule.Monday.Keys)
                                {
                                    string mondayListValue;
                                    bool mondayListValueHasValue = autoScalingSchedule.Monday.TryGetValue(autoScalingScheduleMondayKey, out mondayListValue);
                                    writer.WritePropertyName(autoScalingScheduleMondayKey);

                                writer.Write(mondayListValue);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        if (autoScalingSchedule != null) 
                        {
                            if (autoScalingSchedule.Tuesday != null && autoScalingSchedule.Tuesday.Count > 0)
                            {
                                writer.WritePropertyName("Tuesday");
                                writer.WriteObjectStart();
                                foreach (string autoScalingScheduleTuesdayKey in autoScalingSchedule.Tuesday.Keys)
                                {
                                    string tuesdayListValue;
                                    bool tuesdayListValueHasValue = autoScalingSchedule.Tuesday.TryGetValue(autoScalingScheduleTuesdayKey, out tuesdayListValue);
                                    writer.WritePropertyName(autoScalingScheduleTuesdayKey);

                                writer.Write(tuesdayListValue);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        if (autoScalingSchedule != null) 
                        {
                            if (autoScalingSchedule.Wednesday != null && autoScalingSchedule.Wednesday.Count > 0)
                            {
                                writer.WritePropertyName("Wednesday");
                                writer.WriteObjectStart();
                                foreach (string autoScalingScheduleWednesdayKey in autoScalingSchedule.Wednesday.Keys)
                                {
                                    string wednesdayListValue;
                                    bool wednesdayListValueHasValue = autoScalingSchedule.Wednesday.TryGetValue(autoScalingScheduleWednesdayKey, out wednesdayListValue);
                                    writer.WritePropertyName(autoScalingScheduleWednesdayKey);

                                writer.Write(wednesdayListValue);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        if (autoScalingSchedule != null) 
                        {
                            if (autoScalingSchedule.Thursday != null && autoScalingSchedule.Thursday.Count > 0)
                            {
                                writer.WritePropertyName("Thursday");
                                writer.WriteObjectStart();
                                foreach (string autoScalingScheduleThursdayKey in autoScalingSchedule.Thursday.Keys)
                                {
                                    string thursdayListValue;
                                    bool thursdayListValueHasValue = autoScalingSchedule.Thursday.TryGetValue(autoScalingScheduleThursdayKey, out thursdayListValue);
                                    writer.WritePropertyName(autoScalingScheduleThursdayKey);

                                writer.Write(thursdayListValue);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        if (autoScalingSchedule != null) 
                        {
                            if (autoScalingSchedule.Friday != null && autoScalingSchedule.Friday.Count > 0)
                            {
                                writer.WritePropertyName("Friday");
                                writer.WriteObjectStart();
                                foreach (string autoScalingScheduleFridayKey in autoScalingSchedule.Friday.Keys)
                                {
                                    string fridayListValue;
                                    bool fridayListValueHasValue = autoScalingSchedule.Friday.TryGetValue(autoScalingScheduleFridayKey, out fridayListValue);
                                    writer.WritePropertyName(autoScalingScheduleFridayKey);

                                writer.Write(fridayListValue);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        if (autoScalingSchedule != null) 
                        {
                            if (autoScalingSchedule.Saturday != null && autoScalingSchedule.Saturday.Count > 0)
                            {
                                writer.WritePropertyName("Saturday");
                                writer.WriteObjectStart();
                                foreach (string autoScalingScheduleSaturdayKey in autoScalingSchedule.Saturday.Keys)
                                {
                                    string saturdayListValue;
                                    bool saturdayListValueHasValue = autoScalingSchedule.Saturday.TryGetValue(autoScalingScheduleSaturdayKey, out saturdayListValue);
                                    writer.WritePropertyName(autoScalingScheduleSaturdayKey);

                                writer.Write(saturdayListValue);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        if (autoScalingSchedule != null) 
                        {
                            if (autoScalingSchedule.Sunday != null && autoScalingSchedule.Sunday.Count > 0)
                            {
                                writer.WritePropertyName("Sunday");
                                writer.WriteObjectStart();
                                foreach (string autoScalingScheduleSundayKey in autoScalingSchedule.Sunday.Keys)
                                {
                                    string sundayListValue;
                                    bool sundayListValueHasValue = autoScalingSchedule.Sunday.TryGetValue(autoScalingScheduleSundayKey, out sundayListValue);
                                    writer.WritePropertyName(autoScalingScheduleSundayKey);

                                writer.Write(sundayListValue);
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        writer.WriteObjectEnd();
                    }
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
