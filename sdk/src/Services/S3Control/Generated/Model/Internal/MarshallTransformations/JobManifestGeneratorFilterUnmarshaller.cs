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
    /// Response Unmarshaller for JobManifestGeneratorFilter Object
    /// </summary>  
    public partial class JobManifestGeneratorFilterUnmarshaller : IXmlUnmarshaller<JobManifestGeneratorFilter, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public JobManifestGeneratorFilter Unmarshall(XmlUnmarshallerContext context)
        {
            JobManifestGeneratorFilter unmarshalledObject = new JobManifestGeneratorFilter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CreatedAfter", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedAfter = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedBefore", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedBefore = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EligibleForReplication", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EligibleForReplication = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KeyNameConstraint", targetDepth))
                    {
                        var unmarshaller = KeyNameConstraintUnmarshaller.Instance;
                        unmarshalledObject.KeyNameConstraint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MatchAnyObjectEncryption/ObjectEncryption", targetDepth))
                    {
                        if (unmarshalledObject.MatchAnyObjectEncryption == null)
                        {
                            unmarshalledObject.MatchAnyObjectEncryption = new List<ObjectEncryptionFilter>();
                        }
                        var unmarshaller = ObjectEncryptionFilterUnmarshaller.Instance;
                        unmarshalledObject.MatchAnyObjectEncryption.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("MatchAnyStorageClass/member", targetDepth))
                    {
                        if (unmarshalledObject.MatchAnyStorageClass == null)
                        {
                            unmarshalledObject.MatchAnyStorageClass = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MatchAnyStorageClass.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ObjectReplicationStatuses/member", targetDepth))
                    {
                        if (unmarshalledObject.ObjectReplicationStatuses == null)
                        {
                            unmarshalledObject.ObjectReplicationStatuses = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ObjectReplicationStatuses.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ObjectSizeGreaterThanBytes", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.ObjectSizeGreaterThanBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ObjectSizeLessThanBytes", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.ObjectSizeLessThanBytes = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, JobManifestGeneratorFilter unmarshalledObject, int targetDepth);

        private static JobManifestGeneratorFilterUnmarshaller _instance = new JobManifestGeneratorFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobManifestGeneratorFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}