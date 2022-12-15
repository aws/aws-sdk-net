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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsWafv2RulesActionDetails Marshaller
    /// </summary>
    public class AwsWafv2RulesActionDetailsMarshaller : IRequestMarshaller<AwsWafv2RulesActionDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsWafv2RulesActionDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllow())
            {
                context.Writer.WritePropertyName("Allow");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2ActionAllowDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Allow, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBlock())
            {
                context.Writer.WritePropertyName("Block");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2ActionBlockDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Block, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCaptcha())
            {
                context.Writer.WritePropertyName("Captcha");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2RulesActionCaptchaDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Captcha, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCount())
            {
                context.Writer.WritePropertyName("Count");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2RulesActionCountDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Count, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsWafv2RulesActionDetailsMarshaller Instance = new AwsWafv2RulesActionDetailsMarshaller();

    }
}