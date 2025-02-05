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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
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
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStack Request Marshaller
    /// </summary>       
    public class UpdateStackRequestMarshaller : IMarshaller<IRequest, UpdateStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStackRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.UpdateStack";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-02-18";
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
            if(publicRequest.IsSetAgentVersion())
            {
                context.Writer.WritePropertyName("AgentVersion");
                context.Writer.WriteStringValue(publicRequest.AgentVersion);
            }

            if(publicRequest.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                {
                    context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                    var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetChefConfiguration())
            {
                context.Writer.WritePropertyName("ChefConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ChefConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ChefConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConfigurationManager())
            {
                context.Writer.WritePropertyName("ConfigurationManager");
                context.Writer.WriteStartObject();

                var marshaller = StackConfigurationManagerMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConfigurationManager, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCustomCookbooksSource())
            {
                context.Writer.WritePropertyName("CustomCookbooksSource");
                context.Writer.WriteStartObject();

                var marshaller = SourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomCookbooksSource, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCustomJson())
            {
                context.Writer.WritePropertyName("CustomJson");
                context.Writer.WriteStringValue(publicRequest.CustomJson);
            }

            if(publicRequest.IsSetDefaultAvailabilityZone())
            {
                context.Writer.WritePropertyName("DefaultAvailabilityZone");
                context.Writer.WriteStringValue(publicRequest.DefaultAvailabilityZone);
            }

            if(publicRequest.IsSetDefaultInstanceProfileArn())
            {
                context.Writer.WritePropertyName("DefaultInstanceProfileArn");
                context.Writer.WriteStringValue(publicRequest.DefaultInstanceProfileArn);
            }

            if(publicRequest.IsSetDefaultOs())
            {
                context.Writer.WritePropertyName("DefaultOs");
                context.Writer.WriteStringValue(publicRequest.DefaultOs);
            }

            if(publicRequest.IsSetDefaultRootDeviceType())
            {
                context.Writer.WritePropertyName("DefaultRootDeviceType");
                context.Writer.WriteStringValue(publicRequest.DefaultRootDeviceType);
            }

            if(publicRequest.IsSetDefaultSshKeyName())
            {
                context.Writer.WritePropertyName("DefaultSshKeyName");
                context.Writer.WriteStringValue(publicRequest.DefaultSshKeyName);
            }

            if(publicRequest.IsSetDefaultSubnetId())
            {
                context.Writer.WritePropertyName("DefaultSubnetId");
                context.Writer.WriteStringValue(publicRequest.DefaultSubnetId);
            }

            if(publicRequest.IsSetHostnameTheme())
            {
                context.Writer.WritePropertyName("HostnameTheme");
                context.Writer.WriteStringValue(publicRequest.HostnameTheme);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetServiceRoleArn())
            {
                context.Writer.WritePropertyName("ServiceRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceRoleArn);
            }

            if(publicRequest.IsSetStackId())
            {
                context.Writer.WritePropertyName("StackId");
                context.Writer.WriteStringValue(publicRequest.StackId);
            }

            if(publicRequest.IsSetUseCustomCookbooks())
            {
                context.Writer.WritePropertyName("UseCustomCookbooks");
                context.Writer.WriteBooleanValue(publicRequest.UseCustomCookbooks.Value);
            }

            if(publicRequest.IsSetUseOpsworksSecurityGroups())
            {
                context.Writer.WritePropertyName("UseOpsworksSecurityGroups");
                context.Writer.WriteBooleanValue(publicRequest.UseOpsworksSecurityGroups.Value);
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
        private static UpdateStackRequestMarshaller _instance = new UpdateStackRequestMarshaller();        

        internal static UpdateStackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}