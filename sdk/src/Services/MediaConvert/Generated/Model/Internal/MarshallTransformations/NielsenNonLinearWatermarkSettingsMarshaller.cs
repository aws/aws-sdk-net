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
    /// NielsenNonLinearWatermarkSettings Marshaller
    /// </summary>
    public class NielsenNonLinearWatermarkSettingsMarshaller : IRequestMarshaller<NielsenNonLinearWatermarkSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NielsenNonLinearWatermarkSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActiveWatermarkProcess())
            {
                context.Writer.WritePropertyName("activeWatermarkProcess");
                context.Writer.WriteStringValue(requestObject.ActiveWatermarkProcess);
            }

            if(requestObject.IsSetAdiFilename())
            {
                context.Writer.WritePropertyName("adiFilename");
                context.Writer.WriteStringValue(requestObject.AdiFilename);
            }

            if(requestObject.IsSetAssetId())
            {
                context.Writer.WritePropertyName("assetId");
                context.Writer.WriteStringValue(requestObject.AssetId);
            }

            if(requestObject.IsSetAssetName())
            {
                context.Writer.WritePropertyName("assetName");
                context.Writer.WriteStringValue(requestObject.AssetName);
            }

            if(requestObject.IsSetCbetSourceId())
            {
                context.Writer.WritePropertyName("cbetSourceId");
                context.Writer.WriteStringValue(requestObject.CbetSourceId);
            }

            if(requestObject.IsSetEpisodeId())
            {
                context.Writer.WritePropertyName("episodeId");
                context.Writer.WriteStringValue(requestObject.EpisodeId);
            }

            if(requestObject.IsSetMetadataDestination())
            {
                context.Writer.WritePropertyName("metadataDestination");
                context.Writer.WriteStringValue(requestObject.MetadataDestination);
            }

            if(requestObject.IsSetSourceId())
            {
                context.Writer.WritePropertyName("sourceId");
                context.Writer.WriteNumberValue(requestObject.SourceId.Value);
            }

            if(requestObject.IsSetSourceWatermarkStatus())
            {
                context.Writer.WritePropertyName("sourceWatermarkStatus");
                context.Writer.WriteStringValue(requestObject.SourceWatermarkStatus);
            }

            if(requestObject.IsSetTicServerUrl())
            {
                context.Writer.WritePropertyName("ticServerUrl");
                context.Writer.WriteStringValue(requestObject.TicServerUrl);
            }

            if(requestObject.IsSetUniqueTicPerAudioTrack())
            {
                context.Writer.WritePropertyName("uniqueTicPerAudioTrack");
                context.Writer.WriteStringValue(requestObject.UniqueTicPerAudioTrack);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NielsenNonLinearWatermarkSettingsMarshaller Instance = new NielsenNonLinearWatermarkSettingsMarshaller();

    }
}