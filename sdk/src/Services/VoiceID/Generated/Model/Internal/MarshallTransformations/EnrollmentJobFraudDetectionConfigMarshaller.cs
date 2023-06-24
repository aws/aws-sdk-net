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
using ThirdParty.Json.LitJson;

namespace Amazon.VoiceID.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EnrollmentJobFraudDetectionConfig Marshaller
    /// </summary>
    public class EnrollmentJobFraudDetectionConfigMarshaller : IRequestMarshaller<EnrollmentJobFraudDetectionConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EnrollmentJobFraudDetectionConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFraudDetectionAction())
            {
                context.Writer.WritePropertyName("FraudDetectionAction");
                context.Writer.Write(requestObject.FraudDetectionAction);
            }

            if(requestObject.IsSetRiskThreshold())
            {
                context.Writer.WritePropertyName("RiskThreshold");
                context.Writer.Write(requestObject.RiskThreshold);
            }

            if(requestObject.IsSetWatchlistIds())
            {
                context.Writer.WritePropertyName("WatchlistIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWatchlistIdsListValue in requestObject.WatchlistIds)
                {
                        context.Writer.Write(requestObjectWatchlistIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EnrollmentJobFraudDetectionConfigMarshaller Instance = new EnrollmentJobFraudDetectionConfigMarshaller();

    }
}