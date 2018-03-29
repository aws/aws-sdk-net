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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MTurk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendBonus Request Marshaller
    /// </summary>       
    public class SendBonusRequestMarshaller : IMarshaller<IRequest, SendBonusRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendBonusRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendBonusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MTurk");
            string target = "MTurkRequesterServiceV20170117.SendBonus";
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
                if(publicRequest.IsSetAssignmentId())
                {
                    context.Writer.WritePropertyName("AssignmentId");
                    context.Writer.Write(publicRequest.AssignmentId);
                }

                if(publicRequest.IsSetBonusAmount())
                {
                    context.Writer.WritePropertyName("BonusAmount");
                    context.Writer.Write(publicRequest.BonusAmount);
                }

                if(publicRequest.IsSetReason())
                {
                    context.Writer.WritePropertyName("Reason");
                    context.Writer.Write(publicRequest.Reason);
                }

                if(publicRequest.IsSetUniqueRequestToken())
                {
                    context.Writer.WritePropertyName("UniqueRequestToken");
                    context.Writer.Write(publicRequest.UniqueRequestToken);
                }

                if(publicRequest.IsSetWorkerId())
                {
                    context.Writer.WritePropertyName("WorkerId");
                    context.Writer.Write(publicRequest.WorkerId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendBonusRequestMarshaller _instance = new SendBonusRequestMarshaller();        

        internal static SendBonusRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendBonusRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}