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

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3ObjectMetadata Object
    /// </summary>  
    public partial class S3ObjectMetadataUnmarshaller : IXmlUnmarshaller<S3ObjectMetadata, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3ObjectMetadata Unmarshall(XmlUnmarshallerContext context)
        {
            S3ObjectMetadata unmarshalledObject = new S3ObjectMetadata();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CacheControl", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheControl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContentDisposition", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ContentDisposition = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContentEncoding", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ContentEncoding = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContentLanguage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ContentLanguage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContentLength", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.ContentLength = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContentMD5", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ContentMD5 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ContentType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ContentType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HttpExpiresDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.HttpExpiresDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequesterCharged", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequesterCharged = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SSEAlgorithm", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SSEAlgorithm = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UserMetadata", targetDepth))
                    {
                        var unmarshaller = new XmlDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance, "key", "value");
                        unmarshalledObject.UserMetadata = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, S3ObjectMetadata unmarshalledObject, int targetDepth);

        private static S3ObjectMetadataUnmarshaller _instance = new S3ObjectMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3ObjectMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}