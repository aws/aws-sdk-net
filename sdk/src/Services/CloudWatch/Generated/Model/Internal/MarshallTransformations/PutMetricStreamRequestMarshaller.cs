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

/*
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMetricStream Request Marshaller
    /// </summary>       
    public class PutMetricStreamRequestMarshaller : IMarshaller<IRequest, PutMetricStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMetricStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMetricStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            string target = "GraniteServiceVersion20100801.PutMetricStream";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetExcludeFilters())
                {
                    context.Writer.WritePropertyName("ExcludeFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestExcludeFiltersListValue in publicRequest.ExcludeFilters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricStreamFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestExcludeFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFirehoseArn())
                {
                    context.Writer.WritePropertyName("FirehoseArn");
                    context.Writer.Write(publicRequest.FirehoseArn);
                }

                if(publicRequest.IsSetIncludeFilters())
                {
                    context.Writer.WritePropertyName("IncludeFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIncludeFiltersListValue in publicRequest.IncludeFilters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricStreamFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestIncludeFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIncludeLinkedAccountsMetrics())
                {
                    context.Writer.WritePropertyName("IncludeLinkedAccountsMetrics");
                    context.Writer.Write(publicRequest.IncludeLinkedAccountsMetrics);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOutputFormat())
                {
                    context.Writer.WritePropertyName("OutputFormat");
                    context.Writer.Write(publicRequest.OutputFormat);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetStatisticsConfigurations())
                {
                    context.Writer.WritePropertyName("StatisticsConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStatisticsConfigurationsListValue in publicRequest.StatisticsConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricStreamStatisticsConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestStatisticsConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutMetricStreamRequestMarshaller _instance = new PutMetricStreamRequestMarshaller();        

        internal static PutMetricStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMetricStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}