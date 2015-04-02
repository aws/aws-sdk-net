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
    /// PlayReadyDrm Marshaller
    /// </summary>       
    public class PlayReadyDrmMarshaller : IRequestMarshaller<PlayReadyDrm, JsonMarshallerContext> 
    {
        public void Marshall(PlayReadyDrm requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.Write(requestObject.Format);
            }

            if(requestObject.IsSetInitializationVector())
            {
                context.Writer.WritePropertyName("InitializationVector");
                context.Writer.Write(requestObject.InitializationVector);
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("Key");
                context.Writer.Write(requestObject.Key);
            }

            if(requestObject.IsSetKeyId())
            {
                context.Writer.WritePropertyName("KeyId");
                context.Writer.Write(requestObject.KeyId);
            }

            if(requestObject.IsSetKeyMd5())
            {
                context.Writer.WritePropertyName("KeyMd5");
                context.Writer.Write(requestObject.KeyMd5);
            }

            if(requestObject.IsSetLicenseAcquisitionUrl())
            {
                context.Writer.WritePropertyName("LicenseAcquisitionUrl");
                context.Writer.Write(requestObject.LicenseAcquisitionUrl);
            }

        }

        public readonly static PlayReadyDrmMarshaller Instance = new PlayReadyDrmMarshaller();

    }
}