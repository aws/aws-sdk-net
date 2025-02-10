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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TelephonyChannelSubtypeParameters Marshaller
    /// </summary>
    public class TelephonyChannelSubtypeParametersMarshaller : IRequestMarshaller<TelephonyChannelSubtypeParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TelephonyChannelSubtypeParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnswerMachineDetectionConfig())
            {
                context.Writer.WritePropertyName("answerMachineDetectionConfig");
                context.Writer.WriteStartObject();

                var marshaller = AnswerMachineDetectionConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AnswerMachineDetectionConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConnectSourcePhoneNumber())
            {
                context.Writer.WritePropertyName("connectSourcePhoneNumber");
                context.Writer.WriteStringValue(requestObject.ConnectSourcePhoneNumber);
            }

            if(requestObject.IsSetDestinationPhoneNumber())
            {
                context.Writer.WritePropertyName("destinationPhoneNumber");
                context.Writer.WriteStringValue(requestObject.DestinationPhoneNumber);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TelephonyChannelSubtypeParametersMarshaller Instance = new TelephonyChannelSubtypeParametersMarshaller();

    }
}