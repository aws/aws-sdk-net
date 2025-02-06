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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CrossRegionCopyRule Marshaller
    /// </summary>
    public class CrossRegionCopyRuleMarshaller : IRequestMarshaller<CrossRegionCopyRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CrossRegionCopyRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCmkArn())
            {
                context.Writer.WritePropertyName("CmkArn");
                context.Writer.WriteStringValue(requestObject.CmkArn);
            }

            if(requestObject.IsSetCopyTags())
            {
                context.Writer.WritePropertyName("CopyTags");
                context.Writer.WriteBooleanValue(requestObject.CopyTags.Value);
            }

            if(requestObject.IsSetDeprecateRule())
            {
                context.Writer.WritePropertyName("DeprecateRule");
                context.Writer.WriteStartObject();

                var marshaller = CrossRegionCopyDeprecateRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.DeprecateRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("Encrypted");
                context.Writer.WriteBooleanValue(requestObject.Encrypted.Value);
            }

            if(requestObject.IsSetRetainRule())
            {
                context.Writer.WritePropertyName("RetainRule");
                context.Writer.WriteStartObject();

                var marshaller = CrossRegionCopyRetainRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.RetainRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTarget())
            {
                context.Writer.WritePropertyName("Target");
                context.Writer.WriteStringValue(requestObject.Target);
            }

            if(requestObject.IsSetTargetRegion())
            {
                context.Writer.WritePropertyName("TargetRegion");
                context.Writer.WriteStringValue(requestObject.TargetRegion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CrossRegionCopyRuleMarshaller Instance = new CrossRegionCopyRuleMarshaller();

    }
}