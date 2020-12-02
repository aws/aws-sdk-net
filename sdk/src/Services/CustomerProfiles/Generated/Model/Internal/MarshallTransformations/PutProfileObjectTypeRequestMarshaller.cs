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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutProfileObjectType Request Marshaller
    /// </summary>       
    public class PutProfileObjectTypeRequestMarshaller : IMarshaller<IRequest, PutProfileObjectTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutProfileObjectTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutProfileObjectTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            if (!publicRequest.IsSetObjectTypeName())
                throw new AmazonCustomerProfilesException("Request object does not have required field ObjectTypeName set");
            request.AddPathResource("{ObjectTypeName}", StringUtils.FromString(publicRequest.ObjectTypeName));
            request.ResourcePath = "/domains/{DomainName}/object-types/{ObjectTypeName}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowProfileCreation())
                {
                    context.Writer.WritePropertyName("AllowProfileCreation");
                    context.Writer.Write(publicRequest.AllowProfileCreation);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEncryptionKey())
                {
                    context.Writer.WritePropertyName("EncryptionKey");
                    context.Writer.Write(publicRequest.EncryptionKey);
                }

                if(publicRequest.IsSetExpirationDays())
                {
                    context.Writer.WritePropertyName("ExpirationDays");
                    context.Writer.Write(publicRequest.ExpirationDays);
                }

                if(publicRequest.IsSetFields())
                {
                    context.Writer.WritePropertyName("Fields");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFieldsKvp in publicRequest.Fields)
                    {
                        context.Writer.WritePropertyName(publicRequestFieldsKvp.Key);
                        var publicRequestFieldsValue = publicRequestFieldsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = ObjectTypeFieldMarshaller.Instance;
                        marshaller.Marshall(publicRequestFieldsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKeys())
                {
                    context.Writer.WritePropertyName("Keys");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestKeysKvp in publicRequest.Keys)
                    {
                        context.Writer.WritePropertyName(publicRequestKeysKvp.Key);
                        var publicRequestKeysValue = publicRequestKeysKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestKeysValueListValue in publicRequestKeysValue)
                        {
                            context.Writer.WriteObjectStart();

                            var marshaller = ObjectTypeKeyMarshaller.Instance;
                            marshaller.Marshall(publicRequestKeysValueListValue, context);

                            context.Writer.WriteObjectEnd();
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTemplateId())
                {
                    context.Writer.WritePropertyName("TemplateId");
                    context.Writer.Write(publicRequest.TemplateId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutProfileObjectTypeRequestMarshaller _instance = new PutProfileObjectTypeRequestMarshaller();        

        internal static PutProfileObjectTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutProfileObjectTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}