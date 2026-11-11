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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.TranscribeService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Settings Marshaller
    /// </summary>
    public partial class SettingsMarshaller : IRequestMarshaller<Settings, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Settings requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetChannelIdentification())
            {
                context.Writer.WriteTextString("ChannelIdentification");
                context.Writer.WriteBoolean(requestObject.ChannelIdentification.Value);
            }

            if (requestObject.IsSetMaxAlternatives())
            {
                context.Writer.WriteTextString("MaxAlternatives");
                context.Writer.WriteInt32(requestObject.MaxAlternatives.Value);
            }

            if (requestObject.IsSetMaxSpeakerLabels())
            {
                context.Writer.WriteTextString("MaxSpeakerLabels");
                context.Writer.WriteInt32(requestObject.MaxSpeakerLabels.Value);
            }

            if (requestObject.IsSetShowAlternatives())
            {
                context.Writer.WriteTextString("ShowAlternatives");
                context.Writer.WriteBoolean(requestObject.ShowAlternatives.Value);
            }

            if (requestObject.IsSetShowSpeakerLabels())
            {
                context.Writer.WriteTextString("ShowSpeakerLabels");
                context.Writer.WriteBoolean(requestObject.ShowSpeakerLabels.Value);
            }

            if (requestObject.IsSetVocabularyFilterMethod())
            {
                context.Writer.WriteTextString("VocabularyFilterMethod");
                context.Writer.WriteTextString(requestObject.VocabularyFilterMethod);
            }

            if (requestObject.IsSetVocabularyFilterName())
            {
                context.Writer.WriteTextString("VocabularyFilterName");
                context.Writer.WriteTextString(requestObject.VocabularyFilterName);
            }

            if (requestObject.IsSetVocabularyName())
            {
                context.Writer.WriteTextString("VocabularyName");
                context.Writer.WriteTextString(requestObject.VocabularyName);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SettingsMarshaller Instance = new SettingsMarshaller();
    }
}
