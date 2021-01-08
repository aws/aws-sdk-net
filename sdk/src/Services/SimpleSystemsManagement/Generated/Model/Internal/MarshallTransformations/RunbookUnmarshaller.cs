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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Runbook Object
    /// </summary>  
    public class RunbookUnmarshaller : IUnmarshaller<Runbook, XmlUnmarshallerContext>, IUnmarshaller<Runbook, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Runbook IUnmarshaller<Runbook, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Runbook Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Runbook unmarshalledObject = new Runbook();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DocumentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxConcurrency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxConcurrency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxErrors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetLocations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TargetLocation, TargetLocationUnmarshaller>(TargetLocationUnmarshaller.Instance);
                    unmarshalledObject.TargetLocations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetParameterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetParameterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Targets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Target, TargetUnmarshaller>(TargetUnmarshaller.Instance);
                    unmarshalledObject.Targets = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RunbookUnmarshaller _instance = new RunbookUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RunbookUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}