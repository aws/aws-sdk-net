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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuleAction Object
    /// </summary>  
    public class RuleActionUnmarshaller : IJsonUnmarshaller<RuleAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RuleAction Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RuleAction unmarshalledObject = new RuleAction();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AddHeader", targetDepth))
                {
                    var unmarshaller = AddHeaderActionUnmarshaller.Instance;
                    unmarshalledObject.AddHeader = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Archive", targetDepth))
                {
                    var unmarshaller = ArchiveActionUnmarshaller.Instance;
                    unmarshalledObject.Archive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeliverToMailbox", targetDepth))
                {
                    var unmarshaller = DeliverToMailboxActionUnmarshaller.Instance;
                    unmarshalledObject.DeliverToMailbox = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeliverToQBusiness", targetDepth))
                {
                    var unmarshaller = DeliverToQBusinessActionUnmarshaller.Instance;
                    unmarshalledObject.DeliverToQBusiness = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Drop", targetDepth))
                {
                    var unmarshaller = DropActionUnmarshaller.Instance;
                    unmarshalledObject.Drop = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PublishToSns", targetDepth))
                {
                    var unmarshaller = SnsActionUnmarshaller.Instance;
                    unmarshalledObject.PublishToSns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Relay", targetDepth))
                {
                    var unmarshaller = RelayActionUnmarshaller.Instance;
                    unmarshalledObject.Relay = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReplaceRecipient", targetDepth))
                {
                    var unmarshaller = ReplaceRecipientActionUnmarshaller.Instance;
                    unmarshalledObject.ReplaceRecipient = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Send", targetDepth))
                {
                    var unmarshaller = SendActionUnmarshaller.Instance;
                    unmarshalledObject.Send = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WriteToS3", targetDepth))
                {
                    var unmarshaller = S3ActionUnmarshaller.Instance;
                    unmarshalledObject.WriteToS3 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RuleActionUnmarshaller _instance = new RuleActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuleActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}