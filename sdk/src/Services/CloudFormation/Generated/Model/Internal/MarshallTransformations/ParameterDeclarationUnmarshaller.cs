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
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ParameterDeclaration Object
    /// </summary>  
    public class ParameterDeclarationUnmarshaller : IXmlUnmarshaller<ParameterDeclaration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ParameterDeclaration Unmarshall(XmlUnmarshallerContext context)
        {
            ParameterDeclaration unmarshalledObject = new ParameterDeclaration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NoEcho", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.NoEcho = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ParameterConstraints", targetDepth))
                    {
                        var unmarshaller = ParameterConstraintsUnmarshaller.Instance;
                        unmarshalledObject.ParameterConstraints = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ParameterKey", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ParameterKey = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ParameterType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ParameterType = unmarshaller.Unmarshall(context);
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

        private static ParameterDeclarationUnmarshaller _instance = new ParameterDeclarationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ParameterDeclarationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}