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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3Grantee Object
    /// </summary>  
    public class S3GranteeUnmarshaller : IUnmarshaller<S3Grantee, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3Grantee Unmarshall(XmlUnmarshallerContext context)
        {
            S3Grantee unmarshalledObject = new S3Grantee();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DisplayName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Identifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Identifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeIdentifier = unmarshaller.Unmarshall(context);
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

        private static S3GranteeUnmarshaller _instance = new S3GranteeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3GranteeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}