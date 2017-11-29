/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CanarySettings Marshaller
    /// </summary>       
    public class CanarySettingsMarshaller : IRequestMarshaller<CanarySettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CanarySettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeploymentId())
            {
                context.Writer.WritePropertyName("deploymentId");
                context.Writer.Write(requestObject.DeploymentId);
            }

            if(requestObject.IsSetPercentTraffic())
            {
                context.Writer.WritePropertyName("percentTraffic");
                context.Writer.Write(requestObject.PercentTraffic);
            }

            if(requestObject.IsSetStageVariableOverrides())
            {
                context.Writer.WritePropertyName("stageVariableOverrides");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectStageVariableOverridesKvp in requestObject.StageVariableOverrides)
                {
                    context.Writer.WritePropertyName(requestObjectStageVariableOverridesKvp.Key);
                    var requestObjectStageVariableOverridesValue = requestObjectStageVariableOverridesKvp.Value;

                        context.Writer.Write(requestObjectStageVariableOverridesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUseStageCache())
            {
                context.Writer.WritePropertyName("useStageCache");
                context.Writer.Write(requestObject.UseStageCache);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CanarySettingsMarshaller Instance = new CanarySettingsMarshaller();

    }
}