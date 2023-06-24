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
    /// AwsWafv2WebAclDetails Marshaller
    /// </summary>
    public class AwsWafv2WebAclDetailsMarshaller : IRequestMarshaller<AwsWafv2WebAclDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsWafv2WebAclDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.Write(requestObject.Arn);
            }

            if(requestObject.IsSetCapacity())
            {
                context.Writer.WritePropertyName("Capacity");
                context.Writer.Write(requestObject.Capacity);
            }

            if(requestObject.IsSetCaptchaConfig())
            {
                context.Writer.WritePropertyName("CaptchaConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2WebAclCaptchaConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CaptchaConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultAction())
            {
                context.Writer.WritePropertyName("DefaultAction");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2WebAclActionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultAction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetManagedbyFirewallManager())
            {
                context.Writer.WritePropertyName("ManagedbyFirewallManager");
                context.Writer.Write(requestObject.ManagedbyFirewallManager);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRulesListValue in requestObject.Rules)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsWafv2RulesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVisibilityConfig())
            {
                context.Writer.WritePropertyName("VisibilityConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2VisibilityConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.VisibilityConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsWafv2WebAclDetailsMarshaller Instance = new AwsWafv2WebAclDetailsMarshaller();

    }
}