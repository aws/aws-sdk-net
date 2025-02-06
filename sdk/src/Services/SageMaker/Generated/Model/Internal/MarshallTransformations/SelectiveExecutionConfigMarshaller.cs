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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SelectiveExecutionConfig Marshaller
    /// </summary>
    public class SelectiveExecutionConfigMarshaller : IRequestMarshaller<SelectiveExecutionConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SelectiveExecutionConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSelectedSteps())
            {
                context.Writer.WritePropertyName("SelectedSteps");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSelectedStepsListValue in requestObject.SelectedSteps)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SelectedStepMarshaller.Instance;
                    marshaller.Marshall(requestObjectSelectedStepsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourcePipelineExecutionArn())
            {
                context.Writer.WritePropertyName("SourcePipelineExecutionArn");
                context.Writer.WriteStringValue(requestObject.SourcePipelineExecutionArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SelectiveExecutionConfigMarshaller Instance = new SelectiveExecutionConfigMarshaller();

    }
}