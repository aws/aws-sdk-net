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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AudioNormalizationSettings Marshaller
    /// </summary>
    public class AudioNormalizationSettingsMarshaller : IRequestMarshaller<AudioNormalizationSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudioNormalizationSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlgorithm())
            {
                context.Writer.WritePropertyName("algorithm");
                context.Writer.WriteStringValue(requestObject.Algorithm);
            }

            if(requestObject.IsSetAlgorithmControl())
            {
                context.Writer.WritePropertyName("algorithmControl");
                context.Writer.WriteStringValue(requestObject.AlgorithmControl);
            }

            if(requestObject.IsSetCorrectionGateLevel())
            {
                context.Writer.WritePropertyName("correctionGateLevel");
                context.Writer.WriteNumberValue(requestObject.CorrectionGateLevel.Value);
            }

            if(requestObject.IsSetLoudnessLogging())
            {
                context.Writer.WritePropertyName("loudnessLogging");
                context.Writer.WriteStringValue(requestObject.LoudnessLogging);
            }

            if(requestObject.IsSetPeakCalculation())
            {
                context.Writer.WritePropertyName("peakCalculation");
                context.Writer.WriteStringValue(requestObject.PeakCalculation);
            }

            if(requestObject.IsSetTargetLkfs())
            {
                context.Writer.WritePropertyName("targetLkfs");
                if(StringUtils.IsSpecialDoubleValue(requestObject.TargetLkfs.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TargetLkfs.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TargetLkfs.Value);
                }
            }

            if(requestObject.IsSetTruePeakLimiterThreshold())
            {
                context.Writer.WritePropertyName("truePeakLimiterThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.TruePeakLimiterThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.TruePeakLimiterThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.TruePeakLimiterThreshold.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AudioNormalizationSettingsMarshaller Instance = new AudioNormalizationSettingsMarshaller();

    }
}