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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsElasticsearchDomainDetails Marshaller
    /// </summary>       
    public class AwsElasticsearchDomainDetailsMarshaller : IRequestMarshaller<AwsElasticsearchDomainDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsElasticsearchDomainDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessPolicies())
            {
                context.Writer.WritePropertyName("AccessPolicies");
                context.Writer.Write(requestObject.AccessPolicies);
            }

            if(requestObject.IsSetDomainEndpointOptions())
            {
                context.Writer.WritePropertyName("DomainEndpointOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticsearchDomainDomainEndpointOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DomainEndpointOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDomainId())
            {
                context.Writer.WritePropertyName("DomainId");
                context.Writer.Write(requestObject.DomainId);
            }

            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.Write(requestObject.DomainName);
            }

            if(requestObject.IsSetElasticsearchVersion())
            {
                context.Writer.WritePropertyName("ElasticsearchVersion");
                context.Writer.Write(requestObject.ElasticsearchVersion);
            }

            if(requestObject.IsSetEncryptionAtRestOptions())
            {
                context.Writer.WritePropertyName("EncryptionAtRestOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticsearchDomainEncryptionAtRestOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionAtRestOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("Endpoint");
                context.Writer.Write(requestObject.Endpoint);
            }

            if(requestObject.IsSetEndpoints())
            {
                context.Writer.WritePropertyName("Endpoints");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEndpointsKvp in requestObject.Endpoints)
                {
                    context.Writer.WritePropertyName(requestObjectEndpointsKvp.Key);
                    var requestObjectEndpointsValue = requestObjectEndpointsKvp.Value;

                        context.Writer.Write(requestObjectEndpointsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLogPublishingOptions())
            {
                context.Writer.WritePropertyName("LogPublishingOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticsearchDomainLogPublishingOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.LogPublishingOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNodeToNodeEncryptionOptions())
            {
                context.Writer.WritePropertyName("NodeToNodeEncryptionOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticsearchDomainNodeToNodeEncryptionOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.NodeToNodeEncryptionOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServiceSoftwareOptions())
            {
                context.Writer.WritePropertyName("ServiceSoftwareOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticsearchDomainServiceSoftwareOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceSoftwareOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVPCOptions())
            {
                context.Writer.WritePropertyName("VPCOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticsearchDomainVPCOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.VPCOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsElasticsearchDomainDetailsMarshaller Instance = new AwsElasticsearchDomainDetailsMarshaller();

    }
}