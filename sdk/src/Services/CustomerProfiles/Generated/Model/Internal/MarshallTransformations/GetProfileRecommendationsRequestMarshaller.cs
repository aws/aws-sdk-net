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

#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetProfileRecommendations Request Marshaller
    /// </summary>       
    public class GetProfileRecommendationsRequestMarshaller : IMarshaller<IRequest, GetProfileRecommendationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetProfileRecommendationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetProfileRecommendationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            if (!publicRequest.IsSetProfileId())
                throw new AmazonCustomerProfilesException("Request object does not have required field ProfileId set");
            request.AddPathResource("{ProfileId}", StringUtils.FromString(publicRequest.ProfileId));
            request.ResourcePath = "/domains/{DomainName}/profiles/{ProfileId}/recommendations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContext())
                {
                    context.Writer.WritePropertyName("Context");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestContextKvp in publicRequest.Context)
                    {
                        context.Writer.WritePropertyName(publicRequestContextKvp.Key);
                        var publicRequestContextValue = publicRequestContextKvp.Value;

                            context.Writer.Write(publicRequestContextValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetRecommenderName())
                {
                    context.Writer.WritePropertyName("RecommenderName");
                    context.Writer.Write(publicRequest.RecommenderName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetProfileRecommendationsRequestMarshaller _instance = new GetProfileRecommendationsRequestMarshaller();        

        internal static GetProfileRecommendationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetProfileRecommendationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}