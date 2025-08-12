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
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/Logs_20140328/operation/StartLiveTail";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/vnd.amazon.eventstream";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetLogEventFilterPattern())
                {
                    context.Writer.WriteTextString("logEventFilterPattern");
                    context.Writer.WriteTextString(publicRequest.LogEventFilterPattern);
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
                if (publicRequest.IsSetLogStreamNamePrefixes())
                {
                    context.Writer.WriteTextString("logStreamNamePrefixes");
                    context.Writer.WriteStartArray(publicRequest.LogStreamNamePrefixes.Count);
                    foreach(var publicRequestLogStreamNamePrefixesListValue in publicRequest.LogStreamNamePrefixes)
                    {
                            context.Writer.WriteTextString(publicRequestLogStreamNamePrefixesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetLogStreamNames())
                {
                    context.Writer.WriteTextString("logStreamNames");
                    context.Writer.WriteStartArray(publicRequest.LogStreamNames.Count);
                    foreach(var publicRequestLogStreamNamesListValue in publicRequest.LogStreamNames)
                    {
                            context.Writer.WriteTextString(publicRequestLogStreamNamesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
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