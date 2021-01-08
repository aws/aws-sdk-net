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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJobPlaylist Marshaller
    /// </summary>       
    public class CreateJobPlaylistMarshaller : IRequestMarshaller<CreateJobPlaylist, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateJobPlaylist requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.Write(requestObject.Format);
            }

            if(requestObject.IsSetHlsContentProtection())
            {
                context.Writer.WritePropertyName("HlsContentProtection");
                context.Writer.WriteObjectStart();

                var marshaller = HlsContentProtectionMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsContentProtection, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOutputKeys())
            {
                context.Writer.WritePropertyName("OutputKeys");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputKeysListValue in requestObject.OutputKeys)
                {
                        context.Writer.Write(requestObjectOutputKeysListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPlayReadyDrm())
            {
                context.Writer.WritePropertyName("PlayReadyDrm");
                context.Writer.WriteObjectStart();

                var marshaller = PlayReadyDrmMarshaller.Instance;
                marshaller.Marshall(requestObject.PlayReadyDrm, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CreateJobPlaylistMarshaller Instance = new CreateJobPlaylistMarshaller();

    }
}