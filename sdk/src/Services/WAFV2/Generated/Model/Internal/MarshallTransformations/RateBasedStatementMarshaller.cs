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
using ThirdParty.Json.LitJson;

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RateBasedStatement Marshaller
    /// </summary>
    public class RateBasedStatementMarshaller : IRequestMarshaller<RateBasedStatement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RateBasedStatement requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAggregateKeyType())
            {
                context.Writer.WritePropertyName("AggregateKeyType");
                context.Writer.Write(requestObject.AggregateKeyType);
            }

            if(requestObject.IsSetCustomKeys())
            {
                context.Writer.WritePropertyName("CustomKeys");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCustomKeysListValue in requestObject.CustomKeys)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RateBasedStatementCustomKeyMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomKeysListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetForwardedIPConfig())
            {
                context.Writer.WritePropertyName("ForwardedIPConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ForwardedIPConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ForwardedIPConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLimit())
            {
                context.Writer.WritePropertyName("Limit");
                context.Writer.Write(requestObject.Limit);
            }

            if(requestObject.IsSetScopeDownStatement())
            {
                context.Writer.WritePropertyName("ScopeDownStatement");
                context.Writer.WriteObjectStart();

                var marshaller = StatementMarshaller.Instance;
                marshaller.Marshall(requestObject.ScopeDownStatement, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RateBasedStatementMarshaller Instance = new RateBasedStatementMarshaller();

    }
}