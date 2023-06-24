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
    /// CreateExperimentTemplateTargetInput Marshaller
    /// </summary>
    public class CreateExperimentTemplateTargetInputMarshaller : IRequestMarshaller<CreateExperimentTemplateTargetInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateExperimentTemplateTargetInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFilters())
            {
                context.Writer.WritePropertyName("filters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFiltersListValue in requestObject.Filters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ExperimentTemplateTargetInputFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
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

            if(requestObject.IsSetResourceArns())
            {
                context.Writer.WritePropertyName("resourceArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceArnsListValue in requestObject.ResourceArns)
                {
                        context.Writer.Write(requestObjectResourceArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("resourceTags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectResourceTagsKvp in requestObject.ResourceTags)
                {
                    context.Writer.WritePropertyName(requestObjectResourceTagsKvp.Key);
                    var requestObjectResourceTagsValue = requestObjectResourceTagsKvp.Value;

                        context.Writer.Write(requestObjectResourceTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("resourceType");
                context.Writer.Write(requestObject.ResourceType);
            }

            if(requestObject.IsSetSelectionMode())
            {
                context.Writer.WritePropertyName("selectionMode");
                context.Writer.Write(requestObject.SelectionMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateExperimentTemplateTargetInputMarshaller Instance = new CreateExperimentTemplateTargetInputMarshaller();

    }
}