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
    /// Response Unmarshaller for ResponseHeadersPolicySecurityHeadersConfig Object
    /// </summary>  
    public class ResponseHeadersPolicySecurityHeadersConfigUnmarshaller : IUnmarshaller<ResponseHeadersPolicySecurityHeadersConfig, XmlUnmarshallerContext>, IUnmarshaller<ResponseHeadersPolicySecurityHeadersConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResponseHeadersPolicySecurityHeadersConfig Unmarshall(XmlUnmarshallerContext context)
        {
            ResponseHeadersPolicySecurityHeadersConfig unmarshalledObject = new ResponseHeadersPolicySecurityHeadersConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ContentSecurityPolicy", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyContentSecurityPolicyUnmarshaller.Instance;
                        unmarshalledObject.ContentSecurityPolicy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContentTypeOptions", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyContentTypeOptionsUnmarshaller.Instance;
                        unmarshalledObject.ContentTypeOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FrameOptions", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyFrameOptionsUnmarshaller.Instance;
                        unmarshalledObject.FrameOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReferrerPolicy", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyReferrerPolicyUnmarshaller.Instance;
                        unmarshalledObject.ReferrerPolicy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StrictTransportSecurity", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyStrictTransportSecurityUnmarshaller.Instance;
                        unmarshalledObject.StrictTransportSecurity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("XSSProtection", targetDepth))
                    {
                        var unmarshaller = ResponseHeadersPolicyXSSProtectionUnmarshaller.Instance;
                        unmarshalledObject.XSSProtection = unmarshaller.Unmarshall(context);
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
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResponseHeadersPolicySecurityHeadersConfig Unmarshall(JsonUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        private static ResponseHeadersPolicySecurityHeadersConfigUnmarshaller _instance = new ResponseHeadersPolicySecurityHeadersConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResponseHeadersPolicySecurityHeadersConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}