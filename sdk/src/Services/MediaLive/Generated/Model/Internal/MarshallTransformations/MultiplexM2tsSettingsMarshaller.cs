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
    /// MultiplexM2tsSettings Marshaller
    /// </summary>
    public class MultiplexM2tsSettingsMarshaller : IRequestMarshaller<MultiplexM2tsSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MultiplexM2tsSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAbsentInputAudioBehavior())
            {
                context.Writer.WritePropertyName("absentInputAudioBehavior");
                context.Writer.WriteStringValue(requestObject.AbsentInputAudioBehavior);
            }

            if(requestObject.IsSetArib())
            {
                context.Writer.WritePropertyName("arib");
                context.Writer.WriteStringValue(requestObject.Arib);
            }

            if(requestObject.IsSetAudioBufferModel())
            {
                context.Writer.WritePropertyName("audioBufferModel");
                context.Writer.WriteStringValue(requestObject.AudioBufferModel);
            }

            if(requestObject.IsSetAudioFramesPerPes())
            {
                context.Writer.WritePropertyName("audioFramesPerPes");
                context.Writer.WriteNumberValue(requestObject.AudioFramesPerPes.Value);
            }

            if(requestObject.IsSetAudioStreamType())
            {
                context.Writer.WritePropertyName("audioStreamType");
                context.Writer.WriteStringValue(requestObject.AudioStreamType);
            }

            if(requestObject.IsSetCcDescriptor())
            {
                context.Writer.WritePropertyName("ccDescriptor");
                context.Writer.WriteStringValue(requestObject.CcDescriptor);
            }

            if(requestObject.IsSetEbif())
            {
                context.Writer.WritePropertyName("ebif");
                context.Writer.WriteStringValue(requestObject.Ebif);
            }

            if(requestObject.IsSetEsRateInPes())
            {
                context.Writer.WritePropertyName("esRateInPes");
                context.Writer.WriteStringValue(requestObject.EsRateInPes);
            }

            if(requestObject.IsSetKlv())
            {
                context.Writer.WritePropertyName("klv");
                context.Writer.WriteStringValue(requestObject.Klv);
            }

            if(requestObject.IsSetNielsenId3Behavior())
            {
                context.Writer.WritePropertyName("nielsenId3Behavior");
                context.Writer.WriteStringValue(requestObject.NielsenId3Behavior);
            }

            if(requestObject.IsSetPcrControl())
            {
                context.Writer.WritePropertyName("pcrControl");
                context.Writer.WriteStringValue(requestObject.PcrControl);
            }

            if(requestObject.IsSetPcrPeriod())
            {
                context.Writer.WritePropertyName("pcrPeriod");
                context.Writer.WriteNumberValue(requestObject.PcrPeriod.Value);
            }

            if(requestObject.IsSetScte35Control())
            {
                context.Writer.WritePropertyName("scte35Control");
                context.Writer.WriteStringValue(requestObject.Scte35Control);
            }

            if(requestObject.IsSetScte35PrerollPullupMilliseconds())
            {
                context.Writer.WritePropertyName("scte35PrerollPullupMilliseconds");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Scte35PrerollPullupMilliseconds.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Scte35PrerollPullupMilliseconds.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Scte35PrerollPullupMilliseconds.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MultiplexM2tsSettingsMarshaller Instance = new MultiplexM2tsSettingsMarshaller();

    }
}