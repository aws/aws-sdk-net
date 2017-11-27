/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetAcquisitionPointId())
            {
                context.Writer.WritePropertyName("acquisitionPointId");
                context.Writer.Write(requestObject.AcquisitionPointId);
            }

            if(requestObject.IsSetAudioOnlyTimecodeControl())
            {
                context.Writer.WritePropertyName("audioOnlyTimecodeControl");
                context.Writer.Write(requestObject.AudioOnlyTimecodeControl);
            }

            if(requestObject.IsSetCertificateMode())
            {
                context.Writer.WritePropertyName("certificateMode");
                context.Writer.Write(requestObject.CertificateMode);
            }

            if(requestObject.IsSetConnectionRetryInterval())
            {
                context.Writer.WritePropertyName("connectionRetryInterval");
                context.Writer.Write(requestObject.ConnectionRetryInterval);
            }

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteObjectStart();

                var marshaller = OutputLocationRefMarshaller.Instance;
                marshaller.Marshall(requestObject.Destination, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEventId())
            {
                context.Writer.WritePropertyName("eventId");
                context.Writer.Write(requestObject.EventId);
            }

            if(requestObject.IsSetEventIdMode())
            {
                context.Writer.WritePropertyName("eventIdMode");
                context.Writer.Write(requestObject.EventIdMode);
            }

            if(requestObject.IsSetEventStopBehavior())
            {
                context.Writer.WritePropertyName("eventStopBehavior");
                context.Writer.Write(requestObject.EventStopBehavior);
            }

            if(requestObject.IsSetFilecacheDuration())
            {
                context.Writer.WritePropertyName("filecacheDuration");
                context.Writer.Write(requestObject.FilecacheDuration);
            }

            if(requestObject.IsSetFragmentLength())
            {
                context.Writer.WritePropertyName("fragmentLength");
                context.Writer.Write(requestObject.FragmentLength);
            }

            if(requestObject.IsSetInputLossAction())
            {
                context.Writer.WritePropertyName("inputLossAction");
                context.Writer.Write(requestObject.InputLossAction);
            }

            if(requestObject.IsSetNumRetries())
            {
                context.Writer.WritePropertyName("numRetries");
                context.Writer.Write(requestObject.NumRetries);
            }

            if(requestObject.IsSetRestartDelay())
            {
                context.Writer.WritePropertyName("restartDelay");
                context.Writer.Write(requestObject.RestartDelay);
            }

            if(requestObject.IsSetSegmentationMode())
            {
                context.Writer.WritePropertyName("segmentationMode");
                context.Writer.Write(requestObject.SegmentationMode);
            }

            if(requestObject.IsSetSendDelayMs())
            {
                context.Writer.WritePropertyName("sendDelayMs");
                context.Writer.Write(requestObject.SendDelayMs);
            }

            if(requestObject.IsSetSparseTrackType())
            {
                context.Writer.WritePropertyName("sparseTrackType");
                context.Writer.Write(requestObject.SparseTrackType);
            }

            if(requestObject.IsSetStreamManifestBehavior())
            {
                context.Writer.WritePropertyName("streamManifestBehavior");
                context.Writer.Write(requestObject.StreamManifestBehavior);
            }

            if(requestObject.IsSetTimestampOffset())
            {
                context.Writer.WritePropertyName("timestampOffset");
                context.Writer.Write(requestObject.TimestampOffset);
            }

            if(requestObject.IsSetTimestampOffsetMode())
            {
                context.Writer.WritePropertyName("timestampOffsetMode");
                context.Writer.Write(requestObject.TimestampOffsetMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static MsSmoothGroupSettingsMarshaller Instance = new MsSmoothGroupSettingsMarshaller();

    }
}