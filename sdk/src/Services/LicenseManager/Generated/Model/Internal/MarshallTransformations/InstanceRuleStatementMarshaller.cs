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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceRuleStatement Marshaller
    /// </summary>
    public class InstanceRuleStatementMarshaller : IRequestMarshaller<InstanceRuleStatement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceRuleStatement requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAndRuleStatement())
            {
                context.Writer.WritePropertyName("AndRuleStatement");
                context.Writer.WriteStartObject();

                var marshaller = AndRuleStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.AndRuleStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMatchingRuleStatement())
            {
                context.Writer.WritePropertyName("MatchingRuleStatement");
                context.Writer.WriteStartObject();

                var marshaller = MatchingRuleStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.MatchingRuleStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOrRuleStatement())
            {
                context.Writer.WritePropertyName("OrRuleStatement");
                context.Writer.WriteStartObject();

                var marshaller = OrRuleStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.OrRuleStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScriptRuleStatement())
            {
                context.Writer.WritePropertyName("ScriptRuleStatement");
                context.Writer.WriteStartObject();

                var marshaller = ScriptRuleStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.ScriptRuleStatement, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceRuleStatementMarshaller Instance = new InstanceRuleStatementMarshaller();

    }
}