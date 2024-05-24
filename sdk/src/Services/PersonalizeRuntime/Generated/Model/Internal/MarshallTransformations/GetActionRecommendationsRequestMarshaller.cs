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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PersonalizeRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PersonalizeRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetActionRecommendations Request Marshaller
    /// </summary>       
    public class GetActionRecommendationsRequestMarshaller : IMarshaller<IRequest, GetActionRecommendationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetActionRecommendationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetActionRecommendationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PersonalizeRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "/action-recommendations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCampaignArn())
                {
                    context.Writer.WritePropertyName("campaignArn");
                    context.Writer.Write(publicRequest.CampaignArn);
                }

                if(publicRequest.IsSetFilterArn())
                {
                    context.Writer.WritePropertyName("filterArn");
                    context.Writer.Write(publicRequest.FilterArn);
                }

                if(publicRequest.IsSetFilterValues())
                {
                    context.Writer.WritePropertyName("filterValues");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFilterValuesKvp in publicRequest.FilterValues)
                    {
                        context.Writer.WritePropertyName(publicRequestFilterValuesKvp.Key);
                        var publicRequestFilterValuesValue = publicRequestFilterValuesKvp.Value;

                            context.Writer.Write(publicRequestFilterValuesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNumResults())
                {
                    context.Writer.WritePropertyName("numResults");
                    context.Writer.Write(publicRequest.NumResults);
                }

                if(publicRequest.IsSetUserId())
                {
                    context.Writer.WritePropertyName("userId");
                    context.Writer.Write(publicRequest.UserId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetActionRecommendationsRequestMarshaller _instance = new GetActionRecommendationsRequestMarshaller();        

        internal static GetActionRecommendationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetActionRecommendationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}