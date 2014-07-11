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

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMetricFilter Request Marshaller
    /// </summary>       
    public class PutMetricFilterRequestMarshaller : IMarshaller<IRequest, PutMetricFilterRequest> 
    {
        public IRequest Marshall(PutMetricFilterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.PutMetricFilter";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetFilterName())
                {
                    writer.WritePropertyName("filterName");
                    writer.Write(publicRequest.FilterName);
                }

                if(publicRequest.IsSetFilterPattern())
                {
                    writer.WritePropertyName("filterPattern");
                    writer.Write(publicRequest.FilterPattern);
                }

                if(publicRequest.IsSetLogGroupName())
                {
                    writer.WritePropertyName("logGroupName");
                    writer.Write(publicRequest.LogGroupName);
                }

                if(publicRequest.IsSetMetricTransformations())
                {
                    writer.WritePropertyName("metricTransformations");
                    writer.WriteArrayStart();
                    foreach(var publicRequestMetricTransformationsListValue in publicRequest.MetricTransformations)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestMetricTransformationsListValue.IsSetMetricName())
                        {
                            writer.WritePropertyName("metricName");
                            writer.Write(publicRequestMetricTransformationsListValue.MetricName);
                        }

                        if(publicRequestMetricTransformationsListValue.IsSetMetricNamespace())
                        {
                            writer.WritePropertyName("metricNamespace");
                            writer.Write(publicRequestMetricTransformationsListValue.MetricNamespace);
                        }

                        if(publicRequestMetricTransformationsListValue.IsSetMetricValue())
                        {
                            writer.WritePropertyName("metricValue");
                            writer.Write(publicRequestMetricTransformationsListValue.MetricValue);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}