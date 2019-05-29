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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTThingsGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTThingsGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SystemInstanceDescription Object
    /// </summary>  
    public class SystemInstanceDescriptionUnmarshaller : IUnmarshaller<SystemInstanceDescription, XmlUnmarshallerContext>, IUnmarshaller<SystemInstanceDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SystemInstanceDescription IUnmarshaller<SystemInstanceDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SystemInstanceDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SystemInstanceDescription unmarshalledObject = new SystemInstanceDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("definition", targetDepth))
                {
                    var unmarshaller = DefinitionDocumentUnmarshaller.Instance;
                    unmarshalledObject.Definition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowActionsRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlowActionsRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricsConfiguration", targetDepth))
                {
                    var unmarshaller = MetricsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.MetricsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3BucketName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3BucketName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("summary", targetDepth))
                {
                    var unmarshaller = SystemInstanceSummaryUnmarshaller.Instance;
                    unmarshalledObject.Summary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("validatedDependencyRevisions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DependencyRevision, DependencyRevisionUnmarshaller>(DependencyRevisionUnmarshaller.Instance);
                    unmarshalledObject.ValidatedDependencyRevisions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("validatedNamespaceVersion", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ValidatedNamespaceVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SystemInstanceDescriptionUnmarshaller _instance = new SystemInstanceDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SystemInstanceDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}