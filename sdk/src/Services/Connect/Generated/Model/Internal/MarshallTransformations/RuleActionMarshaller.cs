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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleAction Marshaller
    /// </summary>
    public class RuleActionMarshaller : IRequestMarshaller<RuleAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionType())
            {
                context.Writer.WritePropertyName("ActionType");
                context.Writer.WriteStringValue(requestObject.ActionType);
            }

            if(requestObject.IsSetAssignContactCategoryAction())
            {
                context.Writer.WritePropertyName("AssignContactCategoryAction");
                context.Writer.WriteStartObject();

                var marshaller = AssignContactCategoryActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.AssignContactCategoryAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAssignSlaAction())
            {
                context.Writer.WritePropertyName("AssignSlaAction");
                context.Writer.WriteStartObject();

                var marshaller = AssignSlaActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.AssignSlaAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateCaseAction())
            {
                context.Writer.WritePropertyName("CreateCaseAction");
                context.Writer.WriteStartObject();

                var marshaller = CreateCaseActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateCaseAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEndAssociatedTasksAction())
            {
                context.Writer.WritePropertyName("EndAssociatedTasksAction");
                context.Writer.WriteStartObject();

                var marshaller = EndAssociatedTasksActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.EndAssociatedTasksAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEventBridgeAction())
            {
                context.Writer.WritePropertyName("EventBridgeAction");
                context.Writer.WriteStartObject();

                var marshaller = EventBridgeActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.EventBridgeAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSendNotificationAction())
            {
                context.Writer.WritePropertyName("SendNotificationAction");
                context.Writer.WriteStartObject();

                var marshaller = SendNotificationActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.SendNotificationAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubmitAutoEvaluationAction())
            {
                context.Writer.WritePropertyName("SubmitAutoEvaluationAction");
                context.Writer.WriteStartObject();

                var marshaller = SubmitAutoEvaluationActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.SubmitAutoEvaluationAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTaskAction())
            {
                context.Writer.WritePropertyName("TaskAction");
                context.Writer.WriteStartObject();

                var marshaller = TaskActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.TaskAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateCaseAction())
            {
                context.Writer.WritePropertyName("UpdateCaseAction");
                context.Writer.WriteStartObject();

                var marshaller = UpdateCaseActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateCaseAction, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleActionMarshaller Instance = new RuleActionMarshaller();

    }
}