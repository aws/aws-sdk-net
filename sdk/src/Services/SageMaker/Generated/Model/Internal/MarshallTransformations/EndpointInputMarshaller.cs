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
    /// EndpointInput Marshaller
    /// </summary>
    public class EndpointInputMarshaller : IRequestMarshaller<EndpointInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EndpointInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEndpointName())
            {
                context.Writer.WritePropertyName("EndpointName");
                context.Writer.WriteStringValue(requestObject.EndpointName);
            }

            if(requestObject.IsSetEndTimeOffset())
            {
                context.Writer.WritePropertyName("EndTimeOffset");
                context.Writer.WriteStringValue(requestObject.EndTimeOffset);
            }

            if(requestObject.IsSetExcludeFeaturesAttribute())
            {
                context.Writer.WritePropertyName("ExcludeFeaturesAttribute");
                context.Writer.WriteStringValue(requestObject.ExcludeFeaturesAttribute);
            }

            if(requestObject.IsSetFeaturesAttribute())
            {
                context.Writer.WritePropertyName("FeaturesAttribute");
                context.Writer.WriteStringValue(requestObject.FeaturesAttribute);
            }

            if(requestObject.IsSetInferenceAttribute())
            {
                context.Writer.WritePropertyName("InferenceAttribute");
                context.Writer.WriteStringValue(requestObject.InferenceAttribute);
            }

            if(requestObject.IsSetLocalPath())
            {
                context.Writer.WritePropertyName("LocalPath");
                context.Writer.WriteStringValue(requestObject.LocalPath);
            }

            if(requestObject.IsSetProbabilityAttribute())
            {
                context.Writer.WritePropertyName("ProbabilityAttribute");
                context.Writer.WriteStringValue(requestObject.ProbabilityAttribute);
            }

            if(requestObject.IsSetProbabilityThresholdAttribute())
            {
                context.Writer.WritePropertyName("ProbabilityThresholdAttribute");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ProbabilityThresholdAttribute.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ProbabilityThresholdAttribute.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ProbabilityThresholdAttribute.Value);
                }
            }

            if(requestObject.IsSetS3DataDistributionType())
            {
                context.Writer.WritePropertyName("S3DataDistributionType");
                context.Writer.WriteStringValue(requestObject.S3DataDistributionType);
            }

            if(requestObject.IsSetS3InputMode())
            {
                context.Writer.WritePropertyName("S3InputMode");
                context.Writer.WriteStringValue(requestObject.S3InputMode);
            }

            if(requestObject.IsSetStartTimeOffset())
            {
                context.Writer.WritePropertyName("StartTimeOffset");
                context.Writer.WriteStringValue(requestObject.StartTimeOffset);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EndpointInputMarshaller Instance = new EndpointInputMarshaller();

    }
}