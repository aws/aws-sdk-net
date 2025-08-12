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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartQuery Request Marshaller
    /// </summary>       
    public class StartQueryRequestMarshaller : IMarshaller<IRequest, StartQueryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartQueryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartQueryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/Logs_20140328/operation/StartQuery";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetEndTime())
                {
                    context.Writer.WriteTextString("endTime");
                    context.Writer.WriteInt64(publicRequest.EndTime.Value);
                }
                if (publicRequest.IsSetLimit())
                {
                    context.Writer.WriteTextString("limit");
                    context.Writer.WriteInt32(publicRequest.Limit.Value);
                }
                if (publicRequest.IsSetLogGroupIdentifiers())
                {
                    context.Writer.WriteTextString("logGroupIdentifiers");
                    context.Writer.WriteStartArray(publicRequest.LogGroupIdentifiers.Count);
                    foreach(var publicRequestLogGroupIdentifiersListValue in publicRequest.LogGroupIdentifiers)
                    {
                            context.Writer.WriteTextString(publicRequestLogGroupIdentifiersListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetLogGroupName())
                {
                    context.Writer.WriteTextString("logGroupName");
                    context.Writer.WriteTextString(publicRequest.LogGroupName);
                }
                if (publicRequest.IsSetLogGroupNames())
                {
                    context.Writer.WriteTextString("logGroupNames");
                    context.Writer.WriteStartArray(publicRequest.LogGroupNames.Count);
                    foreach(var publicRequestLogGroupNamesListValue in publicRequest.LogGroupNames)
                    {
                            context.Writer.WriteTextString(publicRequestLogGroupNamesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetQueryLanguage())
                {
                    context.Writer.WriteTextString("queryLanguage");
                    context.Writer.WriteTextString(publicRequest.QueryLanguage);
                }
                if (publicRequest.IsSetQueryString())
                {
                    context.Writer.WriteTextString("queryString");
                    context.Writer.WriteTextString(publicRequest.QueryString);
                }
                if (publicRequest.IsSetStartTime())
                {
                    context.Writer.WriteTextString("startTime");
                    context.Writer.WriteInt64(publicRequest.StartTime.Value);
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static StartQueryRequestMarshaller _instance = new StartQueryRequestMarshaller();        

        internal static StartQueryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartQueryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}