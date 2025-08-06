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
    /// Response Unmarshaller for ReplicationDestination Object
    /// </summary>  
    public partial class ReplicationDestinationUnmarshaller : IXmlUnmarshaller<ReplicationDestination, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReplicationDestination Unmarshall(XmlUnmarshallerContext context)
        {
            ReplicationDestination unmarshalledObject = new ReplicationDestination();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccessControlTranslation", targetDepth))
                    {
                        var unmarshaller = AccessControlTranslationUnmarshaller.Instance;
                        unmarshalledObject.AccessControlTranslation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Account", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BucketArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EncryptionConfiguration", targetDepth))
                    {
                        var unmarshaller = EncryptionConfigurationUnmarshaller.Instance;
                        unmarshalledObject.EncryptionConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Metrics", targetDepth))
                    {
                        var unmarshaller = MetricsUnmarshaller.Instance;
                        unmarshalledObject.Metrics = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReplicationTime", targetDepth))
                    {
                        var unmarshaller = ReplicationTimeUnmarshaller.Instance;
                        unmarshalledObject.ReplicationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageClass = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, ReplicationDestination unmarshalledObject, int targetDepth);

        private static ReplicationDestinationUnmarshaller _instance = new ReplicationDestinationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicationDestinationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}