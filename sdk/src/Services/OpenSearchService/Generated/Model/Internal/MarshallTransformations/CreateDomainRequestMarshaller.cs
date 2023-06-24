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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDomain Request Marshaller
    /// </summary>       
    public class CreateDomainRequestMarshaller : IMarshaller<IRequest, CreateDomainRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDomainRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDomainRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2021-01-01/opensearch/domain";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessPolicies())
                {
                    context.Writer.WritePropertyName("AccessPolicies");
                    context.Writer.Write(publicRequest.AccessPolicies);
                }

                if(publicRequest.IsSetAdvancedOptions())
                {
                    context.Writer.WritePropertyName("AdvancedOptions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAdvancedOptionsKvp in publicRequest.AdvancedOptions)
                    {
                        context.Writer.WritePropertyName(publicRequestAdvancedOptionsKvp.Key);
                        var publicRequestAdvancedOptionsValue = publicRequestAdvancedOptionsKvp.Value;

                            context.Writer.Write(publicRequestAdvancedOptionsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAdvancedSecurityOptions())
                {
                    context.Writer.WritePropertyName("AdvancedSecurityOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = AdvancedSecurityOptionsInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AdvancedSecurityOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoTuneOptions())
                {
                    context.Writer.WritePropertyName("AutoTuneOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoTuneOptionsInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoTuneOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClusterConfig())
                {
                    context.Writer.WritePropertyName("ClusterConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ClusterConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ClusterConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCognitoOptions())
                {
                    context.Writer.WritePropertyName("CognitoOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = CognitoOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CognitoOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDomainEndpointOptions())
                {
                    context.Writer.WritePropertyName("DomainEndpointOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = DomainEndpointOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DomainEndpointOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDomainName())
                {
                    context.Writer.WritePropertyName("DomainName");
                    context.Writer.Write(publicRequest.DomainName);
                }

                if(publicRequest.IsSetEBSOptions())
                {
                    context.Writer.WritePropertyName("EBSOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = EBSOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EBSOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEncryptionAtRestOptions())
                {
                    context.Writer.WritePropertyName("EncryptionAtRestOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionAtRestOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionAtRestOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("EngineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetLogPublishingOptions())
                {
                    context.Writer.WritePropertyName("LogPublishingOptions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestLogPublishingOptionsKvp in publicRequest.LogPublishingOptions)
                    {
                        context.Writer.WritePropertyName(publicRequestLogPublishingOptionsKvp.Key);
                        var publicRequestLogPublishingOptionsValue = publicRequestLogPublishingOptionsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = LogPublishingOptionMarshaller.Instance;
                        marshaller.Marshall(publicRequestLogPublishingOptionsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNodeToNodeEncryptionOptions())
                {
                    context.Writer.WritePropertyName("NodeToNodeEncryptionOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = NodeToNodeEncryptionOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NodeToNodeEncryptionOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOffPeakWindowOptions())
                {
                    context.Writer.WritePropertyName("OffPeakWindowOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = OffPeakWindowOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OffPeakWindowOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSnapshotOptions())
                {
                    context.Writer.WritePropertyName("SnapshotOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = SnapshotOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SnapshotOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSoftwareUpdateOptions())
                {
                    context.Writer.WritePropertyName("SoftwareUpdateOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = SoftwareUpdateOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SoftwareUpdateOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTagList())
                {
                    context.Writer.WritePropertyName("TagList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagListListValue in publicRequest.TagList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVPCOptions())
                {
                    context.Writer.WritePropertyName("VPCOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = VPCOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VPCOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDomainRequestMarshaller _instance = new CreateDomainRequestMarshaller();        

        internal static CreateDomainRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDomainRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}