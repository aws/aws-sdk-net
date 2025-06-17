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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateFindingsV2 Request Marshaller
    /// </summary>       
    public class BatchUpdateFindingsV2RequestMarshaller : IMarshaller<IRequest, BatchUpdateFindingsV2Request> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUpdateFindingsV2Request)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchUpdateFindingsV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/findingsv2/batchupdatev2";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComment())
                {
                    context.Writer.WritePropertyName("Comment");
                    context.Writer.Write(publicRequest.Comment);
                }

                if(publicRequest.IsSetFindingIdentifiers())
                {
                    context.Writer.WritePropertyName("FindingIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFindingIdentifiersListValue in publicRequest.FindingIdentifiers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OcsfFindingIdentifierMarshaller.Instance;
                        marshaller.Marshall(publicRequestFindingIdentifiersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetadataUids())
                {
                    context.Writer.WritePropertyName("MetadataUids");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetadataUidsListValue in publicRequest.MetadataUids)
                    {
                            context.Writer.Write(publicRequestMetadataUidsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSeverityId())
                {
                    context.Writer.WritePropertyName("SeverityId");
                    context.Writer.Write(publicRequest.SeverityId);
                }

                if(publicRequest.IsSetStatusId())
                {
                    context.Writer.WritePropertyName("StatusId");
                    context.Writer.Write(publicRequest.StatusId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchUpdateFindingsV2RequestMarshaller _instance = new BatchUpdateFindingsV2RequestMarshaller();        

        internal static BatchUpdateFindingsV2RequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUpdateFindingsV2RequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}