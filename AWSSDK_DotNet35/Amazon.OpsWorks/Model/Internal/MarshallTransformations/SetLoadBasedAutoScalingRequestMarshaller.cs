/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// SetLoadBasedAutoScaling Request Marshaller
    /// </summary>       
    public class SetLoadBasedAutoScalingRequestMarshaller : IMarshaller<IRequest, SetLoadBasedAutoScalingRequest> 
    {
        public IRequest Marshall(SetLoadBasedAutoScalingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.SetLoadBasedAutoScaling";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetDownScaling())
                {
                    writer.WritePropertyName("DownScaling");
                    writer.WriteObjectStart();
                    if(publicRequest.DownScaling.IsSetCpuThreshold())
                    {
                        writer.WritePropertyName("CpuThreshold");
                        writer.Write(publicRequest.DownScaling.CpuThreshold);
                    }

                    if(publicRequest.DownScaling.IsSetIgnoreMetricsTime())
                    {
                        writer.WritePropertyName("IgnoreMetricsTime");
                        writer.Write(publicRequest.DownScaling.IgnoreMetricsTime);
                    }

                    if(publicRequest.DownScaling.IsSetInstanceCount())
                    {
                        writer.WritePropertyName("InstanceCount");
                        writer.Write(publicRequest.DownScaling.InstanceCount);
                    }

                    if(publicRequest.DownScaling.IsSetLoadThreshold())
                    {
                        writer.WritePropertyName("LoadThreshold");
                        writer.Write(publicRequest.DownScaling.LoadThreshold);
                    }

                    if(publicRequest.DownScaling.IsSetMemoryThreshold())
                    {
                        writer.WritePropertyName("MemoryThreshold");
                        writer.Write(publicRequest.DownScaling.MemoryThreshold);
                    }

                    if(publicRequest.DownScaling.IsSetThresholdsWaitTime())
                    {
                        writer.WritePropertyName("ThresholdsWaitTime");
                        writer.Write(publicRequest.DownScaling.ThresholdsWaitTime);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEnable())
                {
                    writer.WritePropertyName("Enable");
                    writer.Write(publicRequest.Enable);
                }

                if(publicRequest.IsSetLayerId())
                {
                    writer.WritePropertyName("LayerId");
                    writer.Write(publicRequest.LayerId);
                }

                if(publicRequest.IsSetUpScaling())
                {
                    writer.WritePropertyName("UpScaling");
                    writer.WriteObjectStart();
                    if(publicRequest.UpScaling.IsSetCpuThreshold())
                    {
                        writer.WritePropertyName("CpuThreshold");
                        writer.Write(publicRequest.UpScaling.CpuThreshold);
                    }

                    if(publicRequest.UpScaling.IsSetIgnoreMetricsTime())
                    {
                        writer.WritePropertyName("IgnoreMetricsTime");
                        writer.Write(publicRequest.UpScaling.IgnoreMetricsTime);
                    }

                    if(publicRequest.UpScaling.IsSetInstanceCount())
                    {
                        writer.WritePropertyName("InstanceCount");
                        writer.Write(publicRequest.UpScaling.InstanceCount);
                    }

                    if(publicRequest.UpScaling.IsSetLoadThreshold())
                    {
                        writer.WritePropertyName("LoadThreshold");
                        writer.Write(publicRequest.UpScaling.LoadThreshold);
                    }

                    if(publicRequest.UpScaling.IsSetMemoryThreshold())
                    {
                        writer.WritePropertyName("MemoryThreshold");
                        writer.Write(publicRequest.UpScaling.MemoryThreshold);
                    }

                    if(publicRequest.UpScaling.IsSetThresholdsWaitTime())
                    {
                        writer.WritePropertyName("ThresholdsWaitTime");
                        writer.Write(publicRequest.UpScaling.ThresholdsWaitTime);
                    }

                    writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}