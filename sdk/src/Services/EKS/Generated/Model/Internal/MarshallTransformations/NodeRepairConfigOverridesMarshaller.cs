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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NodeRepairConfigOverrides Marshaller
    /// </summary>
    public class NodeRepairConfigOverridesMarshaller : IRequestMarshaller<NodeRepairConfigOverrides, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NodeRepairConfigOverrides requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMinRepairWaitTimeMins())
            {
                context.Writer.WritePropertyName("minRepairWaitTimeMins");
                context.Writer.WriteNumberValue(requestObject.MinRepairWaitTimeMins.Value);
            }

            if(requestObject.IsSetNodeMonitoringCondition())
            {
                context.Writer.WritePropertyName("nodeMonitoringCondition");
                context.Writer.WriteStringValue(requestObject.NodeMonitoringCondition);
            }

            if(requestObject.IsSetNodeUnhealthyReason())
            {
                context.Writer.WritePropertyName("nodeUnhealthyReason");
                context.Writer.WriteStringValue(requestObject.NodeUnhealthyReason);
            }

            if(requestObject.IsSetRepairAction())
            {
                context.Writer.WritePropertyName("repairAction");
                context.Writer.WriteStringValue(requestObject.RepairAction);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NodeRepairConfigOverridesMarshaller Instance = new NodeRepairConfigOverridesMarshaller();

    }
}