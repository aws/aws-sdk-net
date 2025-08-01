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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Workflow Marshaller
    /// </summary>
    public class WorkflowMarshaller : IRequestMarshaller<Workflow, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Workflow requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSteps())
            {
                context.Writer.WritePropertyName("steps");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStepsListValue in requestObject.Steps)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StepMarshaller.Instance;
                    marshaller.Marshall(requestObjectStepsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetWorkflowDescription())
            {
                context.Writer.WritePropertyName("workflowDescription");
                context.Writer.Write(requestObject.WorkflowDescription);
            }

            if(requestObject.IsSetWorkflowTargetAction())
            {
                context.Writer.WritePropertyName("workflowTargetAction");
                context.Writer.Write(requestObject.WorkflowTargetAction);
            }

            if(requestObject.IsSetWorkflowTargetRegion())
            {
                context.Writer.WritePropertyName("workflowTargetRegion");
                context.Writer.Write(requestObject.WorkflowTargetRegion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkflowMarshaller Instance = new WorkflowMarshaller();

    }
}