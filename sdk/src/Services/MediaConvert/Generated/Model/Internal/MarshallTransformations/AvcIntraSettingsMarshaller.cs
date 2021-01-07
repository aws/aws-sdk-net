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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AvcIntraSettings Marshaller
    /// </summary>       
    public class AvcIntraSettingsMarshaller : IRequestMarshaller<AvcIntraSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AvcIntraSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAvcIntraClass())
            {
                context.Writer.WritePropertyName("avcIntraClass");
                context.Writer.Write(requestObject.AvcIntraClass);
            }

            if(requestObject.IsSetAvcIntraUhdSettings())
            {
                context.Writer.WritePropertyName("avcIntraUhdSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AvcIntraUhdSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AvcIntraUhdSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFramerateControl())
            {
                context.Writer.WritePropertyName("framerateControl");
                context.Writer.Write(requestObject.FramerateControl);
            }

            if(requestObject.IsSetFramerateConversionAlgorithm())
            {
                context.Writer.WritePropertyName("framerateConversionAlgorithm");
                context.Writer.Write(requestObject.FramerateConversionAlgorithm);
            }

            if(requestObject.IsSetFramerateDenominator())
            {
                context.Writer.WritePropertyName("framerateDenominator");
                context.Writer.Write(requestObject.FramerateDenominator);
            }

            if(requestObject.IsSetFramerateNumerator())
            {
                context.Writer.WritePropertyName("framerateNumerator");
                context.Writer.Write(requestObject.FramerateNumerator);
            }

            if(requestObject.IsSetInterlaceMode())
            {
                context.Writer.WritePropertyName("interlaceMode");
                context.Writer.Write(requestObject.InterlaceMode);
            }

            if(requestObject.IsSetScanTypeConversionMode())
            {
                context.Writer.WritePropertyName("scanTypeConversionMode");
                context.Writer.Write(requestObject.ScanTypeConversionMode);
            }

            if(requestObject.IsSetSlowPal())
            {
                context.Writer.WritePropertyName("slowPal");
                context.Writer.Write(requestObject.SlowPal);
            }

            if(requestObject.IsSetTelecine())
            {
                context.Writer.WritePropertyName("telecine");
                context.Writer.Write(requestObject.Telecine);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AvcIntraSettingsMarshaller Instance = new AvcIntraSettingsMarshaller();

    }
}