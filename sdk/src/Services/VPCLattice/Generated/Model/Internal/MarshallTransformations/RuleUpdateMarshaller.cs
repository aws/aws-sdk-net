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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleUpdate Marshaller
    /// </summary>
    public class RuleUpdateMarshaller : IRequestMarshaller<RuleUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteObjectStart();

                var marshaller = RuleActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Action, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMatch())
            {
                context.Writer.WritePropertyName("match");
                context.Writer.WriteObjectStart();

                var marshaller = RuleMatchMarshaller.Instance;
                marshaller.Marshall(requestObject.Match, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.Write(requestObject.Priority);
            }

            if(requestObject.IsSetRuleIdentifier())
            {
                context.Writer.WritePropertyName("ruleIdentifier");
                context.Writer.Write(requestObject.RuleIdentifier);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleUpdateMarshaller Instance = new RuleUpdateMarshaller();

    }
}