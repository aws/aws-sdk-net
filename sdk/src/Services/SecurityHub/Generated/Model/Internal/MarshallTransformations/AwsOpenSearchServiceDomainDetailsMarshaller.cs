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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessPolicies())
            {
                context.Writer.WritePropertyName("AccessPolicies");
                context.Writer.WriteStringValue(requestObject.AccessPolicies);
            }

            if(requestObject.IsSetAdvancedSecurityOptions())
            {
                context.Writer.WritePropertyName("AdvancedSecurityOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AdvancedSecurityOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetClusterConfig())
            {
                context.Writer.WritePropertyName("ClusterConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainClusterConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClusterConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDomainEndpoint())
            {
                context.Writer.WritePropertyName("DomainEndpoint");
                context.Writer.WriteStringValue(requestObject.DomainEndpoint);
            }

            if(requestObject.IsSetDomainEndpointOptions())
            {
                context.Writer.WritePropertyName("DomainEndpointOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainDomainEndpointOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DomainEndpointOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDomainEndpoints())
            {
                context.Writer.WritePropertyName("DomainEndpoints");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDomainEndpointsKvp in requestObject.DomainEndpoints)
                {
                    context.Writer.WritePropertyName(requestObjectDomainEndpointsKvp.Key);
                    var requestObjectDomainEndpointsValue = requestObjectDomainEndpointsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDomainEndpointsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.WriteStringValue(requestObject.DomainName);
            }

            if(requestObject.IsSetEncryptionAtRestOptions())
            {
                context.Writer.WritePropertyName("EncryptionAtRestOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainEncryptionAtRestOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionAtRestOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(requestObject.EngineVersion);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetLogPublishingOptions())
            {
                context.Writer.WritePropertyName("LogPublishingOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainLogPublishingOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LogPublishingOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNodeToNodeEncryptionOptions())
            {
                context.Writer.WritePropertyName("NodeToNodeEncryptionOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainNodeToNodeEncryptionOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.NodeToNodeEncryptionOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceSoftwareOptions())
            {
                context.Writer.WritePropertyName("ServiceSoftwareOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainServiceSoftwareOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceSoftwareOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcOptions())
            {
                context.Writer.WritePropertyName("VpcOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainVpcOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsOpenSearchServiceDomainDetailsMarshaller Instance = new AwsOpenSearchServiceDomainDetailsMarshaller();

    }
}