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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VoiceID.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.VoiceID.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegistrationConfig Marshaller
    /// </summary>
    public class RegistrationConfigMarshaller : IRequestMarshaller<RegistrationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RegistrationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDuplicateRegistrationAction())
            {
                context.Writer.WritePropertyName("DuplicateRegistrationAction");
                context.Writer.WriteStringValue(requestObject.DuplicateRegistrationAction);
            }

            if(requestObject.IsSetFraudsterSimilarityThreshold())
            {
                context.Writer.WritePropertyName("FraudsterSimilarityThreshold");
                context.Writer.WriteNumberValue(requestObject.FraudsterSimilarityThreshold.Value);
            }

            if(requestObject.IsSetWatchlistIds())
            {
                context.Writer.WritePropertyName("WatchlistIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWatchlistIdsListValue in requestObject.WatchlistIds)
                {
                        context.Writer.WriteStringValue(requestObjectWatchlistIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RegistrationConfigMarshaller Instance = new RegistrationConfigMarshaller();

    }
}