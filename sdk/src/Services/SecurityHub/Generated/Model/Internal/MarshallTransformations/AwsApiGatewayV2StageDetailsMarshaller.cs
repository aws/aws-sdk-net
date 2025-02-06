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
    /// AwsApiGatewayV2StageDetails Marshaller
    /// </summary>
    public class AwsApiGatewayV2StageDetailsMarshaller : IRequestMarshaller<AwsApiGatewayV2StageDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsApiGatewayV2StageDetails requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetApiGatewayManaged())
            {
                context.Writer.WritePropertyName("ApiGatewayManaged");
                context.Writer.WriteBooleanValue(requestObject.ApiGatewayManaged.Value);
            }

            if(requestObject.IsSetAutoDeploy())
            {
                context.Writer.WritePropertyName("AutoDeploy");
                context.Writer.WriteBooleanValue(requestObject.AutoDeploy.Value);
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

            if(requestObject.IsSetDefaultRouteSettings())
            {
                context.Writer.WritePropertyName("DefaultRouteSettings");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiGatewayV2RouteSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultRouteSettings, context);

                context.Writer.WriteEndObject();
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

            if(requestObject.IsSetLastDeploymentStatusMessage())
            {
                context.Writer.WritePropertyName("LastDeploymentStatusMessage");
                context.Writer.WriteStringValue(requestObject.LastDeploymentStatusMessage);
            }

            if(requestObject.IsSetLastUpdatedDate())
            {
                context.Writer.WritePropertyName("LastUpdatedDate");
                context.Writer.WriteStringValue(requestObject.LastUpdatedDate);
            }

            if(requestObject.IsSetRouteSettings())
            {
                context.Writer.WritePropertyName("RouteSettings");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiGatewayV2RouteSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RouteSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStageName())
            {
                context.Writer.WritePropertyName("StageName");
                context.Writer.WriteStringValue(requestObject.StageName);
            }

            if(requestObject.IsSetStageVariables())
            {
                context.Writer.WritePropertyName("StageVariables");
                context.Writer.WriteStartObject();
                foreach (var requestObjectStageVariablesKvp in requestObject.StageVariables)
                {
                    context.Writer.WritePropertyName(requestObjectStageVariablesKvp.Key);
                    var requestObjectStageVariablesValue = requestObjectStageVariablesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectStageVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsApiGatewayV2StageDetailsMarshaller Instance = new AwsApiGatewayV2StageDetailsMarshaller();

    }
}