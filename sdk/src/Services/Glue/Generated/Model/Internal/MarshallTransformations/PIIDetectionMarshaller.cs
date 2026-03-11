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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PIIDetection Marshaller
    /// </summary>
    public class PIIDetectionMarshaller : IRequestMarshaller<PIIDetection, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PIIDetection requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDetectionParameters())
            {
                context.Writer.WritePropertyName("DetectionParameters");
                context.Writer.WriteStringValue(requestObject.DetectionParameters);
            }

            if(requestObject.IsSetDetectionSensitivity())
            {
                context.Writer.WritePropertyName("DetectionSensitivity");
                context.Writer.WriteStringValue(requestObject.DetectionSensitivity);
            }

            if(requestObject.IsSetEntityTypesToDetect())
            {
                context.Writer.WritePropertyName("EntityTypesToDetect");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEntityTypesToDetectListValue in requestObject.EntityTypesToDetect)
                {
                        context.Writer.WriteStringValue(requestObjectEntityTypesToDetectListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInputs())
            {
                context.Writer.WritePropertyName("Inputs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputsListValue in requestObject.Inputs)
                {
                        context.Writer.WriteStringValue(requestObjectInputsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaskValue())
            {
                context.Writer.WritePropertyName("MaskValue");
                context.Writer.WriteStringValue(requestObject.MaskValue);
            }

            if(requestObject.IsSetMatchPattern())
            {
                context.Writer.WritePropertyName("MatchPattern");
                context.Writer.WriteStringValue(requestObject.MatchPattern);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetNumLeftCharsToExclude())
            {
                context.Writer.WritePropertyName("NumLeftCharsToExclude");
                context.Writer.WriteNumberValue(requestObject.NumLeftCharsToExclude.Value);
            }

            if(requestObject.IsSetNumRightCharsToExclude())
            {
                context.Writer.WritePropertyName("NumRightCharsToExclude");
                context.Writer.WriteNumberValue(requestObject.NumRightCharsToExclude.Value);
            }

            if(requestObject.IsSetOutputColumnName())
            {
                context.Writer.WritePropertyName("OutputColumnName");
                context.Writer.WriteStringValue(requestObject.OutputColumnName);
            }

            if(requestObject.IsSetPiiType())
            {
                context.Writer.WritePropertyName("PiiType");
                context.Writer.WriteStringValue(requestObject.PiiType);
            }

            if(requestObject.IsSetRedactChar())
            {
                context.Writer.WritePropertyName("RedactChar");
                context.Writer.WriteStringValue(requestObject.RedactChar);
            }

            if(requestObject.IsSetRedactText())
            {
                context.Writer.WritePropertyName("RedactText");
                context.Writer.WriteStringValue(requestObject.RedactText);
            }

            if(requestObject.IsSetSampleFraction())
            {
                context.Writer.WritePropertyName("SampleFraction");
                if(StringUtils.IsSpecialDoubleValue(requestObject.SampleFraction.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.SampleFraction.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.SampleFraction.Value);
                }
            }

            if(requestObject.IsSetThresholdFraction())
            {
                context.Writer.WritePropertyName("ThresholdFraction");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ThresholdFraction.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ThresholdFraction.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ThresholdFraction.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PIIDetectionMarshaller Instance = new PIIDetectionMarshaller();

    }
}