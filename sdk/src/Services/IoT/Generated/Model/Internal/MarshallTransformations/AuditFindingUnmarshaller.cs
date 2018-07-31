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
using System.Net;
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
    /// Response Unmarshaller for AuditFinding Object
    /// </summary>  
    public class AuditFindingUnmarshaller : IUnmarshaller<AuditFinding, XmlUnmarshallerContext>, IUnmarshaller<AuditFinding, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AuditFinding IUnmarshaller<AuditFinding, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AuditFinding Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AuditFinding unmarshalledObject = new AuditFinding();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("checkName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CheckName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("findingTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.FindingTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nonCompliantResource", targetDepth))
                {
                    var unmarshaller = NonCompliantResourceUnmarshaller.Instance;
                    unmarshalledObject.NonCompliantResource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reasonForNonCompliance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReasonForNonCompliance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reasonForNonComplianceCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReasonForNonComplianceCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relatedResources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RelatedResource, RelatedResourceUnmarshaller>(RelatedResourceUnmarshaller.Instance);
                    unmarshalledObject.RelatedResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("severity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TaskStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AuditFindingUnmarshaller _instance = new AuditFindingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuditFindingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}