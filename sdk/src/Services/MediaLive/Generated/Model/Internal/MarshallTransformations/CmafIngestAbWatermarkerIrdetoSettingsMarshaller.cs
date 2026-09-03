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
    /// CmafIngestAbWatermarkerIrdetoSettings Marshaller
    /// </summary>
    public class CmafIngestAbWatermarkerIrdetoSettingsMarshaller : IRequestMarshaller<CmafIngestAbWatermarkerIrdetoSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CmafIngestAbWatermarkerIrdetoSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalDestinationsAlternateDestinations())
            {
                context.Writer.WritePropertyName("additionalDestinationsAlternateDestinations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalDestinationsAlternateDestinationsListValue in requestObject.AdditionalDestinationsAlternateDestinations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputLocationRefMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalDestinationsAlternateDestinationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAlternateDestination())
            {
                context.Writer.WritePropertyName("alternateDestination");
                context.Writer.WriteStartObject();

                var marshaller = OutputLocationRefMarshaller.Instance;
                marshaller.Marshall(requestObject.AlternateDestination, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomProfile())
            {
                context.Writer.WritePropertyName("customProfile");
                context.Writer.WriteStartObject();

                var marshaller = AbWatermarkingCustomProfileMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomProfile, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLicense())
            {
                context.Writer.WritePropertyName("license");
                context.Writer.WriteStringValue(requestObject.License);
            }

            if(requestObject.IsSetOperatorId())
            {
                context.Writer.WritePropertyName("operatorId");
                context.Writer.WriteNumberValue(requestObject.OperatorId.Value);
            }

            if(requestObject.IsSetPolyPeriod())
            {
                context.Writer.WritePropertyName("polyPeriod");
                context.Writer.WriteNumberValue(requestObject.PolyPeriod.Value);
            }

            if(requestObject.IsSetProfile())
            {
                context.Writer.WritePropertyName("profile");
                context.Writer.WriteStringValue(requestObject.Profile);
            }

            if(requestObject.IsSetWatermarkIdLength())
            {
                context.Writer.WritePropertyName("watermarkIdLength");
                context.Writer.WriteStringValue(requestObject.WatermarkIdLength);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CmafIngestAbWatermarkerIrdetoSettingsMarshaller Instance = new CmafIngestAbWatermarkerIrdetoSettingsMarshaller();

    }
}