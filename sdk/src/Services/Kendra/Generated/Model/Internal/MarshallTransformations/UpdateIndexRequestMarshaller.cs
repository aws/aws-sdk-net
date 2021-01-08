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
    /// UpdateIndex Request Marshaller
    /// </summary>       
    public class UpdateIndexRequestMarshaller : IMarshaller<IRequest, UpdateIndexRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIndexRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateIndexRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kendra");
            string target = "AWSKendraFrontendService.UpdateIndex";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-02-03";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapacityUnits())
                {
                    context.Writer.WritePropertyName("CapacityUnits");
                    context.Writer.WriteObjectStart();

                    var marshaller = CapacityUnitsConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CapacityUnits, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDocumentMetadataConfigurationUpdates())
                {
                    context.Writer.WritePropertyName("DocumentMetadataConfigurationUpdates");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDocumentMetadataConfigurationUpdatesListValue in publicRequest.DocumentMetadataConfigurationUpdates)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DocumentMetadataConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestDocumentMetadataConfigurationUpdatesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("Id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetUserContextPolicy())
                {
                    context.Writer.WritePropertyName("UserContextPolicy");
                    context.Writer.Write(publicRequest.UserContextPolicy);
                }

                if(publicRequest.IsSetUserTokenConfigurations())
                {
                    context.Writer.WritePropertyName("UserTokenConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserTokenConfigurationsListValue in publicRequest.UserTokenConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = UserTokenConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestUserTokenConfigurationsListValue, context);

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
        private static UpdateIndexRequestMarshaller _instance = new UpdateIndexRequestMarshaller();        

        internal static UpdateIndexRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIndexRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}