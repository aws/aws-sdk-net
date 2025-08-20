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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
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
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAddon Request Marshaller
    /// </summary>       
    public class CreateAddonRequestMarshaller : IMarshaller<IRequest, CreateAddonRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAddonRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAddonRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClusterName())
                throw new AmazonEKSException("Request object does not have required field ClusterName set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.ClusterName));
            request.ResourcePath = "/clusters/{name}/addons";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAddonName())
            {
                context.Writer.WritePropertyName("addonName");
                context.Writer.WriteStringValue(publicRequest.AddonName);
            }

            if(publicRequest.IsSetAddonVersion())
            {
                context.Writer.WritePropertyName("addonVersion");
                context.Writer.WriteStringValue(publicRequest.AddonVersion);
            }

            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConfigurationValues())
            {
                context.Writer.WritePropertyName("configurationValues");
                context.Writer.WriteStringValue(publicRequest.ConfigurationValues);
            }

            if(publicRequest.IsSetNamespaceConfig())
            {
                context.Writer.WritePropertyName("namespaceConfig");
                context.Writer.WriteStartObject();

                var marshaller = AddonNamespaceConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.NamespaceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPodIdentityAssociations())
            {
                context.Writer.WritePropertyName("podIdentityAssociations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPodIdentityAssociationsListValue in publicRequest.PodIdentityAssociations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AddonPodIdentityAssociationsMarshaller.Instance;
                    marshaller.Marshall(publicRequestPodIdentityAssociationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResolveConflicts())
            {
                context.Writer.WritePropertyName("resolveConflicts");
                context.Writer.WriteStringValue(publicRequest.ResolveConflicts);
            }

            if(publicRequest.IsSetServiceAccountRoleArn())
            {
                context.Writer.WritePropertyName("serviceAccountRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceAccountRoleArn);
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
        private static CreateAddonRequestMarshaller _instance = new CreateAddonRequestMarshaller();        

        internal static CreateAddonRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAddonRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}