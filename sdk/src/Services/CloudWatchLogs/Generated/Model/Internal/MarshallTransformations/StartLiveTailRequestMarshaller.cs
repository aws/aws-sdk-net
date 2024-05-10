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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartLiveTail Request Marshaller
    /// </summary>       
    public class StartLiveTailRequestMarshaller : IMarshaller<IRequest, StartLiveTailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartLiveTailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartLiveTailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.StartLiveTail";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLogEventFilterPattern())
                {
                    context.Writer.WritePropertyName("logEventFilterPattern");
                    context.Writer.Write(publicRequest.LogEventFilterPattern);
                }

                if(publicRequest.IsSetLogGroupIdentifiers())
                {
                    context.Writer.WritePropertyName("logGroupIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLogGroupIdentifiersListValue in publicRequest.LogGroupIdentifiers)
                    {
                            context.Writer.Write(publicRequestLogGroupIdentifiersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLogStreamNamePrefixes())
                {
                    context.Writer.WritePropertyName("logStreamNamePrefixes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLogStreamNamePrefixesListValue in publicRequest.LogStreamNamePrefixes)
                    {
                            context.Writer.Write(publicRequestLogStreamNamePrefixesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLogStreamNames())
                {
                    context.Writer.WritePropertyName("logStreamNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLogStreamNamesListValue in publicRequest.LogStreamNames)
                    {
                            context.Writer.Write(publicRequestLogStreamNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"streaming-";

            return request;
        }
        private static StartLiveTailRequestMarshaller _instance = new StartLiveTailRequestMarshaller();        

        internal static StartLiveTailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartLiveTailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}