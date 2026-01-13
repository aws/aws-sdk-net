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

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSubscriptionTarget Request Marshaller
    /// </summary>       
    public class CreateSubscriptionTargetRequestMarshaller : IMarshaller<IRequest, CreateSubscriptionTargetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSubscriptionTargetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSubscriptionTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            if (!publicRequest.IsSetEnvironmentIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field EnvironmentIdentifier set");
            request.AddPathResource("{environmentIdentifier}", StringUtils.FromString(publicRequest.EnvironmentIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/environments/{environmentIdentifier}/subscription-targets";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicableAssetTypes())
                {
                    context.Writer.WritePropertyName("applicableAssetTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestApplicableAssetTypesListValue in publicRequest.ApplicableAssetTypes)
                    {
                            context.Writer.Write(publicRequestApplicableAssetTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAuthorizedPrincipals())
                {
                    context.Writer.WritePropertyName("authorizedPrincipals");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAuthorizedPrincipalsListValue in publicRequest.AuthorizedPrincipals)
                    {
                            context.Writer.Write(publicRequestAuthorizedPrincipalsListValue);
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
                if(publicRequest.IsSetManageAccessRole())
                {
                    context.Writer.WritePropertyName("manageAccessRole");
                    context.Writer.Write(publicRequest.ManageAccessRole);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProvider())
                {
                    context.Writer.WritePropertyName("provider");
                    context.Writer.Write(publicRequest.Provider);
                }

                if(publicRequest.IsSetSubscriptionGrantCreationMode())
                {
                    context.Writer.WritePropertyName("subscriptionGrantCreationMode");
                    context.Writer.Write(publicRequest.SubscriptionGrantCreationMode);
                }

                if(publicRequest.IsSetSubscriptionTargetConfig())
                {
                    context.Writer.WritePropertyName("subscriptionTargetConfig");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubscriptionTargetConfigListValue in publicRequest.SubscriptionTargetConfig)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SubscriptionTargetFormMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubscriptionTargetConfigListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSubscriptionTargetRequestMarshaller _instance = new CreateSubscriptionTargetRequestMarshaller();        

        internal static CreateSubscriptionTargetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSubscriptionTargetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}