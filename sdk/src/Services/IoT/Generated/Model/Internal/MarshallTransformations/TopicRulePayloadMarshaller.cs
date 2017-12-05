/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicRulePayload Marshaller
    /// </summary>       
    public class TopicRulePayloadMarshaller : IRequestMarshaller<TopicRulePayload, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicRulePayload requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("actions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAwsIotSqlVersion())
            {
                context.Writer.WritePropertyName("awsIotSqlVersion");
                context.Writer.Write(requestObject.AwsIotSqlVersion);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetErrorAction())
            {
                context.Writer.WritePropertyName("errorAction");
                context.Writer.WriteObjectStart();

                var marshaller = ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.ErrorAction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRuleDisabled())
            {
                context.Writer.WritePropertyName("ruleDisabled");
                context.Writer.Write(requestObject.RuleDisabled);
            }

            if(requestObject.IsSetSql())
            {
                context.Writer.WritePropertyName("sql");
                context.Writer.Write(requestObject.Sql);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TopicRulePayloadMarshaller Instance = new TopicRulePayloadMarshaller();

    }
}