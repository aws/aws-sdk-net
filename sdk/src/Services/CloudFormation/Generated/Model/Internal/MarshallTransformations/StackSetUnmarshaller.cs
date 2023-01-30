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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StackSet Object
    /// </summary>  
    public class StackSetUnmarshaller : IUnmarshaller<StackSet, XmlUnmarshallerContext>, IUnmarshaller<StackSet, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StackSet Unmarshall(XmlUnmarshallerContext context)
        {
            StackSet unmarshalledObject = new StackSet();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AdministrationRoleARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AdministrationRoleARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AutoDeployment", targetDepth))
                    {
                        var unmarshaller = AutoDeploymentUnmarshaller.Instance;
                        unmarshalledObject.AutoDeployment = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Capabilities/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Capabilities.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExecutionRoleName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExecutionRoleName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManagedExecution", targetDepth))
                    {
                        var unmarshaller = ManagedExecutionUnmarshaller.Instance;
                        unmarshalledObject.ManagedExecution = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OrganizationalUnitIds/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.OrganizationalUnitIds.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Parameters/member", targetDepth))
                    {
                        var unmarshaller = ParameterUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Parameters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("PermissionModel", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PermissionModel = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Regions/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Regions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("StackSetARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackSetARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackSetDriftDetectionDetails", targetDepth))
                    {
                        var unmarshaller = StackSetDriftDetectionDetailsUnmarshaller.Instance;
                        unmarshalledObject.StackSetDriftDetectionDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackSetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackSetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackSetName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackSetName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tags/member", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("TemplateBody", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TemplateBody = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StackSet Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static StackSetUnmarshaller _instance = new StackSetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StackSetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}