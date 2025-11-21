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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNotebookInstance Request Marshaller
    /// </summary>       
    public class CreateNotebookInstanceRequestMarshaller : IMarshaller<IRequest, CreateNotebookInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNotebookInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNotebookInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateNotebookInstance";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
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
            if(publicRequest.IsSetAcceleratorTypes())
            {
                context.Writer.WritePropertyName("AcceleratorTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAcceleratorTypesListValue in publicRequest.AcceleratorTypes)
                {
                        context.Writer.WriteStringValue(publicRequestAcceleratorTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAdditionalCodeRepositories())
            {
                context.Writer.WritePropertyName("AdditionalCodeRepositories");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalCodeRepositoriesListValue in publicRequest.AdditionalCodeRepositories)
                {
                        context.Writer.WriteStringValue(publicRequestAdditionalCodeRepositoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDefaultCodeRepository())
            {
                context.Writer.WritePropertyName("DefaultCodeRepository");
                context.Writer.WriteStringValue(publicRequest.DefaultCodeRepository);
            }

            if(publicRequest.IsSetDirectInternetAccess())
            {
                context.Writer.WritePropertyName("DirectInternetAccess");
                context.Writer.WriteStringValue(publicRequest.DirectInternetAccess);
            }

            if(publicRequest.IsSetInstanceMetadataServiceConfiguration())
            {
                context.Writer.WritePropertyName("InstanceMetadataServiceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = InstanceMetadataServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InstanceMetadataServiceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(publicRequest.InstanceType);
            }

            if(publicRequest.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("IpAddressType");
                context.Writer.WriteStringValue(publicRequest.IpAddressType);
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetLifecycleConfigName())
            {
                context.Writer.WritePropertyName("LifecycleConfigName");
                context.Writer.WriteStringValue(publicRequest.LifecycleConfigName);
            }

            if(publicRequest.IsSetNotebookInstanceName())
            {
                context.Writer.WritePropertyName("NotebookInstanceName");
                context.Writer.WriteStringValue(publicRequest.NotebookInstanceName);
            }

            if(publicRequest.IsSetPlatformIdentifier())
            {
                context.Writer.WritePropertyName("PlatformIdentifier");
                context.Writer.WriteStringValue(publicRequest.PlatformIdentifier);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetRootAccess())
            {
                context.Writer.WritePropertyName("RootAccess");
                context.Writer.WriteStringValue(publicRequest.RootAccess);
            }

            if(publicRequest.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("SecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(publicRequest.SubnetId);
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

            if(publicRequest.IsSetVolumeSizeInGB())
            {
                context.Writer.WritePropertyName("VolumeSizeInGB");
                context.Writer.WriteNumberValue(publicRequest.VolumeSizeInGB.Value);
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
        private static CreateNotebookInstanceRequestMarshaller _instance = new CreateNotebookInstanceRequestMarshaller();        

        internal static CreateNotebookInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNotebookInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}