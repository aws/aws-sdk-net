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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProfile Request Marshaller
    /// </summary>       
    public class UpdateProfileRequestMarshaller : IMarshaller<IRequest, UpdateProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AlexaForBusiness");
            string target = "AlexaForBusiness.UpdateProfile";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddress())
                {
                    context.Writer.WritePropertyName("Address");
                    context.Writer.Write(publicRequest.Address);
                }

                if(publicRequest.IsSetDistanceUnit())
                {
                    context.Writer.WritePropertyName("DistanceUnit");
                    context.Writer.Write(publicRequest.DistanceUnit);
                }

                if(publicRequest.IsSetMaxVolumeLimit())
                {
                    context.Writer.WritePropertyName("MaxVolumeLimit");
                    context.Writer.Write(publicRequest.MaxVolumeLimit);
                }

                if(publicRequest.IsSetProfileArn())
                {
                    context.Writer.WritePropertyName("ProfileArn");
                    context.Writer.Write(publicRequest.ProfileArn);
                }

                if(publicRequest.IsSetProfileName())
                {
                    context.Writer.WritePropertyName("ProfileName");
                    context.Writer.Write(publicRequest.ProfileName);
                }

                if(publicRequest.IsSetPSTNEnabled())
                {
                    context.Writer.WritePropertyName("PSTNEnabled");
                    context.Writer.Write(publicRequest.PSTNEnabled);
                }

                if(publicRequest.IsSetSetupModeDisabled())
                {
                    context.Writer.WritePropertyName("SetupModeDisabled");
                    context.Writer.Write(publicRequest.SetupModeDisabled);
                }

                if(publicRequest.IsSetTemperatureUnit())
                {
                    context.Writer.WritePropertyName("TemperatureUnit");
                    context.Writer.Write(publicRequest.TemperatureUnit);
                }

                if(publicRequest.IsSetTimezone())
                {
                    context.Writer.WritePropertyName("Timezone");
                    context.Writer.Write(publicRequest.Timezone);
                }

                if(publicRequest.IsSetWakeWord())
                {
                    context.Writer.WritePropertyName("WakeWord");
                    context.Writer.Write(publicRequest.WakeWord);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateProfileRequestMarshaller _instance = new UpdateProfileRequestMarshaller();        

        internal static UpdateProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}