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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMPricingCalculator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePreferences Request Marshaller
    /// </summary>       
    public class UpdatePreferencesRequestMarshaller : IMarshaller<IRequest, UpdatePreferencesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePreferencesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePreferencesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BCMPricingCalculator");
            string target = "AWSBCMPricingCalculator.UpdatePreferences";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-06-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetManagementAccountRateTypeSelections())
                {
                    context.Writer.WritePropertyName("managementAccountRateTypeSelections");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestManagementAccountRateTypeSelectionsListValue in publicRequest.ManagementAccountRateTypeSelections)
                    {
                            context.Writer.Write(publicRequestManagementAccountRateTypeSelectionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMemberAccountRateTypeSelections())
                {
                    context.Writer.WritePropertyName("memberAccountRateTypeSelections");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMemberAccountRateTypeSelectionsListValue in publicRequest.MemberAccountRateTypeSelections)
                    {
                            context.Writer.Write(publicRequestMemberAccountRateTypeSelectionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStandaloneAccountRateTypeSelections())
                {
                    context.Writer.WritePropertyName("standaloneAccountRateTypeSelections");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStandaloneAccountRateTypeSelectionsListValue in publicRequest.StandaloneAccountRateTypeSelections)
                    {
                            context.Writer.Write(publicRequestStandaloneAccountRateTypeSelectionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdatePreferencesRequestMarshaller _instance = new UpdatePreferencesRequestMarshaller();        

        internal static UpdatePreferencesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePreferencesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}