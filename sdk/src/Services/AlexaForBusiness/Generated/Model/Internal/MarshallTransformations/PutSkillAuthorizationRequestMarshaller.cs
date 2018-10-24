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
    /// PutSkillAuthorization Request Marshaller
    /// </summary>       
    public class PutSkillAuthorizationRequestMarshaller : IMarshaller<IRequest, PutSkillAuthorizationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSkillAuthorizationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSkillAuthorizationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AlexaForBusiness");
            string target = "AlexaForBusiness.PutSkillAuthorization";
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
                if(publicRequest.IsSetAuthorizationResult())
                {
                    context.Writer.WritePropertyName("AuthorizationResult");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAuthorizationResultKvp in publicRequest.AuthorizationResult)
                    {
                        context.Writer.WritePropertyName(publicRequestAuthorizationResultKvp.Key);
                        var publicRequestAuthorizationResultValue = publicRequestAuthorizationResultKvp.Value;

                            context.Writer.Write(publicRequestAuthorizationResultValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoomArn())
                {
                    context.Writer.WritePropertyName("RoomArn");
                    context.Writer.Write(publicRequest.RoomArn);
                }

                if(publicRequest.IsSetSkillId())
                {
                    context.Writer.WritePropertyName("SkillId");
                    context.Writer.Write(publicRequest.SkillId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutSkillAuthorizationRequestMarshaller _instance = new PutSkillAuthorizationRequestMarshaller();        

        internal static PutSkillAuthorizationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSkillAuthorizationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}