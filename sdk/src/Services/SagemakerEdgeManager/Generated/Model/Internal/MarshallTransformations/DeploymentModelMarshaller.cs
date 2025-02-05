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
#pragma warning disable CS0612,CS0618
namespace Amazon.SagemakerEdgeManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeploymentModel Marshaller
    /// </summary>
    public class DeploymentModelMarshaller : IRequestMarshaller<DeploymentModel, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeploymentModel requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDesiredState())
            {
                context.Writer.WritePropertyName("DesiredState");
                context.Writer.WriteStringValue(requestObject.DesiredState);
            }

            if(requestObject.IsSetModelHandle())
            {
                context.Writer.WritePropertyName("ModelHandle");
                context.Writer.WriteStringValue(requestObject.ModelHandle);
            }

            if(requestObject.IsSetModelName())
            {
                context.Writer.WritePropertyName("ModelName");
                context.Writer.WriteStringValue(requestObject.ModelName);
            }

            if(requestObject.IsSetModelVersion())
            {
                context.Writer.WritePropertyName("ModelVersion");
                context.Writer.WriteStringValue(requestObject.ModelVersion);
            }

            if(requestObject.IsSetRollbackFailureReason())
            {
                context.Writer.WritePropertyName("RollbackFailureReason");
                context.Writer.WriteStringValue(requestObject.RollbackFailureReason);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(requestObject.State);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetStatusReason())
            {
                context.Writer.WritePropertyName("StatusReason");
                context.Writer.WriteStringValue(requestObject.StatusReason);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeploymentModelMarshaller Instance = new DeploymentModelMarshaller();

    }
}