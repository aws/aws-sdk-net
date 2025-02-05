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
    /// ClarifyInferenceConfig Marshaller
    /// </summary>
    public class ClarifyInferenceConfigMarshaller : IRequestMarshaller<ClarifyInferenceConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ClarifyInferenceConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContentTemplate())
            {
                context.Writer.WritePropertyName("ContentTemplate");
                context.Writer.WriteStringValue(requestObject.ContentTemplate);
            }

            if(requestObject.IsSetFeatureHeaders())
            {
                context.Writer.WritePropertyName("FeatureHeaders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFeatureHeadersListValue in requestObject.FeatureHeaders)
                {
                        context.Writer.WriteStringValue(requestObjectFeatureHeadersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFeaturesAttribute())
            {
                context.Writer.WritePropertyName("FeaturesAttribute");
                context.Writer.WriteStringValue(requestObject.FeaturesAttribute);
            }

            if(requestObject.IsSetFeatureTypes())
            {
                context.Writer.WritePropertyName("FeatureTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFeatureTypesListValue in requestObject.FeatureTypes)
                {
                        context.Writer.WriteStringValue(requestObjectFeatureTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLabelAttribute())
            {
                context.Writer.WritePropertyName("LabelAttribute");
                context.Writer.WriteStringValue(requestObject.LabelAttribute);
            }

            if(requestObject.IsSetLabelHeaders())
            {
                context.Writer.WritePropertyName("LabelHeaders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLabelHeadersListValue in requestObject.LabelHeaders)
                {
                        context.Writer.WriteStringValue(requestObjectLabelHeadersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLabelIndex())
            {
                context.Writer.WritePropertyName("LabelIndex");
                context.Writer.WriteNumberValue(requestObject.LabelIndex.Value);
            }

            if(requestObject.IsSetMaxPayloadInMB())
            {
                context.Writer.WritePropertyName("MaxPayloadInMB");
                context.Writer.WriteNumberValue(requestObject.MaxPayloadInMB.Value);
            }

            if(requestObject.IsSetMaxRecordCount())
            {
                context.Writer.WritePropertyName("MaxRecordCount");
                context.Writer.WriteNumberValue(requestObject.MaxRecordCount.Value);
            }

            if(requestObject.IsSetProbabilityAttribute())
            {
                context.Writer.WritePropertyName("ProbabilityAttribute");
                context.Writer.WriteStringValue(requestObject.ProbabilityAttribute);
            }

            if(requestObject.IsSetProbabilityIndex())
            {
                context.Writer.WritePropertyName("ProbabilityIndex");
                context.Writer.WriteNumberValue(requestObject.ProbabilityIndex.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClarifyInferenceConfigMarshaller Instance = new ClarifyInferenceConfigMarshaller();

    }
}