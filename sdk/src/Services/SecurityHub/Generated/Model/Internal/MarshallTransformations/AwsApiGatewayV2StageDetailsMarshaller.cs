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
            if(requestObject.IsSetAccessLogSettings())
            {
                context.Writer.WritePropertyName("AccessLogSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AwsApiGatewayAccessLogSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessLogSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetApiGatewayManaged())
            {
                context.Writer.WritePropertyName("ApiGatewayManaged");
                context.Writer.Write(requestObject.ApiGatewayManaged);
            }

            if(requestObject.IsSetAutoDeploy())
            {
                context.Writer.WritePropertyName("AutoDeploy");
                context.Writer.Write(requestObject.AutoDeploy);
            }

            if(requestObject.IsSetCreatedDate())
            {
                context.Writer.WritePropertyName("CreatedDate");
                context.Writer.Write(requestObject.CreatedDate);
            }

            if(requestObject.IsSetDefaultRouteSettings())
            {
                context.Writer.WritePropertyName("DefaultRouteSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AwsApiGatewayV2RouteSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultRouteSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeploymentId())
            {
                context.Writer.WritePropertyName("DeploymentId");
                context.Writer.Write(requestObject.DeploymentId);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetLastDeploymentStatusMessage())
            {
                context.Writer.WritePropertyName("LastDeploymentStatusMessage");
                context.Writer.Write(requestObject.LastDeploymentStatusMessage);
            }

            if(requestObject.IsSetLastUpdatedDate())
            {
                context.Writer.WritePropertyName("LastUpdatedDate");
                context.Writer.Write(requestObject.LastUpdatedDate);
            }

            if(requestObject.IsSetRouteSettings())
            {
                context.Writer.WritePropertyName("RouteSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AwsApiGatewayV2RouteSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RouteSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStageName())
            {
                context.Writer.WritePropertyName("StageName");
                context.Writer.Write(requestObject.StageName);
            }

            if(requestObject.IsSetStageVariables())
            {
                context.Writer.WritePropertyName("StageVariables");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectStageVariablesKvp in requestObject.StageVariables)
                {
                    context.Writer.WritePropertyName(requestObjectStageVariablesKvp.Key);
                    var requestObjectStageVariablesValue = requestObjectStageVariablesKvp.Value;

                        context.Writer.Write(requestObjectStageVariablesValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsApiGatewayV2StageDetailsMarshaller Instance = new AwsApiGatewayV2StageDetailsMarshaller();

    }
}