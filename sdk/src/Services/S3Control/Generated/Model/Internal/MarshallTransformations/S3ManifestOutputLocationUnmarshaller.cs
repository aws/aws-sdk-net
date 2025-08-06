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
    /// Response Unmarshaller for S3ManifestOutputLocation Object
    /// </summary>  
    public partial class S3ManifestOutputLocationUnmarshaller : IXmlUnmarshaller<S3ManifestOutputLocation, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3ManifestOutputLocation Unmarshall(XmlUnmarshallerContext context)
        {
            S3ManifestOutputLocation unmarshalledObject = new S3ManifestOutputLocation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Bucket = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExpectedManifestBucketOwner", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExpectedManifestBucketOwner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManifestEncryption", targetDepth))
                    {
                        var unmarshaller = GeneratedManifestEncryptionUnmarshaller.Instance;
                        unmarshalledObject.ManifestEncryption = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManifestFormat", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ManifestFormat = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManifestPrefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ManifestPrefix = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, S3ManifestOutputLocation unmarshalledObject, int targetDepth);

        private static S3ManifestOutputLocationUnmarshaller _instance = new S3ManifestOutputLocationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3ManifestOutputLocationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}