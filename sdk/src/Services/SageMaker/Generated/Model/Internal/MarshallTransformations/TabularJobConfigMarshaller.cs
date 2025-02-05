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
    /// TabularJobConfig Marshaller
    /// </summary>
    public class TabularJobConfigMarshaller : IRequestMarshaller<TabularJobConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TabularJobConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCandidateGenerationConfig())
            {
                context.Writer.WritePropertyName("CandidateGenerationConfig");
                context.Writer.WriteStartObject();

                var marshaller = CandidateGenerationConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CandidateGenerationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCompletionCriteria())
            {
                context.Writer.WritePropertyName("CompletionCriteria");
                context.Writer.WriteStartObject();

                var marshaller = AutoMLJobCompletionCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.CompletionCriteria, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFeatureSpecificationS3Uri())
            {
                context.Writer.WritePropertyName("FeatureSpecificationS3Uri");
                context.Writer.WriteStringValue(requestObject.FeatureSpecificationS3Uri);
            }

            if(requestObject.IsSetGenerateCandidateDefinitionsOnly())
            {
                context.Writer.WritePropertyName("GenerateCandidateDefinitionsOnly");
                context.Writer.WriteBooleanValue(requestObject.GenerateCandidateDefinitionsOnly.Value);
            }

            if(requestObject.IsSetMode())
            {
                context.Writer.WritePropertyName("Mode");
                context.Writer.WriteStringValue(requestObject.Mode);
            }

            if(requestObject.IsSetProblemType())
            {
                context.Writer.WritePropertyName("ProblemType");
                context.Writer.WriteStringValue(requestObject.ProblemType);
            }

            if(requestObject.IsSetSampleWeightAttributeName())
            {
                context.Writer.WritePropertyName("SampleWeightAttributeName");
                context.Writer.WriteStringValue(requestObject.SampleWeightAttributeName);
            }

            if(requestObject.IsSetTargetAttributeName())
            {
                context.Writer.WritePropertyName("TargetAttributeName");
                context.Writer.WriteStringValue(requestObject.TargetAttributeName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TabularJobConfigMarshaller Instance = new TabularJobConfigMarshaller();

    }
}