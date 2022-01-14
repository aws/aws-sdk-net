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
    /// AwsOpenSearchServiceDomainDetails Marshaller
    /// </summary>
    public class AwsOpenSearchServiceDomainDetailsMarshaller : IRequestMarshaller<AwsOpenSearchServiceDomainDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsOpenSearchServiceDomainDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessPolicies())
            {
                context.Writer.WritePropertyName("AccessPolicies");
                context.Writer.Write(requestObject.AccessPolicies);
            }

            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.Write(requestObject.Arn);
            }

            if(requestObject.IsSetClusterConfig())
            {
                context.Writer.WritePropertyName("ClusterConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainClusterConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClusterConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDomainEndpoint())
            {
                context.Writer.WritePropertyName("DomainEndpoint");
                context.Writer.Write(requestObject.DomainEndpoint);
            }

            if(requestObject.IsSetDomainEndpointOptions())
            {
                context.Writer.WritePropertyName("DomainEndpointOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainDomainEndpointOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DomainEndpointOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDomainEndpoints())
            {
                context.Writer.WritePropertyName("DomainEndpoints");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDomainEndpointsKvp in requestObject.DomainEndpoints)
                {
                    context.Writer.WritePropertyName(requestObjectDomainEndpointsKvp.Key);
                    var requestObjectDomainEndpointsValue = requestObjectDomainEndpointsKvp.Value;

                        context.Writer.Write(requestObjectDomainEndpointsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.Write(requestObject.DomainName);
            }

            if(requestObject.IsSetEncryptionAtRestOptions())
            {
                context.Writer.WritePropertyName("EncryptionAtRestOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainEncryptionAtRestOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionAtRestOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.Write(requestObject.EngineVersion);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetLogPublishingOptions())
            {
                context.Writer.WritePropertyName("LogPublishingOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainLogPublishingOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LogPublishingOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNodeToNodeEncryptionOptions())
            {
                context.Writer.WritePropertyName("NodeToNodeEncryptionOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainNodeToNodeEncryptionOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.NodeToNodeEncryptionOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServiceSoftwareOptions())
            {
                context.Writer.WritePropertyName("ServiceSoftwareOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainServiceSoftwareOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceSoftwareOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpcOptions())
            {
                context.Writer.WritePropertyName("VpcOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainVpcOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsOpenSearchServiceDomainDetailsMarshaller Instance = new AwsOpenSearchServiceDomainDetailsMarshaller();

    }
}