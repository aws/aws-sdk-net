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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
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
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApp Request Marshaller
    /// </summary>       
    public class CreateAppRequestMarshaller : IMarshaller<IRequest, CreateAppRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAppRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAppRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/create-app";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssessmentSchedule())
            {
                context.Writer.WritePropertyName("assessmentSchedule");
                context.Writer.WriteStringValue(publicRequest.AssessmentSchedule);
            }

            if(publicRequest.IsSetAwsApplicationArn())
            {
                context.Writer.WritePropertyName("awsApplicationArn");
                context.Writer.WriteStringValue(publicRequest.AwsApplicationArn);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEventSubscriptions())
            {
                context.Writer.WritePropertyName("eventSubscriptions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEventSubscriptionsListValue in publicRequest.EventSubscriptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EventSubscriptionMarshaller.Instance;
                    marshaller.Marshall(publicRequestEventSubscriptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPermissionModel())
            {
                context.Writer.WritePropertyName("permissionModel");
                context.Writer.WriteStartObject();

                var marshaller = PermissionModelMarshaller.Instance;
                marshaller.Marshall(publicRequest.PermissionModel, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPolicyArn())
            {
                context.Writer.WritePropertyName("policyArn");
                context.Writer.WriteStringValue(publicRequest.PolicyArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
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
        private static CreateAppRequestMarshaller _instance = new CreateAppRequestMarshaller();        

        internal static CreateAppRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAppRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}