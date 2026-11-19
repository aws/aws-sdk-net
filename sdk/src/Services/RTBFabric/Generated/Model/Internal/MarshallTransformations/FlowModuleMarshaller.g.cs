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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.RTBFabric.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.RTBFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FlowModule Marshaller
    /// </summary>
    public partial class FlowModuleMarshaller : IRequestMarshaller<FlowModule, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FlowModule requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetActivationPercentage())
            {
                context.Writer.WritePropertyName("activationPercentage");
                if (StringUtils.IsSpecialFloatValue(requestObject.ActivationPercentage.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.ActivationPercentage.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ActivationPercentage.Value);
                }
            }

            if (requestObject.IsSetConfigurationValues())
            {
                context.Writer.WritePropertyName("configurationValues");
                context.Writer.WriteStringValue(requestObject.ConfigurationValues);
            }

            if (requestObject.IsSetFailureMode())
            {
                context.Writer.WritePropertyName("failureMode");
                context.Writer.WriteStringValue(requestObject.FailureMode);
            }

            if (requestObject.IsSetModuleVersionArn())
            {
                context.Writer.WritePropertyName("moduleVersionArn");
                context.Writer.WriteStringValue(requestObject.ModuleVersionArn);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if (requestObject.IsSetSelectedActions())
            {
                context.Writer.WritePropertyName("selectedActions");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSelectedActionsListValue in requestObject.SelectedActions)
                {
                    context.Writer.WriteStringValue(requestObjectSelectedActionsListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FlowModuleMarshaller Instance = new FlowModuleMarshaller();
    }
}
