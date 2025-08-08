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
    /// Response Unmarshaller for S3ObjectVersion Object
    /// </summary>  
    public partial class S3ObjectVersionUnmarshaller : IXmlUnmarshaller<S3ObjectVersion, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3ObjectVersion Unmarshall(XmlUnmarshallerContext context)
        {
            S3ObjectVersion unmarshalledObject = new S3ObjectVersion();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ChecksumAlgorithm", targetDepth))
                    {
                        if (unmarshalledObject.ChecksumAlgorithm == null)
                        {
                            unmarshalledObject.ChecksumAlgorithm = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChecksumAlgorithm.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ChecksumType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChecksumType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ETag", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ETag = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsLatest", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsLatest = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Key = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastModified", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LastModified = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Owner", targetDepth))
                    {
                        var unmarshaller = OwnerUnmarshaller.Instance;
                        unmarshalledObject.Owner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RestoreStatus", targetDepth))
                    {
                        var unmarshaller = RestoreStatusUnmarshaller.Instance;
                        unmarshalledObject.RestoreStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Size", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.Size = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VersionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VersionId = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, S3ObjectVersion unmarshalledObject, int targetDepth);

        private static S3ObjectVersionUnmarshaller _instance = new S3ObjectVersionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3ObjectVersionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}