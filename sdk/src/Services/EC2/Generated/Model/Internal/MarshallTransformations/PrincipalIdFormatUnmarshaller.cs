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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PrincipalIdFormat Object
    /// </summary>  
    public class PrincipalIdFormatUnmarshaller : IXmlUnmarshaller<PrincipalIdFormat, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PrincipalIdFormat Unmarshall(XmlUnmarshallerContext context)
        {
            PrincipalIdFormat unmarshalledObject = new PrincipalIdFormat();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("arn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("statusSet/item", targetDepth))
                    {
                        var unmarshaller = IdFormatUnmarshaller.Instance;
                        if (unmarshalledObject.Statuses == null)
                        {
                            unmarshalledObject.Statuses = new List<IdFormat>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Statuses.Add(item);
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

        private static PrincipalIdFormatUnmarshaller _instance = new PrincipalIdFormatUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PrincipalIdFormatUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}