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
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AudioCodecOptions Marshaller
    /// </summary>
    public class AudioCodecOptionsMarshaller : IRequestMarshaller<AudioCodecOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudioCodecOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBitDepth())
            {
                context.Writer.WritePropertyName("BitDepth");
                context.Writer.WriteStringValue(requestObject.BitDepth);
            }

            if(requestObject.IsSetBitOrder())
            {
                context.Writer.WritePropertyName("BitOrder");
                context.Writer.WriteStringValue(requestObject.BitOrder);
            }

            if(requestObject.IsSetProfile())
            {
                context.Writer.WritePropertyName("Profile");
                context.Writer.WriteStringValue(requestObject.Profile);
            }

            if(requestObject.IsSetSigned())
            {
                context.Writer.WritePropertyName("Signed");
                context.Writer.WriteStringValue(requestObject.Signed);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AudioCodecOptionsMarshaller Instance = new AudioCodecOptionsMarshaller();

    }
}