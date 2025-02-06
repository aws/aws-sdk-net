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
    /// AWSManagedRulesACFPRuleSet Marshaller
    /// </summary>
    public class AWSManagedRulesACFPRuleSetMarshaller : IRequestMarshaller<AWSManagedRulesACFPRuleSet, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AWSManagedRulesACFPRuleSet requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreationPath())
            {
                context.Writer.WritePropertyName("CreationPath");
                context.Writer.WriteStringValue(requestObject.CreationPath);
            }

            if(requestObject.IsSetEnableRegexInPath())
            {
                context.Writer.WritePropertyName("EnableRegexInPath");
                context.Writer.WriteBooleanValue(requestObject.EnableRegexInPath.Value);
            }

            if(requestObject.IsSetRegistrationPagePath())
            {
                context.Writer.WritePropertyName("RegistrationPagePath");
                context.Writer.WriteStringValue(requestObject.RegistrationPagePath);
            }

            if(requestObject.IsSetRequestInspection())
            {
                context.Writer.WritePropertyName("RequestInspection");
                context.Writer.WriteStartObject();

                var marshaller = RequestInspectionACFPMarshaller.Instance;
                marshaller.Marshall(requestObject.RequestInspection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResponseInspection())
            {
                context.Writer.WritePropertyName("ResponseInspection");
                context.Writer.WriteStartObject();

                var marshaller = ResponseInspectionMarshaller.Instance;
                marshaller.Marshall(requestObject.ResponseInspection, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AWSManagedRulesACFPRuleSetMarshaller Instance = new AWSManagedRulesACFPRuleSetMarshaller();

    }
}