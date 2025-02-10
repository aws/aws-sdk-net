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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
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
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIAMPolicyAssignment Request Marshaller
    /// </summary>       
    public class CreateIAMPolicyAssignmentRequestMarshaller : IMarshaller<IRequest, CreateIAMPolicyAssignmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIAMPolicyAssignmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIAMPolicyAssignmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetNamespace())
                throw new AmazonQuickSightException("Request object does not have required field Namespace set");
            request.AddPathResource("{Namespace}", StringUtils.FromString(publicRequest.Namespace));
            request.ResourcePath = "/accounts/{AwsAccountId}/namespaces/{Namespace}/iam-policy-assignments/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssignmentName())
            {
                context.Writer.WritePropertyName("AssignmentName");
                context.Writer.WriteStringValue(publicRequest.AssignmentName);
            }

            if(publicRequest.IsSetAssignmentStatus())
            {
                context.Writer.WritePropertyName("AssignmentStatus");
                context.Writer.WriteStringValue(publicRequest.AssignmentStatus);
            }

            if(publicRequest.IsSetIdentities())
            {
                context.Writer.WritePropertyName("Identities");
                context.Writer.WriteStartObject();
                foreach (var publicRequestIdentitiesKvp in publicRequest.Identities)
                {
                    context.Writer.WritePropertyName(publicRequestIdentitiesKvp.Key);
                    var publicRequestIdentitiesValue = publicRequestIdentitiesKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestIdentitiesValueListValue in publicRequestIdentitiesValue)
                    {
                            context.Writer.WriteStringValue(publicRequestIdentitiesValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPolicyArn())
            {
                context.Writer.WritePropertyName("PolicyArn");
                context.Writer.WriteStringValue(publicRequest.PolicyArn);
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
        private static CreateIAMPolicyAssignmentRequestMarshaller _instance = new CreateIAMPolicyAssignmentRequestMarshaller();        

        internal static CreateIAMPolicyAssignmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIAMPolicyAssignmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}