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
    /// UpdateQualificationType Request Marshaller
    /// </summary>       
    public class UpdateQualificationTypeRequestMarshaller : IMarshaller<IRequest, UpdateQualificationTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateQualificationTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateQualificationTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MTurk");
            string target = "MTurkRequesterServiceV20170117.UpdateQualificationType";
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
                if(publicRequest.IsSetAnswerKey())
                {
                    context.Writer.WritePropertyName("AnswerKey");
                    context.Writer.Write(publicRequest.AnswerKey);
                }

                if(publicRequest.IsSetAutoGranted())
                {
                    context.Writer.WritePropertyName("AutoGranted");
                    context.Writer.Write(publicRequest.AutoGranted);
                }

                if(publicRequest.IsSetAutoGrantedValue())
                {
                    context.Writer.WritePropertyName("AutoGrantedValue");
                    context.Writer.Write(publicRequest.AutoGrantedValue);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetQualificationTypeId())
                {
                    context.Writer.WritePropertyName("QualificationTypeId");
                    context.Writer.Write(publicRequest.QualificationTypeId);
                }

                if(publicRequest.IsSetQualificationTypeStatus())
                {
                    context.Writer.WritePropertyName("QualificationTypeStatus");
                    context.Writer.Write(publicRequest.QualificationTypeStatus);
                }

                if(publicRequest.IsSetRetryDelayInSeconds())
                {
                    context.Writer.WritePropertyName("RetryDelayInSeconds");
                    context.Writer.Write(publicRequest.RetryDelayInSeconds);
                }

                if(publicRequest.IsSetTest())
                {
                    context.Writer.WritePropertyName("Test");
                    context.Writer.Write(publicRequest.Test);
                }

                if(publicRequest.IsSetTestDurationInSeconds())
                {
                    context.Writer.WritePropertyName("TestDurationInSeconds");
                    context.Writer.Write(publicRequest.TestDurationInSeconds);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateQualificationTypeRequestMarshaller _instance = new UpdateQualificationTypeRequestMarshaller();        

        internal static UpdateQualificationTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateQualificationTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}