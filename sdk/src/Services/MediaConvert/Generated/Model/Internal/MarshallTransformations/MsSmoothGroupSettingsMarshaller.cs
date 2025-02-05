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
    /// MsSmoothGroupSettings Marshaller
    /// </summary>
    public class MsSmoothGroupSettingsMarshaller : IRequestMarshaller<MsSmoothGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MsSmoothGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalManifests())
            {
                context.Writer.WritePropertyName("additionalManifests");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalManifestsListValue in requestObject.AdditionalManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MsSmoothAdditionalManifestMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAudioDeduplication())
            {
                context.Writer.WritePropertyName("audioDeduplication");
                context.Writer.WriteStringValue(requestObject.AudioDeduplication);
            }

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStringValue(requestObject.Destination);
            }

            if(requestObject.IsSetDestinationSettings())
            {
                context.Writer.WritePropertyName("destinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = DestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteStartObject();

                var marshaller = MsSmoothEncryptionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFragmentLength())
            {
                context.Writer.WritePropertyName("fragmentLength");
                context.Writer.WriteNumberValue(requestObject.FragmentLength.Value);
            }

            if(requestObject.IsSetFragmentLengthControl())
            {
                context.Writer.WritePropertyName("fragmentLengthControl");
                context.Writer.WriteStringValue(requestObject.FragmentLengthControl);
            }

            if(requestObject.IsSetManifestEncoding())
            {
                context.Writer.WritePropertyName("manifestEncoding");
                context.Writer.WriteStringValue(requestObject.ManifestEncoding);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MsSmoothGroupSettingsMarshaller Instance = new MsSmoothGroupSettingsMarshaller();

    }
}