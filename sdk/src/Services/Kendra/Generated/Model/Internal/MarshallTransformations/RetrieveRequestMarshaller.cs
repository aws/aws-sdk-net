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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Retrieve Request Marshaller
    /// </summary>       
    public class RetrieveRequestMarshaller : IMarshaller<IRequest, RetrieveRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RetrieveRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RetrieveRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kendra");
            string target = "AWSKendraFrontendService.Retrieve";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-02-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributeFilter())
                {
                    context.Writer.WritePropertyName("AttributeFilter");
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AttributeFilter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDocumentRelevanceOverrideConfigurations())
                {
                    context.Writer.WritePropertyName("DocumentRelevanceOverrideConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDocumentRelevanceOverrideConfigurationsListValue in publicRequest.DocumentRelevanceOverrideConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DocumentRelevanceConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestDocumentRelevanceOverrideConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIndexId())
                {
                    context.Writer.WritePropertyName("IndexId");
                    context.Writer.Write(publicRequest.IndexId);
                }

                if(publicRequest.IsSetPageNumber())
                {
                    context.Writer.WritePropertyName("PageNumber");
                    context.Writer.Write(publicRequest.PageNumber);
                }

                if(publicRequest.IsSetPageSize())
                {
                    context.Writer.WritePropertyName("PageSize");
                    context.Writer.Write(publicRequest.PageSize);
                }

                if(publicRequest.IsSetQueryText())
                {
                    context.Writer.WritePropertyName("QueryText");
                    context.Writer.Write(publicRequest.QueryText);
                }

                if(publicRequest.IsSetRequestedDocumentAttributes())
                {
                    context.Writer.WritePropertyName("RequestedDocumentAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRequestedDocumentAttributesListValue in publicRequest.RequestedDocumentAttributes)
                    {
                            context.Writer.Write(publicRequestRequestedDocumentAttributesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserContext())
                {
                    context.Writer.WritePropertyName("UserContext");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserContextMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UserContext, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RetrieveRequestMarshaller _instance = new RetrieveRequestMarshaller();        

        internal static RetrieveRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RetrieveRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}