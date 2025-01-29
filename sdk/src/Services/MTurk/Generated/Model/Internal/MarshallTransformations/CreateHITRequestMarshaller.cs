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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateHIT Request Marshaller
    /// </summary>       
    public class CreateHITRequestMarshaller : IMarshaller<IRequest, CreateHITRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateHITRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateHITRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MTurk");
            string target = "MTurkRequesterServiceV20170117.CreateHIT";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssignmentDurationInSeconds())
            {
                context.Writer.WritePropertyName("AssignmentDurationInSeconds");
                context.Writer.WriteNumberValue(publicRequest.AssignmentDurationInSeconds.Value);
            }

            if(publicRequest.IsSetAssignmentReviewPolicy())
            {
                context.Writer.WritePropertyName("AssignmentReviewPolicy");
                context.Writer.WriteStartObject();

                var marshaller = ReviewPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.AssignmentReviewPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoApprovalDelayInSeconds())
            {
                context.Writer.WritePropertyName("AutoApprovalDelayInSeconds");
                context.Writer.WriteNumberValue(publicRequest.AutoApprovalDelayInSeconds.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetHITLayoutId())
            {
                context.Writer.WritePropertyName("HITLayoutId");
                context.Writer.WriteStringValue(publicRequest.HITLayoutId);
            }

            if(publicRequest.IsSetHITLayoutParameters())
            {
                context.Writer.WritePropertyName("HITLayoutParameters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestHITLayoutParametersListValue in publicRequest.HITLayoutParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HITLayoutParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestHITLayoutParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetHITReviewPolicy())
            {
                context.Writer.WritePropertyName("HITReviewPolicy");
                context.Writer.WriteStartObject();

                var marshaller = ReviewPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.HITReviewPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKeywords())
            {
                context.Writer.WritePropertyName("Keywords");
                context.Writer.WriteStringValue(publicRequest.Keywords);
            }

            if(publicRequest.IsSetLifetimeInSeconds())
            {
                context.Writer.WritePropertyName("LifetimeInSeconds");
                context.Writer.WriteNumberValue(publicRequest.LifetimeInSeconds.Value);
            }

            if(publicRequest.IsSetMaxAssignments())
            {
                context.Writer.WritePropertyName("MaxAssignments");
                context.Writer.WriteNumberValue(publicRequest.MaxAssignments.Value);
            }

            if(publicRequest.IsSetQualificationRequirements())
            {
                context.Writer.WritePropertyName("QualificationRequirements");
                context.Writer.WriteStartArray();
                foreach(var publicRequestQualificationRequirementsListValue in publicRequest.QualificationRequirements)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = QualificationRequirementMarshaller.Instance;
                    marshaller.Marshall(publicRequestQualificationRequirementsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetQuestion())
            {
                context.Writer.WritePropertyName("Question");
                context.Writer.WriteStringValue(publicRequest.Question);
            }

            if(publicRequest.IsSetRequesterAnnotation())
            {
                context.Writer.WritePropertyName("RequesterAnnotation");
                context.Writer.WriteStringValue(publicRequest.RequesterAnnotation);
            }

            if(publicRequest.IsSetReward())
            {
                context.Writer.WritePropertyName("Reward");
                context.Writer.WriteStringValue(publicRequest.Reward);
            }

            if(publicRequest.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(publicRequest.Title);
            }

            if(publicRequest.IsSetUniqueRequestToken())
            {
                context.Writer.WritePropertyName("UniqueRequestToken");
                context.Writer.WriteStringValue(publicRequest.UniqueRequestToken);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateHITRequestMarshaller _instance = new CreateHITRequestMarshaller();        

        internal static CreateHITRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateHITRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}