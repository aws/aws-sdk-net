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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Eac3AtmosSettings Marshaller
    /// </summary>
    public class Eac3AtmosSettingsMarshaller : IRequestMarshaller<Eac3AtmosSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Eac3AtmosSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Bitrate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Bitrate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Bitrate.Value);
                }
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.WriteStringValue(requestObject.CodingMode);
            }

            if(requestObject.IsSetDialnorm())
            {
                context.Writer.WritePropertyName("dialnorm");
                context.Writer.WriteNumberValue(requestObject.Dialnorm.Value);
            }

            if(requestObject.IsSetDrcLine())
            {
                context.Writer.WritePropertyName("drcLine");
                context.Writer.WriteStringValue(requestObject.DrcLine);
            }

            if(requestObject.IsSetDrcRf())
            {
                context.Writer.WritePropertyName("drcRf");
                context.Writer.WriteStringValue(requestObject.DrcRf);
            }

            if(requestObject.IsSetHeightTrim())
            {
                context.Writer.WritePropertyName("heightTrim");
                if(StringUtils.IsSpecialDoubleValue(requestObject.HeightTrim.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.HeightTrim.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.HeightTrim.Value);
                }
            }

            if(requestObject.IsSetSurroundTrim())
            {
                context.Writer.WritePropertyName("surroundTrim");
                if(StringUtils.IsSpecialDoubleValue(requestObject.SurroundTrim.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.SurroundTrim.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.SurroundTrim.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Eac3AtmosSettingsMarshaller Instance = new Eac3AtmosSettingsMarshaller();

    }
}