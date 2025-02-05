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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AudioAndDTMFInputSpecification Marshaller
    /// </summary>
    public class AudioAndDTMFInputSpecificationMarshaller : IRequestMarshaller<AudioAndDTMFInputSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudioAndDTMFInputSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioSpecification())
            {
                context.Writer.WritePropertyName("audioSpecification");
                context.Writer.WriteStartObject();

                var marshaller = AudioSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.AudioSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDtmfSpecification())
            {
                context.Writer.WritePropertyName("dtmfSpecification");
                context.Writer.WriteStartObject();

                var marshaller = DTMFSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.DtmfSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStartTimeoutMs())
            {
                context.Writer.WritePropertyName("startTimeoutMs");
                context.Writer.WriteNumberValue(requestObject.StartTimeoutMs.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AudioAndDTMFInputSpecificationMarshaller Instance = new AudioAndDTMFInputSpecificationMarshaller();

    }
}