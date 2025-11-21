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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityIR.Model;
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
namespace Amazon.SecurityIR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMembership Request Marshaller
    /// </summary>       
    public class UpdateMembershipRequestMarshaller : IMarshaller<IRequest, UpdateMembershipRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMembershipRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMembershipRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityIR");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetMembershipId())
                throw new AmazonSecurityIRException("Request object does not have required field MembershipId set");
            request.AddPathResource("{membershipId}", StringUtils.FromString(publicRequest.MembershipId));
            request.ResourcePath = "/v1/membership/{membershipId}/update-membership";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetIncidentResponseTeam())
            {
                context.Writer.WritePropertyName("incidentResponseTeam");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIncidentResponseTeamListValue in publicRequest.IncidentResponseTeam)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IncidentResponderMarshaller.Instance;
                    marshaller.Marshall(publicRequestIncidentResponseTeamListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMembershipAccountsConfigurationsUpdate())
            {
                context.Writer.WritePropertyName("membershipAccountsConfigurationsUpdate");
                context.Writer.WriteStartObject();

                var marshaller = MembershipAccountsConfigurationsUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.MembershipAccountsConfigurationsUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMembershipName())
            {
                context.Writer.WritePropertyName("membershipName");
                context.Writer.WriteStringValue(publicRequest.MembershipName);
            }

            if(publicRequest.IsSetOptInFeatures())
            {
                context.Writer.WritePropertyName("optInFeatures");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOptInFeaturesListValue in publicRequest.OptInFeatures)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OptInFeatureMarshaller.Instance;
                    marshaller.Marshall(publicRequestOptInFeaturesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUndoMembershipCancellation())
            {
                context.Writer.WritePropertyName("undoMembershipCancellation");
                context.Writer.WriteBooleanValue(publicRequest.UndoMembershipCancellation.Value);
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
        private static UpdateMembershipRequestMarshaller _instance = new UpdateMembershipRequestMarshaller();        

        internal static UpdateMembershipRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMembershipRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}