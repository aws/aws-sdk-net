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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStudio Request Marshaller
    /// </summary>       
    public class CreateStudioRequestMarshaller : IMarshaller<IRequest, CreateStudioRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStudioRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStudioRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.CreateStudio";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2009-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthMode())
            {
                context.Writer.WritePropertyName("AuthMode");
                context.Writer.WriteStringValue(publicRequest.AuthMode);
            }

            if(publicRequest.IsSetDefaultS3Location())
            {
                context.Writer.WritePropertyName("DefaultS3Location");
                context.Writer.WriteStringValue(publicRequest.DefaultS3Location);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("EncryptionKeyArn");
                context.Writer.WriteStringValue(publicRequest.EncryptionKeyArn);
            }

            if(publicRequest.IsSetEngineSecurityGroupId())
            {
                context.Writer.WritePropertyName("EngineSecurityGroupId");
                context.Writer.WriteStringValue(publicRequest.EngineSecurityGroupId);
            }

            if(publicRequest.IsSetIdcInstanceArn())
            {
                context.Writer.WritePropertyName("IdcInstanceArn");
                context.Writer.WriteStringValue(publicRequest.IdcInstanceArn);
            }

            if(publicRequest.IsSetIdcUserAssignment())
            {
                context.Writer.WritePropertyName("IdcUserAssignment");
                context.Writer.WriteStringValue(publicRequest.IdcUserAssignment);
            }

            if(publicRequest.IsSetIdpAuthUrl())
            {
                context.Writer.WritePropertyName("IdpAuthUrl");
                context.Writer.WriteStringValue(publicRequest.IdpAuthUrl);
            }

            if(publicRequest.IsSetIdpRelayStateParameterName())
            {
                context.Writer.WritePropertyName("IdpRelayStateParameterName");
                context.Writer.WriteStringValue(publicRequest.IdpRelayStateParameterName);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetServiceRole())
            {
                context.Writer.WritePropertyName("ServiceRole");
                context.Writer.WriteStringValue(publicRequest.ServiceRole);
            }

            if(publicRequest.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("SubnetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                {
                        context.Writer.WriteStringValue(publicRequestSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTrustedIdentityPropagationEnabled())
            {
                context.Writer.WritePropertyName("TrustedIdentityPropagationEnabled");
                context.Writer.WriteBooleanValue(publicRequest.TrustedIdentityPropagationEnabled.Value);
            }

            if(publicRequest.IsSetUserRole())
            {
                context.Writer.WritePropertyName("UserRole");
                context.Writer.WriteStringValue(publicRequest.UserRole);
            }

            if(publicRequest.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.WriteStringValue(publicRequest.VpcId);
            }

            if(publicRequest.IsSetWorkspaceSecurityGroupId())
            {
                context.Writer.WritePropertyName("WorkspaceSecurityGroupId");
                context.Writer.WriteStringValue(publicRequest.WorkspaceSecurityGroupId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETCOREAPP3_1_OR_GREATER
            request.Content = arrayBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateStudioRequestMarshaller _instance = new CreateStudioRequestMarshaller();        

        internal static CreateStudioRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStudioRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}