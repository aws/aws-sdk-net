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
    /// ProresSettings Marshaller
    /// </summary>
    public class ProresSettingsMarshaller : IRequestMarshaller<ProresSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProresSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChromaSampling())
            {
                context.Writer.WritePropertyName("chromaSampling");
                context.Writer.WriteStringValue(requestObject.ChromaSampling);
            }

            if(requestObject.IsSetCodecProfile())
            {
                context.Writer.WritePropertyName("codecProfile");
                context.Writer.WriteStringValue(requestObject.CodecProfile);
            }

            if(requestObject.IsSetFramerateControl())
            {
                context.Writer.WritePropertyName("framerateControl");
                context.Writer.WriteStringValue(requestObject.FramerateControl);
            }

            if(requestObject.IsSetFramerateConversionAlgorithm())
            {
                context.Writer.WritePropertyName("framerateConversionAlgorithm");
                context.Writer.WriteStringValue(requestObject.FramerateConversionAlgorithm);
            }

            if(requestObject.IsSetFramerateDenominator())
            {
                context.Writer.WritePropertyName("framerateDenominator");
                context.Writer.WriteNumberValue(requestObject.FramerateDenominator.Value);
            }

            if(requestObject.IsSetFramerateNumerator())
            {
                context.Writer.WritePropertyName("framerateNumerator");
                context.Writer.WriteNumberValue(requestObject.FramerateNumerator.Value);
            }

            if(requestObject.IsSetInterlaceMode())
            {
                context.Writer.WritePropertyName("interlaceMode");
                context.Writer.WriteStringValue(requestObject.InterlaceMode);
            }

            if(requestObject.IsSetParControl())
            {
                context.Writer.WritePropertyName("parControl");
                context.Writer.WriteStringValue(requestObject.ParControl);
            }

            if(requestObject.IsSetParDenominator())
            {
                context.Writer.WritePropertyName("parDenominator");
                context.Writer.WriteNumberValue(requestObject.ParDenominator.Value);
            }

            if(requestObject.IsSetParNumerator())
            {
                context.Writer.WritePropertyName("parNumerator");
                context.Writer.WriteNumberValue(requestObject.ParNumerator.Value);
            }

            if(requestObject.IsSetPerFrameMetrics())
            {
                context.Writer.WritePropertyName("perFrameMetrics");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPerFrameMetricsListValue in requestObject.PerFrameMetrics)
                {
                        context.Writer.WriteStringValue(requestObjectPerFrameMetricsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanTypeConversionMode())
            {
                context.Writer.WritePropertyName("scanTypeConversionMode");
                context.Writer.WriteStringValue(requestObject.ScanTypeConversionMode);
            }

            if(requestObject.IsSetSlowPal())
            {
                context.Writer.WritePropertyName("slowPal");
                context.Writer.WriteStringValue(requestObject.SlowPal);
            }

            if(requestObject.IsSetTelecine())
            {
                context.Writer.WritePropertyName("telecine");
                context.Writer.WriteStringValue(requestObject.Telecine);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProresSettingsMarshaller Instance = new ProresSettingsMarshaller();

    }
}