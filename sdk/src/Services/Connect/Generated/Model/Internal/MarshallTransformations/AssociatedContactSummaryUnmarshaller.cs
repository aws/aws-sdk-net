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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssociatedContactSummary Object
    /// </summary>  
    public class AssociatedContactSummaryUnmarshaller : IUnmarshaller<AssociatedContactSummary, XmlUnmarshallerContext>, IUnmarshaller<AssociatedContactSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssociatedContactSummary IUnmarshaller<AssociatedContactSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AssociatedContactSummary Unmarshall(JsonUnmarshallerContext context)
        {
            AssociatedContactSummary unmarshalledObject = new AssociatedContactSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Channel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Channel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContactArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContactArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisconnectTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.DisconnectTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitialContactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InitialContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitiationMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InitiationMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitiationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.InitiationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreviousContactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreviousContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedContactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelatedContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AssociatedContactSummaryUnmarshaller _instance = new AssociatedContactSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociatedContactSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}