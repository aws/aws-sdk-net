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
            if(requestObject.IsSetActiveWatermarkProcess())
            {
                context.Writer.WritePropertyName("activeWatermarkProcess");
                context.Writer.Write(requestObject.ActiveWatermarkProcess);
            }

            if(requestObject.IsSetAdiFilename())
            {
                context.Writer.WritePropertyName("adiFilename");
                context.Writer.Write(requestObject.AdiFilename);
            }

            if(requestObject.IsSetAssetId())
            {
                context.Writer.WritePropertyName("assetId");
                context.Writer.Write(requestObject.AssetId);
            }

            if(requestObject.IsSetAssetName())
            {
                context.Writer.WritePropertyName("assetName");
                context.Writer.Write(requestObject.AssetName);
            }

            if(requestObject.IsSetCbetSourceId())
            {
                context.Writer.WritePropertyName("cbetSourceId");
                context.Writer.Write(requestObject.CbetSourceId);
            }

            if(requestObject.IsSetEpisodeId())
            {
                context.Writer.WritePropertyName("episodeId");
                context.Writer.Write(requestObject.EpisodeId);
            }

            if(requestObject.IsSetMetadataDestination())
            {
                context.Writer.WritePropertyName("metadataDestination");
                context.Writer.Write(requestObject.MetadataDestination);
            }

            if(requestObject.IsSetSourceId())
            {
                context.Writer.WritePropertyName("sourceId");
                context.Writer.Write(requestObject.SourceId);
            }

            if(requestObject.IsSetSourceWatermarkStatus())
            {
                context.Writer.WritePropertyName("sourceWatermarkStatus");
                context.Writer.Write(requestObject.SourceWatermarkStatus);
            }

            if(requestObject.IsSetTicServerUrl())
            {
                context.Writer.WritePropertyName("ticServerUrl");
                context.Writer.Write(requestObject.TicServerUrl);
            }

            if(requestObject.IsSetUniqueTicPerAudioTrack())
            {
                context.Writer.WritePropertyName("uniqueTicPerAudioTrack");
                context.Writer.Write(requestObject.UniqueTicPerAudioTrack);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static NielsenNonLinearWatermarkSettingsMarshaller Instance = new NielsenNonLinearWatermarkSettingsMarshaller();

    }
}