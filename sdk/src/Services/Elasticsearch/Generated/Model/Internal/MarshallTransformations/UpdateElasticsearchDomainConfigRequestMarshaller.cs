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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Elasticsearch.Model;
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
namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateElasticsearchDomainConfig Request Marshaller
    /// </summary>       
    public class UpdateElasticsearchDomainConfigRequestMarshaller : IMarshaller<IRequest, UpdateElasticsearchDomainConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateElasticsearchDomainConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateElasticsearchDomainConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Elasticsearch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-01-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonElasticsearchException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/2015-01-01/es/domain/{DomainName}/config";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessPolicies())
            {
                context.Writer.WritePropertyName("AccessPolicies");
                context.Writer.WriteStringValue(publicRequest.AccessPolicies);
            }

            if(publicRequest.IsSetAdvancedOptions())
            {
                context.Writer.WritePropertyName("AdvancedOptions");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAdvancedOptionsKvp in publicRequest.AdvancedOptions)
                {
                    context.Writer.WritePropertyName(publicRequestAdvancedOptionsKvp.Key);
                    var publicRequestAdvancedOptionsValue = publicRequestAdvancedOptionsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAdvancedOptionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAdvancedSecurityOptions())
            {
                context.Writer.WritePropertyName("AdvancedSecurityOptions");
                context.Writer.WriteStartObject();

                var marshaller = AdvancedSecurityOptionsInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.AdvancedSecurityOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoTuneOptions())
            {
                context.Writer.WritePropertyName("AutoTuneOptions");
                context.Writer.WriteStartObject();

                var marshaller = AutoTuneOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoTuneOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCognitoOptions())
            {
                context.Writer.WritePropertyName("CognitoOptions");
                context.Writer.WriteStartObject();

                var marshaller = CognitoOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.CognitoOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDomainEndpointOptions())
            {
                context.Writer.WritePropertyName("DomainEndpointOptions");
                context.Writer.WriteStartObject();

                var marshaller = DomainEndpointOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DomainEndpointOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("DryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }

            if(publicRequest.IsSetEBSOptions())
            {
                context.Writer.WritePropertyName("EBSOptions");
                context.Writer.WriteStartObject();

                var marshaller = EBSOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.EBSOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetElasticsearchClusterConfig())
            {
                context.Writer.WritePropertyName("ElasticsearchClusterConfig");
                context.Writer.WriteStartObject();

                var marshaller = ElasticsearchClusterConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ElasticsearchClusterConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEncryptionAtRestOptions())
            {
                context.Writer.WritePropertyName("EncryptionAtRestOptions");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionAtRestOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionAtRestOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLogPublishingOptions())
            {
                context.Writer.WritePropertyName("LogPublishingOptions");
                context.Writer.WriteStartObject();
                foreach (var publicRequestLogPublishingOptionsKvp in publicRequest.LogPublishingOptions)
                {
                    context.Writer.WritePropertyName(publicRequestLogPublishingOptionsKvp.Key);
                    var publicRequestLogPublishingOptionsValue = publicRequestLogPublishingOptionsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = LogPublishingOptionMarshaller.Instance;
                    marshaller.Marshall(publicRequestLogPublishingOptionsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNodeToNodeEncryptionOptions())
            {
                context.Writer.WritePropertyName("NodeToNodeEncryptionOptions");
                context.Writer.WriteStartObject();

                var marshaller = NodeToNodeEncryptionOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.NodeToNodeEncryptionOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSnapshotOptions())
            {
                context.Writer.WritePropertyName("SnapshotOptions");
                context.Writer.WriteStartObject();

                var marshaller = SnapshotOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.SnapshotOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVPCOptions())
            {
                context.Writer.WritePropertyName("VPCOptions");
                context.Writer.WriteStartObject();

                var marshaller = VPCOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.VPCOptions, context);

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
        private static UpdateElasticsearchDomainConfigRequestMarshaller _instance = new UpdateElasticsearchDomainConfigRequestMarshaller();        

        internal static UpdateElasticsearchDomainConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateElasticsearchDomainConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}