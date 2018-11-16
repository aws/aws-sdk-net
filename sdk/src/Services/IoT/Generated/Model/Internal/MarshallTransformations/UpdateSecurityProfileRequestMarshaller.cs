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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSecurityProfile Request Marshaller
    /// </summary>       
    public class UpdateSecurityProfileRequestMarshaller : IMarshaller<IRequest, UpdateSecurityProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSecurityProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSecurityProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PATCH";

            string uriResourcePath = "/security-profiles/{securityProfileName}";
            if (!publicRequest.IsSetSecurityProfileName())
                throw new AmazonIoTException("Request object does not have required field SecurityProfileName set");
            uriResourcePath = uriResourcePath.Replace("{securityProfileName}", StringUtils.FromStringWithSlashEncoding(publicRequest.SecurityProfileName));
            
            if (publicRequest.IsSetExpectedVersion())
                request.Parameters.Add("expectedVersion", StringUtils.FromLong(publicRequest.ExpectedVersion));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlertTargets())
                {
                    context.Writer.WritePropertyName("alertTargets");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAlertTargetsKvp in publicRequest.AlertTargets)
                    {
                        context.Writer.WritePropertyName(publicRequestAlertTargetsKvp.Key);
                        var publicRequestAlertTargetsValue = publicRequestAlertTargetsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = AlertTargetMarshaller.Instance;
                        marshaller.Marshall(publicRequestAlertTargetsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBehaviors())
                {
                    context.Writer.WritePropertyName("behaviors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBehaviorsListValue in publicRequest.Behaviors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BehaviorMarshaller.Instance;
                        marshaller.Marshall(publicRequestBehaviorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSecurityProfileDescription())
                {
                    context.Writer.WritePropertyName("securityProfileDescription");
                    context.Writer.Write(publicRequest.SecurityProfileDescription);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdateSecurityProfileRequestMarshaller _instance = new UpdateSecurityProfileRequestMarshaller();        

        internal static UpdateSecurityProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSecurityProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}