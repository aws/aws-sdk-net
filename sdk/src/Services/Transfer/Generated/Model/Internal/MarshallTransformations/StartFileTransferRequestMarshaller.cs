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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartFileTransfer Request Marshaller
    /// </summary>       
    public class StartFileTransferRequestMarshaller : IMarshaller<IRequest, StartFileTransferRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartFileTransferRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartFileTransferRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.StartFileTransfer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConnectorId())
                {
                    context.Writer.WritePropertyName("ConnectorId");
                    context.Writer.Write(publicRequest.ConnectorId);
                }

                if(publicRequest.IsSetCustomHttpHeaders())
                {
                    context.Writer.WritePropertyName("CustomHttpHeaders");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCustomHttpHeadersListValue in publicRequest.CustomHttpHeaders)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CustomHttpHeaderMarshaller.Instance;
                        marshaller.Marshall(publicRequestCustomHttpHeadersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLocalDirectoryPath())
                {
                    context.Writer.WritePropertyName("LocalDirectoryPath");
                    context.Writer.Write(publicRequest.LocalDirectoryPath);
                }

                if(publicRequest.IsSetRemoteDirectoryPath())
                {
                    context.Writer.WritePropertyName("RemoteDirectoryPath");
                    context.Writer.Write(publicRequest.RemoteDirectoryPath);
                }

                if(publicRequest.IsSetRetrieveFilePaths())
                {
                    context.Writer.WritePropertyName("RetrieveFilePaths");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRetrieveFilePathsListValue in publicRequest.RetrieveFilePaths)
                    {
                            context.Writer.Write(publicRequestRetrieveFilePathsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSendFilePaths())
                {
                    context.Writer.WritePropertyName("SendFilePaths");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSendFilePathsListValue in publicRequest.SendFilePaths)
                    {
                            context.Writer.Write(publicRequestSendFilePathsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartFileTransferRequestMarshaller _instance = new StartFileTransferRequestMarshaller();        

        internal static StartFileTransferRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartFileTransferRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}