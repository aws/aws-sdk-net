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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Qev2IdcApplication Object
    /// </summary>  
    public class Qev2IdcApplicationUnmarshaller : IXmlUnmarshaller<Qev2IdcApplication, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Qev2IdcApplication Unmarshall(XmlUnmarshallerContext context)
        {
            Qev2IdcApplication unmarshalledObject = new Qev2IdcApplication();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("IdcDisplayName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdcDisplayName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IdcInstanceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdcInstanceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IdcManagedApplicationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdcManagedApplicationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IdcOnboardStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IdcOnboardStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Qev2IdcApplicationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Qev2IdcApplicationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Qev2IdcApplicationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Qev2IdcApplicationName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tags/Tag", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
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

        private static Qev2IdcApplicationUnmarshaller _instance = new Qev2IdcApplicationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Qev2IdcApplicationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}