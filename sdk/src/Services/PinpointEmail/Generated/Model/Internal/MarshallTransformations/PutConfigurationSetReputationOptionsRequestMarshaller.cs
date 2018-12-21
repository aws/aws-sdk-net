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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutConfigurationSetReputationOptions Request Marshaller
    /// </summary>       
    public class PutConfigurationSetReputationOptionsRequestMarshaller : IMarshaller<IRequest, PutConfigurationSetReputationOptionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutConfigurationSetReputationOptionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutConfigurationSetReputationOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointEmail");
            string target = "com.amazonaws.services.pinpoint.email.PutConfigurationSetReputationOptions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-07-26";            
            request.HttpMethod = "PUT";

            string uriResourcePath = "/v1/email/configuration-sets/{ConfigurationSetName}/reputation-options";
            if (!publicRequest.IsSetConfigurationSetName())
                throw new AmazonPinpointEmailException("Request object does not have required field ConfigurationSetName set");
            uriResourcePath = uriResourcePath.Replace("{ConfigurationSetName}", StringUtils.FromStringWithSlashEncoding(publicRequest.ConfigurationSetName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetReputationMetricsEnabled())
                {
                    context.Writer.WritePropertyName("ReputationMetricsEnabled");
                    context.Writer.Write(publicRequest.ReputationMetricsEnabled);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutConfigurationSetReputationOptionsRequestMarshaller _instance = new PutConfigurationSetReputationOptionsRequestMarshaller();        

        internal static PutConfigurationSetReputationOptionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutConfigurationSetReputationOptionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}