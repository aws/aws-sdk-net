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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Amplify.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Amplify.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDomainAssociation Request Marshaller
    /// </summary>       
    public class UpdateDomainAssociationRequestMarshaller : IMarshaller<IRequest, UpdateDomainAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDomainAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDomainAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Amplify");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyException("Request object does not have required field AppId set");
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));
            if (!publicRequest.IsSetDomainName())
                throw new AmazonAmplifyException("Request object does not have required field DomainName set");
            request.AddPathResource("{domainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/apps/{appId}/domains/{domainName}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAutoSubDomainCreationPatterns())
                {
                    context.Writer.WritePropertyName("autoSubDomainCreationPatterns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAutoSubDomainCreationPatternsListValue in publicRequest.AutoSubDomainCreationPatterns)
                    {
                            context.Writer.Write(publicRequestAutoSubDomainCreationPatternsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAutoSubDomainIAMRole())
                {
                    context.Writer.WritePropertyName("autoSubDomainIAMRole");
                    context.Writer.Write(publicRequest.AutoSubDomainIAMRole);
                }

                if(publicRequest.IsSetEnableAutoSubDomain())
                {
                    context.Writer.WritePropertyName("enableAutoSubDomain");
                    context.Writer.Write(publicRequest.EnableAutoSubDomain);
                }

                if(publicRequest.IsSetSubDomainSettings())
                {
                    context.Writer.WritePropertyName("subDomainSettings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubDomainSettingsListValue in publicRequest.SubDomainSettings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SubDomainSettingMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubDomainSettingsListValue, context);

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
        private static UpdateDomainAssociationRequestMarshaller _instance = new UpdateDomainAssociationRequestMarshaller();        

        internal static UpdateDomainAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDomainAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}