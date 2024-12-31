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
    /// BatchGetCalculatedAttributeForProfile Request Marshaller
    /// </summary>       
    public class BatchGetCalculatedAttributeForProfileRequestMarshaller : IMarshaller<IRequest, BatchGetCalculatedAttributeForProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchGetCalculatedAttributeForProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchGetCalculatedAttributeForProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetCalculatedAttributeName())
                throw new AmazonCustomerProfilesException("Request object does not have required field CalculatedAttributeName set");
            request.AddPathResource("{CalculatedAttributeName}", StringUtils.FromString(publicRequest.CalculatedAttributeName));
            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/domains/{DomainName}/calculated-attributes/{CalculatedAttributeName}/batch-get-for-profiles";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConditionOverrides())
                {
                    context.Writer.WritePropertyName("ConditionOverrides");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConditionOverridesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConditionOverrides, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProfileIds())
                {
                    context.Writer.WritePropertyName("ProfileIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProfileIdsListValue in publicRequest.ProfileIds)
                    {
                            context.Writer.Write(publicRequestProfileIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchGetCalculatedAttributeForProfileRequestMarshaller _instance = new BatchGetCalculatedAttributeForProfileRequestMarshaller();        

        internal static BatchGetCalculatedAttributeForProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetCalculatedAttributeForProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}