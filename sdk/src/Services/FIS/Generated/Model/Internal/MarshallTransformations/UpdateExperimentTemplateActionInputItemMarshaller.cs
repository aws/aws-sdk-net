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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FIS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateExperimentTemplateActionInputItem Marshaller
    /// </summary>
    public class UpdateExperimentTemplateActionInputItemMarshaller : IRequestMarshaller<UpdateExperimentTemplateActionInputItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateExperimentTemplateActionInputItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionId())
            {
                context.Writer.WritePropertyName("actionId");
                context.Writer.WriteStringValue(requestObject.ActionId);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStartAfter())
            {
                context.Writer.WritePropertyName("startAfter");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStartAfterListValue in requestObject.StartAfter)
                {
                        context.Writer.WriteStringValue(requestObjectStartAfterListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargets())
            {
                context.Writer.WritePropertyName("targets");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTargetsKvp in requestObject.Targets)
                {
                    context.Writer.WritePropertyName(requestObjectTargetsKvp.Key);
                    var requestObjectTargetsValue = requestObjectTargetsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTargetsValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateExperimentTemplateActionInputItemMarshaller Instance = new UpdateExperimentTemplateActionInputItemMarshaller();

    }
}