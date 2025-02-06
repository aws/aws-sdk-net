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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryControlConfig.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryControlConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NewGatingRule Marshaller
    /// </summary>
    public class NewGatingRuleMarshaller : IRequestMarshaller<NewGatingRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NewGatingRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetControlPanelArn())
            {
                context.Writer.WritePropertyName("ControlPanelArn");
                context.Writer.WriteStringValue(requestObject.ControlPanelArn);
            }

            if(requestObject.IsSetGatingControls())
            {
                context.Writer.WritePropertyName("GatingControls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGatingControlsListValue in requestObject.GatingControls)
                {
                        context.Writer.WriteStringValue(requestObjectGatingControlsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRuleConfig())
            {
                context.Writer.WritePropertyName("RuleConfig");
                context.Writer.WriteStartObject();

                var marshaller = RuleConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.RuleConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTargetControls())
            {
                context.Writer.WritePropertyName("TargetControls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetControlsListValue in requestObject.TargetControls)
                {
                        context.Writer.WriteStringValue(requestObjectTargetControlsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWaitPeriodMs())
            {
                context.Writer.WritePropertyName("WaitPeriodMs");
                context.Writer.WriteNumberValue(requestObject.WaitPeriodMs.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NewGatingRuleMarshaller Instance = new NewGatingRuleMarshaller();

    }
}