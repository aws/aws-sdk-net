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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.ContentTemplate);
            }

            if(requestObject.IsSetFeatureHeaders())
            {
                context.Writer.WritePropertyName("FeatureHeaders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFeatureHeadersListValue in requestObject.FeatureHeaders)
                {
                        context.Writer.Write(requestObjectFeatureHeadersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFeaturesAttribute())
            {
                context.Writer.WritePropertyName("FeaturesAttribute");
                context.Writer.Write(requestObject.FeaturesAttribute);
            }

            if(requestObject.IsSetFeatureTypes())
            {
                context.Writer.WritePropertyName("FeatureTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFeatureTypesListValue in requestObject.FeatureTypes)
                {
                        context.Writer.Write(requestObjectFeatureTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLabelAttribute())
            {
                context.Writer.WritePropertyName("LabelAttribute");
                context.Writer.Write(requestObject.LabelAttribute);
            }

            if(requestObject.IsSetLabelHeaders())
            {
                context.Writer.WritePropertyName("LabelHeaders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLabelHeadersListValue in requestObject.LabelHeaders)
                {
                        context.Writer.Write(requestObjectLabelHeadersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLabelIndex())
            {
                context.Writer.WritePropertyName("LabelIndex");
                context.Writer.Write(requestObject.LabelIndex);
            }

            if(requestObject.IsSetMaxPayloadInMB())
            {
                context.Writer.WritePropertyName("MaxPayloadInMB");
                context.Writer.Write(requestObject.MaxPayloadInMB);
            }

            if(requestObject.IsSetMaxRecordCount())
            {
                context.Writer.WritePropertyName("MaxRecordCount");
                context.Writer.Write(requestObject.MaxRecordCount);
            }

            if(requestObject.IsSetProbabilityAttribute())
            {
                context.Writer.WritePropertyName("ProbabilityAttribute");
                context.Writer.Write(requestObject.ProbabilityAttribute);
            }

            if(requestObject.IsSetProbabilityIndex())
            {
                context.Writer.WritePropertyName("ProbabilityIndex");
                context.Writer.Write(requestObject.ProbabilityIndex);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClarifyInferenceConfigMarshaller Instance = new ClarifyInferenceConfigMarshaller();

    }
}
#pragma warning restore CS0612,CS0618