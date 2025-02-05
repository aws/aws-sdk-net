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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResponseHeadersPolicyCorsConfig Object
    /// </summary>  
    public class ResponseHeadersPolicyCorsConfigUnmarshaller : IXmlUnmarshaller<ResponseHeadersPolicyCorsConfig, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResponseHeadersPolicyCorsConfig Unmarshall(XmlUnmarshallerContext context)
        {
            ResponseHeadersPolicyCorsConfig unmarshalledObject = new ResponseHeadersPolicyCorsConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccessControlAllowCredentials", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AccessControlAllowCredentials = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessControlAllowHeaders", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyAccessControlAllowHeadersUnmarshaller.Instance;
                        unmarshalledObject.AccessControlAllowHeaders = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessControlAllowMethods", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyAccessControlAllowMethodsUnmarshaller.Instance;
                        unmarshalledObject.AccessControlAllowMethods = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessControlAllowOrigins", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyAccessControlAllowOriginsUnmarshaller.Instance;
                        unmarshalledObject.AccessControlAllowOrigins = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessControlExposeHeaders", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyAccessControlExposeHeadersUnmarshaller.Instance;
                        unmarshalledObject.AccessControlExposeHeaders = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessControlMaxAgeSec", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AccessControlMaxAgeSec = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OriginOverride", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.OriginOverride = unmarshaller.Unmarshall(context);
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
        private static ResponseHeadersPolicyCorsConfigUnmarshaller _instance = new ResponseHeadersPolicyCorsConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResponseHeadersPolicyCorsConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}