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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSubscriptionGrant Request Marshaller
    /// </summary>       
    public class CreateSubscriptionGrantRequestMarshaller : IMarshaller<IRequest, CreateSubscriptionGrantRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSubscriptionGrantRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSubscriptionGrantRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/subscription-grants";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssetTargetNames())
                {
                    context.Writer.WritePropertyName("assetTargetNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAssetTargetNamesListValue in publicRequest.AssetTargetNames)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AssetTargetNameMapMarshaller.Instance;
                        marshaller.Marshall(publicRequestAssetTargetNamesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetEnvironmentIdentifier())
                {
                    context.Writer.WritePropertyName("environmentIdentifier");
                    context.Writer.Write(publicRequest.EnvironmentIdentifier);
                }

                if(publicRequest.IsSetGrantedEntity())
                {
                    context.Writer.WritePropertyName("grantedEntity");
                    context.Writer.WriteObjectStart();

                    var marshaller = GrantedEntityInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GrantedEntity, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSubscriptionTargetIdentifier())
                {
                    context.Writer.WritePropertyName("subscriptionTargetIdentifier");
                    context.Writer.Write(publicRequest.SubscriptionTargetIdentifier);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSubscriptionGrantRequestMarshaller _instance = new CreateSubscriptionGrantRequestMarshaller();        

        internal static CreateSubscriptionGrantRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSubscriptionGrantRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}