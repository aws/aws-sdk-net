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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SagemakerEdgeManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SagemakerEdgeManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeploymentResult Marshaller
    /// </summary>
    public class DeploymentResultMarshaller : IRequestMarshaller<DeploymentResult, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeploymentResult requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeploymentEndTime())
            {
                context.Writer.WritePropertyName("DeploymentEndTime");
                context.Writer.Write(requestObject.DeploymentEndTime);
            }

            if(requestObject.IsSetDeploymentModels())
            {
                context.Writer.WritePropertyName("DeploymentModels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDeploymentModelsListValue in requestObject.DeploymentModels)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DeploymentModelMarshaller.Instance;
                    marshaller.Marshall(requestObjectDeploymentModelsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDeploymentName())
            {
                context.Writer.WritePropertyName("DeploymentName");
                context.Writer.Write(requestObject.DeploymentName);
            }

            if(requestObject.IsSetDeploymentStartTime())
            {
                context.Writer.WritePropertyName("DeploymentStartTime");
                context.Writer.Write(requestObject.DeploymentStartTime);
            }

            if(requestObject.IsSetDeploymentStatus())
            {
                context.Writer.WritePropertyName("DeploymentStatus");
                context.Writer.Write(requestObject.DeploymentStatus);
            }

            if(requestObject.IsSetDeploymentStatusMessage())
            {
                context.Writer.WritePropertyName("DeploymentStatusMessage");
                context.Writer.Write(requestObject.DeploymentStatusMessage);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeploymentResultMarshaller Instance = new DeploymentResultMarshaller();

    }
}