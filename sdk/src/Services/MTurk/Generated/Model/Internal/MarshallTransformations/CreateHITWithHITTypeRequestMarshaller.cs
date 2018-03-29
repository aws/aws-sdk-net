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
    /// CreateHITWithHITType Request Marshaller
    /// </summary>       
    public class CreateHITWithHITTypeRequestMarshaller : IMarshaller<IRequest, CreateHITWithHITTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateHITWithHITTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateHITWithHITTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MTurk");
            string target = "MTurkRequesterServiceV20170117.CreateHITWithHITType";
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
                if(publicRequest.IsSetAssignmentReviewPolicy())
                {
                    context.Writer.WritePropertyName("AssignmentReviewPolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReviewPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AssignmentReviewPolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHITLayoutId())
                {
                    context.Writer.WritePropertyName("HITLayoutId");
                    context.Writer.Write(publicRequest.HITLayoutId);
                }

                if(publicRequest.IsSetHITLayoutParameters())
                {
                    context.Writer.WritePropertyName("HITLayoutParameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestHITLayoutParametersListValue in publicRequest.HITLayoutParameters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = HITLayoutParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestHITLayoutParametersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetHITReviewPolicy())
                {
                    context.Writer.WritePropertyName("HITReviewPolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReviewPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HITReviewPolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHITTypeId())
                {
                    context.Writer.WritePropertyName("HITTypeId");
                    context.Writer.Write(publicRequest.HITTypeId);
                }

                if(publicRequest.IsSetLifetimeInSeconds())
                {
                    context.Writer.WritePropertyName("LifetimeInSeconds");
                    context.Writer.Write(publicRequest.LifetimeInSeconds);
                }

                if(publicRequest.IsSetMaxAssignments())
                {
                    context.Writer.WritePropertyName("MaxAssignments");
                    context.Writer.Write(publicRequest.MaxAssignments);
                }

                if(publicRequest.IsSetQuestion())
                {
                    context.Writer.WritePropertyName("Question");
                    context.Writer.Write(publicRequest.Question);
                }

                if(publicRequest.IsSetRequesterAnnotation())
                {
                    context.Writer.WritePropertyName("RequesterAnnotation");
                    context.Writer.Write(publicRequest.RequesterAnnotation);
                }

                if(publicRequest.IsSetUniqueRequestToken())
                {
                    context.Writer.WritePropertyName("UniqueRequestToken");
                    context.Writer.Write(publicRequest.UniqueRequestToken);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateHITWithHITTypeRequestMarshaller _instance = new CreateHITWithHITTypeRequestMarshaller();        

        internal static CreateHITWithHITTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateHITWithHITTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}