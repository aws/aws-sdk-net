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
    /// CaptionSource Marshaller
    /// </summary>       
    public class CaptionSourceMarshaller : IRequestMarshaller<CaptionSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CaptionSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("Encryption");
                context.Writer.WriteObjectStart();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("Key");
                context.Writer.Write(requestObject.Key);
            }

            if(requestObject.IsSetLabel())
            {
                context.Writer.WritePropertyName("Label");
                context.Writer.Write(requestObject.Label);
            }

            if(requestObject.IsSetLanguage())
            {
                context.Writer.WritePropertyName("Language");
                context.Writer.Write(requestObject.Language);
            }

            if(requestObject.IsSetTimeOffset())
            {
                context.Writer.WritePropertyName("TimeOffset");
                context.Writer.Write(requestObject.TimeOffset);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CaptionSourceMarshaller Instance = new CaptionSourceMarshaller();

    }
}