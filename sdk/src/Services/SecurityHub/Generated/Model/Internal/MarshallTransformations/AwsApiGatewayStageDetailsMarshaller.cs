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
    /// AwsApiGatewayStageDetails Marshaller
    /// </summary>
    public class AwsApiGatewayStageDetailsMarshaller : IRequestMarshaller<AwsApiGatewayStageDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsApiGatewayStageDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessLogSettings())
            {
                context.Writer.WritePropertyName("AccessLogSettings");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiGatewayAccessLogSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessLogSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCacheClusterEnabled())
            {
                context.Writer.WritePropertyName("CacheClusterEnabled");
                context.Writer.WriteBooleanValue(requestObject.CacheClusterEnabled.Value);
            }

            if(requestObject.IsSetCacheClusterSize())
            {
                context.Writer.WritePropertyName("CacheClusterSize");
                context.Writer.WriteStringValue(requestObject.CacheClusterSize);
            }

            if(requestObject.IsSetCacheClusterStatus())
            {
                context.Writer.WritePropertyName("CacheClusterStatus");
                context.Writer.WriteStringValue(requestObject.CacheClusterStatus);
            }

            if(requestObject.IsSetCanarySettings())
            {
                context.Writer.WritePropertyName("CanarySettings");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiGatewayCanarySettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CanarySettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClientCertificateId())
            {
                context.Writer.WritePropertyName("ClientCertificateId");
                context.Writer.WriteStringValue(requestObject.ClientCertificateId);
            }

            if(requestObject.IsSetCreatedDate())
            {
                context.Writer.WritePropertyName("CreatedDate");
                context.Writer.WriteStringValue(requestObject.CreatedDate);
            }

            if(requestObject.IsSetDeploymentId())
            {
                context.Writer.WritePropertyName("DeploymentId");
                context.Writer.WriteStringValue(requestObject.DeploymentId);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDocumentationVersion())
            {
                context.Writer.WritePropertyName("DocumentationVersion");
                context.Writer.WriteStringValue(requestObject.DocumentationVersion);
            }

            if(requestObject.IsSetLastUpdatedDate())
            {
                context.Writer.WritePropertyName("LastUpdatedDate");
                context.Writer.WriteStringValue(requestObject.LastUpdatedDate);
            }

            if(requestObject.IsSetMethodSettings())
            {
                context.Writer.WritePropertyName("MethodSettings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMethodSettingsListValue in requestObject.MethodSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsApiGatewayMethodSettingsMarshaller.Instance;
                    marshaller.Marshall(requestObjectMethodSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStageName())
            {
                context.Writer.WritePropertyName("StageName");
                context.Writer.WriteStringValue(requestObject.StageName);
            }

            if(requestObject.IsSetTracingEnabled())
            {
                context.Writer.WritePropertyName("TracingEnabled");
                context.Writer.WriteBooleanValue(requestObject.TracingEnabled.Value);
            }

            if(requestObject.IsSetVariables())
            {
                context.Writer.WritePropertyName("Variables");
                context.Writer.WriteStartObject();
                foreach (var requestObjectVariablesKvp in requestObject.Variables)
                {
                    context.Writer.WritePropertyName(requestObjectVariablesKvp.Key);
                    var requestObjectVariablesValue = requestObjectVariablesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWebAclArn())
            {
                context.Writer.WritePropertyName("WebAclArn");
                context.Writer.WriteStringValue(requestObject.WebAclArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsApiGatewayStageDetailsMarshaller Instance = new AwsApiGatewayStageDetailsMarshaller();

    }
}