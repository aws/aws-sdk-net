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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Activity Object
    /// </summary>  
    public class ActivityUnmarshaller : IUnmarshaller<Activity, XmlUnmarshallerContext>, IUnmarshaller<Activity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Activity IUnmarshaller<Activity, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Activity Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Activity unmarshalledObject = new Activity();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CommentMetadata", targetDepth))
                {
                    var unmarshaller = CommentMetadataUnmarshaller.Instance;
                    unmarshalledObject.CommentMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Initiator", targetDepth))
                {
                    var unmarshaller = UserMetadataUnmarshaller.Instance;
                    unmarshalledObject.Initiator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsIndirectActivity", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsIndirectActivity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OriginalParent", targetDepth))
                {
                    var unmarshaller = ResourceMetadataUnmarshaller.Instance;
                    unmarshalledObject.OriginalParent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Participants", targetDepth))
                {
                    var unmarshaller = ParticipantsUnmarshaller.Instance;
                    unmarshalledObject.Participants = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceMetadata", targetDepth))
                {
                    var unmarshaller = ResourceMetadataUnmarshaller.Instance;
                    unmarshalledObject.ResourceMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeStamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TimeStamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActivityUnmarshaller _instance = new ActivityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}