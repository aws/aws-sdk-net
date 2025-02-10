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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
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
namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDeployment Request Marshaller
    /// </summary>       
    public class CreateDeploymentRequestMarshaller : IMarshaller<IRequest, CreateDeploymentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeploymentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GreengrassV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/greengrass/v2/deployments";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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
            if(publicRequest.IsSetComponents())
            {
                context.Writer.WritePropertyName("components");
                context.Writer.WriteStartObject();
                foreach (var publicRequestComponentsKvp in publicRequest.Components)
                {
                    context.Writer.WritePropertyName(publicRequestComponentsKvp.Key);
                    var publicRequestComponentsValue = publicRequestComponentsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentDeploymentSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequestComponentsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeploymentName())
            {
                context.Writer.WritePropertyName("deploymentName");
                context.Writer.WriteStringValue(publicRequest.DeploymentName);
            }

            if(publicRequest.IsSetDeploymentPolicies())
            {
                context.Writer.WritePropertyName("deploymentPolicies");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentPoliciesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentPolicies, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIotJobConfiguration())
            {
                context.Writer.WritePropertyName("iotJobConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentIoTJobConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.IotJobConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetParentTargetArn())
            {
                context.Writer.WritePropertyName("parentTargetArn");
                context.Writer.WriteStringValue(publicRequest.ParentTargetArn);
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

            if(publicRequest.IsSetTargetArn())
            {
                context.Writer.WritePropertyName("targetArn");
                context.Writer.WriteStringValue(publicRequest.TargetArn);
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
        private static CreateDeploymentRequestMarshaller _instance = new CreateDeploymentRequestMarshaller();        

        internal static CreateDeploymentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDeploymentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}