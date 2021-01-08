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
    /// JobInput Marshaller
    /// </summary>       
    public class JobInputMarshaller : IRequestMarshaller<JobInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAspectRatio())
            {
                context.Writer.WritePropertyName("AspectRatio");
                context.Writer.Write(requestObject.AspectRatio);
            }

            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("Container");
                context.Writer.Write(requestObject.Container);
            }

            if(requestObject.IsSetDetectedProperties())
            {
                context.Writer.WritePropertyName("DetectedProperties");
                context.Writer.WriteObjectStart();

                var marshaller = DetectedPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.DetectedProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("Encryption");
                context.Writer.WriteObjectStart();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFrameRate())
            {
                context.Writer.WritePropertyName("FrameRate");
                context.Writer.Write(requestObject.FrameRate);
            }

            if(requestObject.IsSetInputCaptions())
            {
                context.Writer.WritePropertyName("InputCaptions");
                context.Writer.WriteObjectStart();

                var marshaller = InputCaptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.InputCaptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInterlaced())
            {
                context.Writer.WritePropertyName("Interlaced");
                context.Writer.Write(requestObject.Interlaced);
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("Key");
                context.Writer.Write(requestObject.Key);
            }

            if(requestObject.IsSetResolution())
            {
                context.Writer.WritePropertyName("Resolution");
                context.Writer.Write(requestObject.Resolution);
            }

            if(requestObject.IsSetTimeSpan())
            {
                context.Writer.WritePropertyName("TimeSpan");
                context.Writer.WriteObjectStart();

                var marshaller = TimeSpanMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeSpan, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static JobInputMarshaller Instance = new JobInputMarshaller();

    }
}