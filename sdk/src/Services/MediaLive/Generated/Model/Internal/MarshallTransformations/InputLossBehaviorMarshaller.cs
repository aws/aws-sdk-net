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
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InputLossBehavior Marshaller
    /// </summary>
    public class InputLossBehaviorMarshaller : IRequestMarshaller<InputLossBehavior, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InputLossBehavior requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlackFrameMsec())
            {
                context.Writer.WritePropertyName("blackFrameMsec");
                context.Writer.WriteNumberValue(requestObject.BlackFrameMsec.Value);
            }

            if(requestObject.IsSetInputLossImageColor())
            {
                context.Writer.WritePropertyName("inputLossImageColor");
                context.Writer.WriteStringValue(requestObject.InputLossImageColor);
            }

            if(requestObject.IsSetInputLossImageSlate())
            {
                context.Writer.WritePropertyName("inputLossImageSlate");
                context.Writer.WriteStartObject();

                var marshaller = InputLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.InputLossImageSlate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputLossImageType())
            {
                context.Writer.WritePropertyName("inputLossImageType");
                context.Writer.WriteStringValue(requestObject.InputLossImageType);
            }

            if(requestObject.IsSetRepeatFrameMsec())
            {
                context.Writer.WritePropertyName("repeatFrameMsec");
                context.Writer.WriteNumberValue(requestObject.RepeatFrameMsec.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputLossBehaviorMarshaller Instance = new InputLossBehaviorMarshaller();

    }
}