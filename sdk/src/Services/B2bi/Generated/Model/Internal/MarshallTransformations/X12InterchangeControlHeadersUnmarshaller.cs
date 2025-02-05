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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for X12InterchangeControlHeaders Object
    /// </summary>  
    public class X12InterchangeControlHeadersUnmarshaller : IJsonUnmarshaller<X12InterchangeControlHeaders, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public X12InterchangeControlHeaders Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            X12InterchangeControlHeaders unmarshalledObject = new X12InterchangeControlHeaders();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("acknowledgmentRequestedCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AcknowledgmentRequestedCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("receiverId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReceiverId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("receiverIdQualifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReceiverIdQualifier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("repetitionSeparator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RepetitionSeparator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("senderId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SenderId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("senderIdQualifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SenderIdQualifier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("usageIndicatorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UsageIndicatorCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static X12InterchangeControlHeadersUnmarshaller _instance = new X12InterchangeControlHeadersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static X12InterchangeControlHeadersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}