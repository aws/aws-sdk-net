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
using ThirdParty.Json.LitJson;

namespace Amazon.FIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateExperimentTemplateActionInput Marshaller
    /// </summary>
    public class CreateExperimentTemplateActionInputMarshaller : IRequestMarshaller<CreateExperimentTemplateActionInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateExperimentTemplateActionInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActionId())
            {
                context.Writer.WritePropertyName("actionId");
                context.Writer.Write(requestObject.ActionId);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.Write(requestObjectParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStartAfter())
            {
                context.Writer.WritePropertyName("startAfter");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStartAfterListValue in requestObject.StartAfter)
                {
                        context.Writer.Write(requestObjectStartAfterListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargets())
            {
                context.Writer.WritePropertyName("targets");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTargetsKvp in requestObject.Targets)
                {
                    context.Writer.WritePropertyName(requestObjectTargetsKvp.Key);
                    var requestObjectTargetsValue = requestObjectTargetsKvp.Value;

                        context.Writer.Write(requestObjectTargetsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateExperimentTemplateActionInputMarshaller Instance = new CreateExperimentTemplateActionInputMarshaller();

    }
}