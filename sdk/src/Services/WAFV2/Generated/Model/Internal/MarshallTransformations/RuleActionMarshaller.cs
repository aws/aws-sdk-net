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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleAction Marshaller
    /// </summary>
    public class RuleActionMarshaller : IRequestMarshaller<RuleAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllow())
            {
                context.Writer.WritePropertyName("Allow");
                context.Writer.WriteStartObject();

                var marshaller = AllowActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Allow, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBlock())
            {
                context.Writer.WritePropertyName("Block");
                context.Writer.WriteStartObject();

                var marshaller = BlockActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Block, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCaptcha())
            {
                context.Writer.WritePropertyName("Captcha");
                context.Writer.WriteStartObject();

                var marshaller = CaptchaActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Captcha, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetChallenge())
            {
                context.Writer.WritePropertyName("Challenge");
                context.Writer.WriteStartObject();

                var marshaller = ChallengeActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Challenge, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCount())
            {
                context.Writer.WritePropertyName("Count");
                context.Writer.WriteStartObject();

                var marshaller = CountActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Count, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleActionMarshaller Instance = new RuleActionMarshaller();

    }
}