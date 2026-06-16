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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReferenceSummary Object
    /// </summary>  
    public class ReferenceSummaryUnmarshaller : IJsonUnmarshaller<ReferenceSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ReferenceSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ReferenceSummary unmarshalledObject = new ReferenceSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Attachment", targetDepth, ref reader))
                {
                    var unmarshaller = AttachmentReferenceUnmarshaller.Instance;
                    unmarshalledObject.Attachment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Date", targetDepth, ref reader))
                {
                    var unmarshaller = DateReferenceUnmarshaller.Instance;
                    unmarshalledObject.Date = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Email", targetDepth, ref reader))
                {
                    var unmarshaller = EmailReferenceUnmarshaller.Instance;
                    unmarshalledObject.Email = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EmailMessage", targetDepth, ref reader))
                {
                    var unmarshaller = EmailMessageReferenceUnmarshaller.Instance;
                    unmarshalledObject.EmailMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EmailMessagePlainText", targetDepth, ref reader))
                {
                    var unmarshaller = EmailMessageReferenceUnmarshaller.Instance;
                    unmarshalledObject.EmailMessagePlainText = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EmailMessagePlainTextRedacted", targetDepth, ref reader))
                {
                    var unmarshaller = EmailMessageReferenceUnmarshaller.Instance;
                    unmarshalledObject.EmailMessagePlainTextRedacted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EmailMessageRedacted", targetDepth, ref reader))
                {
                    var unmarshaller = EmailMessageReferenceUnmarshaller.Instance;
                    unmarshalledObject.EmailMessageRedacted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Number", targetDepth, ref reader))
                {
                    var unmarshaller = NumberReferenceUnmarshaller.Instance;
                    unmarshalledObject.Number = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("String", targetDepth, ref reader))
                {
                    var unmarshaller = StringReferenceUnmarshaller.Instance;
                    unmarshalledObject.String = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Url", targetDepth, ref reader))
                {
                    var unmarshaller = UrlReferenceUnmarshaller.Instance;
                    unmarshalledObject.Url = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ReferenceSummaryUnmarshaller _instance = new ReferenceSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReferenceSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}