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
    /// Ac3Settings Marshaller
    /// </summary>       
    public class Ac3SettingsMarshaller : IRequestMarshaller<Ac3Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Ac3Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBitrate())
            {
                context.Writer.WritePropertyName("bitrate");
                context.Writer.Write(requestObject.Bitrate);
            }

            if(requestObject.IsSetBitstreamMode())
            {
                context.Writer.WritePropertyName("bitstreamMode");
                context.Writer.Write(requestObject.BitstreamMode);
            }

            if(requestObject.IsSetCodingMode())
            {
                context.Writer.WritePropertyName("codingMode");
                context.Writer.Write(requestObject.CodingMode);
            }

            if(requestObject.IsSetDialnorm())
            {
                context.Writer.WritePropertyName("dialnorm");
                context.Writer.Write(requestObject.Dialnorm);
            }

            if(requestObject.IsSetDrcProfile())
            {
                context.Writer.WritePropertyName("drcProfile");
                context.Writer.Write(requestObject.DrcProfile);
            }

            if(requestObject.IsSetLfeFilter())
            {
                context.Writer.WritePropertyName("lfeFilter");
                context.Writer.Write(requestObject.LfeFilter);
            }

            if(requestObject.IsSetMetadataControl())
            {
                context.Writer.WritePropertyName("metadataControl");
                context.Writer.Write(requestObject.MetadataControl);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static Ac3SettingsMarshaller Instance = new Ac3SettingsMarshaller();

    }
}