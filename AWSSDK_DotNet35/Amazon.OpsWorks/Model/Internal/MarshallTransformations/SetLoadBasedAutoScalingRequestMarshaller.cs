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
    /// Set Load Based Auto Scaling Request Marshaller
    /// </summary>       
    internal class SetLoadBasedAutoScalingRequestMarshaller : IMarshaller<IRequest, SetLoadBasedAutoScalingRequest> 
    {
        

        public IRequest Marshall(SetLoadBasedAutoScalingRequest setLoadBasedAutoScalingRequest) 
        {

            IRequest request = new DefaultRequest(setLoadBasedAutoScalingRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.SetLoadBasedAutoScaling";
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
                
                if (setLoadBasedAutoScalingRequest != null && setLoadBasedAutoScalingRequest.IsSetLayerId()) 
                {
                    writer.WritePropertyName("LayerId");
                    writer.Write(setLoadBasedAutoScalingRequest.LayerId);
                }
                if (setLoadBasedAutoScalingRequest != null && setLoadBasedAutoScalingRequest.IsSetEnable()) 
                {
                    writer.WritePropertyName("Enable");
                    writer.Write(setLoadBasedAutoScalingRequest.Enable);
                }

                if (setLoadBasedAutoScalingRequest != null) 
                {
                    AutoScalingThresholds upScaling = setLoadBasedAutoScalingRequest.UpScaling;
                    if (upScaling != null)
                    {
                        writer.WritePropertyName("UpScaling");
                        writer.WriteObjectStart();
                        if (upScaling != null && upScaling.IsSetInstanceCount()) 
                        {
                            writer.WritePropertyName("InstanceCount");
                            writer.Write(upScaling.InstanceCount);
                        }
                        if (upScaling != null && upScaling.IsSetThresholdsWaitTime()) 
                        {
                            writer.WritePropertyName("ThresholdsWaitTime");
                            writer.Write(upScaling.ThresholdsWaitTime);
                        }
                        if (upScaling != null && upScaling.IsSetIgnoreMetricsTime()) 
                        {
                            writer.WritePropertyName("IgnoreMetricsTime");
                            writer.Write(upScaling.IgnoreMetricsTime);
                        }
                        if (upScaling != null && upScaling.IsSetCpuThreshold()) 
                        {
                            writer.WritePropertyName("CpuThreshold");
                            writer.Write(upScaling.CpuThreshold);
                        }
                        if (upScaling != null && upScaling.IsSetMemoryThreshold()) 
                        {
                            writer.WritePropertyName("MemoryThreshold");
                            writer.Write(upScaling.MemoryThreshold);
                        }
                        if (upScaling != null && upScaling.IsSetLoadThreshold()) 
                        {
                            writer.WritePropertyName("LoadThreshold");
                            writer.Write(upScaling.LoadThreshold);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (setLoadBasedAutoScalingRequest != null) 
                {
                    AutoScalingThresholds downScaling = setLoadBasedAutoScalingRequest.DownScaling;
                    if (downScaling != null)
                    {
                        writer.WritePropertyName("DownScaling");
                        writer.WriteObjectStart();
                        if (downScaling != null && downScaling.IsSetInstanceCount()) 
                        {
                            writer.WritePropertyName("InstanceCount");
                            writer.Write(downScaling.InstanceCount);
                        }
                        if (downScaling != null && downScaling.IsSetThresholdsWaitTime()) 
                        {
                            writer.WritePropertyName("ThresholdsWaitTime");
                            writer.Write(downScaling.ThresholdsWaitTime);
                        }
                        if (downScaling != null && downScaling.IsSetIgnoreMetricsTime()) 
                        {
                            writer.WritePropertyName("IgnoreMetricsTime");
                            writer.Write(downScaling.IgnoreMetricsTime);
                        }
                        if (downScaling != null && downScaling.IsSetCpuThreshold()) 
                        {
                            writer.WritePropertyName("CpuThreshold");
                            writer.Write(downScaling.CpuThreshold);
                        }
                        if (downScaling != null && downScaling.IsSetMemoryThreshold()) 
                        {
                            writer.WritePropertyName("MemoryThreshold");
                            writer.Write(downScaling.MemoryThreshold);
                        }
                        if (downScaling != null && downScaling.IsSetLoadThreshold()) 
                        {
                            writer.WritePropertyName("LoadThreshold");
                            writer.Write(downScaling.LoadThreshold);
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
