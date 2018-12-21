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
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/apps/{appId}/domains/{domainName}";
            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyException("Request object does not have required field AppId set");
            uriResourcePath = uriResourcePath.Replace("{appId}", StringUtils.FromStringWithSlashEncoding(publicRequest.AppId));
            if (!publicRequest.IsSetDomainName())
                throw new AmazonAmplifyException("Request object does not have required field DomainName set");
            uriResourcePath = uriResourcePath.Replace("{domainName}", StringUtils.FromStringWithSlashEncoding(publicRequest.DomainName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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