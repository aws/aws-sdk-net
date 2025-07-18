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
    /// Mp4Settings Marshaller
    /// </summary>
    public class Mp4SettingsMarshaller : IRequestMarshaller<Mp4Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Mp4Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioDuration())
            {
                context.Writer.WritePropertyName("audioDuration");
                context.Writer.WriteStringValue(requestObject.AudioDuration);
            }

            if(requestObject.IsSetC2paManifest())
            {
                context.Writer.WritePropertyName("c2paManifest");
                context.Writer.WriteStringValue(requestObject.C2paManifest);
            }

            if(requestObject.IsSetCertificateSecret())
            {
                context.Writer.WritePropertyName("certificateSecret");
                context.Writer.WriteStringValue(requestObject.CertificateSecret);
            }

            if(requestObject.IsSetCslgAtom())
            {
                context.Writer.WritePropertyName("cslgAtom");
                context.Writer.WriteStringValue(requestObject.CslgAtom);
            }

            if(requestObject.IsSetCttsVersion())
            {
                context.Writer.WritePropertyName("cttsVersion");
                context.Writer.WriteNumberValue(requestObject.CttsVersion.Value);
            }

            if(requestObject.IsSetFreeSpaceBox())
            {
                context.Writer.WritePropertyName("freeSpaceBox");
                context.Writer.WriteStringValue(requestObject.FreeSpaceBox);
            }

            if(requestObject.IsSetMoovPlacement())
            {
                context.Writer.WritePropertyName("moovPlacement");
                context.Writer.WriteStringValue(requestObject.MoovPlacement);
            }

            if(requestObject.IsSetMp4MajorBrand())
            {
                context.Writer.WritePropertyName("mp4MajorBrand");
                context.Writer.WriteStringValue(requestObject.Mp4MajorBrand);
            }

            if(requestObject.IsSetSigningKmsKey())
            {
                context.Writer.WritePropertyName("signingKmsKey");
                context.Writer.WriteStringValue(requestObject.SigningKmsKey);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Mp4SettingsMarshaller Instance = new Mp4SettingsMarshaller();

    }
}