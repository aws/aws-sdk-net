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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePool Request Marshaller
    /// </summary>       
    public class UpdatePoolRequestMarshaller : IMarshaller<IRequest, UpdatePoolRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePoolRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.UpdatePool";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeletionProtectionEnabled())
                {
                    context.Writer.WritePropertyName("DeletionProtectionEnabled");
                    context.Writer.Write(publicRequest.DeletionProtectionEnabled);
                }

                if(publicRequest.IsSetOptOutListName())
                {
                    context.Writer.WritePropertyName("OptOutListName");
                    context.Writer.Write(publicRequest.OptOutListName);
                }

                if(publicRequest.IsSetPoolId())
                {
                    context.Writer.WritePropertyName("PoolId");
                    context.Writer.Write(publicRequest.PoolId);
                }

                if(publicRequest.IsSetSelfManagedOptOutsEnabled())
                {
                    context.Writer.WritePropertyName("SelfManagedOptOutsEnabled");
                    context.Writer.Write(publicRequest.SelfManagedOptOutsEnabled);
                }

                if(publicRequest.IsSetSharedRoutesEnabled())
                {
                    context.Writer.WritePropertyName("SharedRoutesEnabled");
                    context.Writer.Write(publicRequest.SharedRoutesEnabled);
                }

                if(publicRequest.IsSetTwoWayChannelArn())
                {
                    context.Writer.WritePropertyName("TwoWayChannelArn");
                    context.Writer.Write(publicRequest.TwoWayChannelArn);
                }

                if(publicRequest.IsSetTwoWayEnabled())
                {
                    context.Writer.WritePropertyName("TwoWayEnabled");
                    context.Writer.Write(publicRequest.TwoWayEnabled);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdatePoolRequestMarshaller _instance = new UpdatePoolRequestMarshaller();        

        internal static UpdatePoolRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePoolRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}