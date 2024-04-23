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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Message Object
    /// </summary>  
    public class MessageUnmarshaller : IUnmarshaller<Message, XmlUnmarshallerContext>, IUnmarshaller<Message, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Message IUnmarshaller<Message, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Message Unmarshall(JsonUnmarshallerContext context)
        {
            Message unmarshalledObject = new Message();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionExecution", targetDepth))
                {
                    var unmarshaller = ActionExecutionUnmarshaller.Instance;
                    unmarshalledObject.ActionExecution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("actionReview", targetDepth))
                {
                    var unmarshaller = ActionReviewUnmarshaller.Instance;
                    unmarshalledObject.ActionReview = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("attachments", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AttachmentOutput, AttachmentOutputUnmarshaller>(AttachmentOutputUnmarshaller.Instance);
                    unmarshalledObject.Attachments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("body", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Body = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messageId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MessageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceAttribution", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SourceAttribution, SourceAttributionUnmarshaller>(SourceAttributionUnmarshaller.Instance);
                    unmarshalledObject.SourceAttribution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("time", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Time = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MessageUnmarshaller _instance = new MessageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MessageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618