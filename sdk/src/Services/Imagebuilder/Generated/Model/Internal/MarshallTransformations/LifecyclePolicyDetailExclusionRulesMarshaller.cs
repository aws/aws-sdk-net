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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LifecyclePolicyDetailExclusionRules Marshaller
    /// </summary>
    public class LifecyclePolicyDetailExclusionRulesMarshaller : IRequestMarshaller<LifecyclePolicyDetailExclusionRules, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LifecyclePolicyDetailExclusionRules requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmis())
            {
                context.Writer.WritePropertyName("amis");
                context.Writer.WriteObjectStart();

                var marshaller = LifecyclePolicyDetailExclusionRulesAmisMarshaller.Instance;
                marshaller.Marshall(requestObject.Amis, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTagMap())
            {
                context.Writer.WritePropertyName("tagMap");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagMapKvp in requestObject.TagMap)
                {
                    context.Writer.WritePropertyName(requestObjectTagMapKvp.Key);
                    var requestObjectTagMapValue = requestObjectTagMapKvp.Value;

                        context.Writer.Write(requestObjectTagMapValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LifecyclePolicyDetailExclusionRulesMarshaller Instance = new LifecyclePolicyDetailExclusionRulesMarshaller();

    }
}