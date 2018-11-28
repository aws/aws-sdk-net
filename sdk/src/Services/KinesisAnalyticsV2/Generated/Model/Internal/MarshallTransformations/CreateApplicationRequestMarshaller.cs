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

/*
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplication Request Marshaller
    /// </summary>       
    public class CreateApplicationRequestMarshaller : IMarshaller<IRequest, CreateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisAnalyticsV2");
            string target = "KinesisAnalytics_20180523.CreateApplication";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationConfiguration())
                {
                    context.Writer.WritePropertyName("ApplicationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ApplicationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApplicationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetApplicationDescription())
                {
                    context.Writer.WritePropertyName("ApplicationDescription");
                    context.Writer.Write(publicRequest.ApplicationDescription);
                }

                if(publicRequest.IsSetApplicationName())
                {
                    context.Writer.WritePropertyName("ApplicationName");
                    context.Writer.Write(publicRequest.ApplicationName);
                }

                if(publicRequest.IsSetCloudWatchLoggingOptions())
                {
                    context.Writer.WritePropertyName("CloudWatchLoggingOptions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCloudWatchLoggingOptionsListValue in publicRequest.CloudWatchLoggingOptions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CloudWatchLoggingOptionMarshaller.Instance;
                        marshaller.Marshall(publicRequestCloudWatchLoggingOptionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRuntimeEnvironment())
                {
                    context.Writer.WritePropertyName("RuntimeEnvironment");
                    context.Writer.Write(publicRequest.RuntimeEnvironment);
                }

                if(publicRequest.IsSetServiceExecutionRole())
                {
                    context.Writer.WritePropertyName("ServiceExecutionRole");
                    context.Writer.Write(publicRequest.ServiceExecutionRole);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateApplicationRequestMarshaller _instance = new CreateApplicationRequestMarshaller();        

        internal static CreateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}