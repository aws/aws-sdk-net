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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CORSRule Object
    /// </summary>  
    public partial class CORSRuleUnmarshaller : IXmlUnmarshaller<CORSRule, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CORSRule Unmarshall(XmlUnmarshallerContext context)
        {
            CORSRule unmarshalledObject = new CORSRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowedHeader", targetDepth))
                    {
                        if (unmarshalledObject.AllowedHeaders == null)
                        {
                            unmarshalledObject.AllowedHeaders = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllowedHeaders.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("AllowedMethod", targetDepth))
                    {
                        if (unmarshalledObject.AllowedMethods == null)
                        {
                            unmarshalledObject.AllowedMethods = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllowedMethods.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("AllowedOrigin", targetDepth))
                    {
                        if (unmarshalledObject.AllowedOrigins == null)
                        {
                            unmarshalledObject.AllowedOrigins = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllowedOrigins.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ExposeHeader", targetDepth))
                    {
                        if (unmarshalledObject.ExposeHeaders == null)
                        {
                            unmarshalledObject.ExposeHeaders = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExposeHeaders.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ID", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxAgeSeconds", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxAgeSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    XmlStructureUnmarshallCustomization(context, unmarshalledObject, targetDepth);
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, CORSRule unmarshalledObject, int targetDepth);

        private static CORSRuleUnmarshaller _instance = new CORSRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CORSRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}