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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MembershipSummary Object
    /// </summary>  
    public class MembershipSummaryUnmarshaller : IUnmarshaller<MembershipSummary, XmlUnmarshallerContext>, IUnmarshaller<MembershipSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MembershipSummary IUnmarshaller<MembershipSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MembershipSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MembershipSummary unmarshalledObject = new MembershipSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collaborationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollaborationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collaborationCreatorAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollaborationCreatorAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collaborationCreatorDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollaborationCreatorDisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collaborationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollaborationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collaborationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollaborationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memberAbilities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MemberAbilities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MembershipSummaryUnmarshaller _instance = new MembershipSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MembershipSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}