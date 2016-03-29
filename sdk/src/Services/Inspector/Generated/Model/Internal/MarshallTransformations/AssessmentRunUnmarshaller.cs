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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssessmentRun Object
    /// </summary>  
    public class AssessmentRunUnmarshaller : IUnmarshaller<AssessmentRun, XmlUnmarshallerContext>, IUnmarshaller<AssessmentRun, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssessmentRun IUnmarshaller<AssessmentRun, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AssessmentRun Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AssessmentRun unmarshalledObject = new AssessmentRun();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assessmentTemplateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssessmentTemplateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("completedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CompletedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataCollected", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DataCollected = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("durationInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DurationInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("notifications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssessmentRunNotification, AssessmentRunNotificationUnmarshaller>(AssessmentRunNotificationUnmarshaller.Instance);
                    unmarshalledObject.Notifications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rulesPackageArns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RulesPackageArns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stateChangedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StateChangedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stateChanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssessmentRunStateChange, AssessmentRunStateChangeUnmarshaller>(AssessmentRunStateChangeUnmarshaller.Instance);
                    unmarshalledObject.StateChanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userAttributesForFindings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Attribute, AttributeUnmarshaller>(AttributeUnmarshaller.Instance);
                    unmarshalledObject.UserAttributesForFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AssessmentRunUnmarshaller _instance = new AssessmentRunUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssessmentRunUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}