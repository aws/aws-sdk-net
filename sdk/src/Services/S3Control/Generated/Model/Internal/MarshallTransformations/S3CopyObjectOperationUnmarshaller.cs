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
    /// Response Unmarshaller for S3CopyObjectOperation Object
    /// </summary>  
    public partial class S3CopyObjectOperationUnmarshaller : IXmlUnmarshaller<S3CopyObjectOperation, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3CopyObjectOperation Unmarshall(XmlUnmarshallerContext context)
        {
            S3CopyObjectOperation unmarshalledObject = new S3CopyObjectOperation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccessControlGrants/member", targetDepth))
                    {
                        if (unmarshalledObject.AccessControlGrants == null)
                        {
                            unmarshalledObject.AccessControlGrants = new List<S3Grant>();
                        }
                        var unmarshaller = S3GrantUnmarshaller.Instance;
                        unmarshalledObject.AccessControlGrants.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("BucketKeyEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.BucketKeyEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CannedAccessControlList", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CannedAccessControlList = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumAlgorithm", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChecksumAlgorithm = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MetadataDirective", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MetadataDirective = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ModifiedSinceConstraint", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ModifiedSinceConstraint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NewObjectMetadata", targetDepth))
                    {
                        var unmarshaller = S3ObjectMetadataUnmarshaller.Instance;
                        unmarshalledObject.NewObjectMetadata = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NewObjectTagging/member", targetDepth))
                    {
                        if (unmarshalledObject.NewObjectTagging == null)
                        {
                            unmarshalledObject.NewObjectTagging = new List<S3Tag>();
                        }
                        var unmarshaller = S3TagUnmarshaller.Instance;
                        unmarshalledObject.NewObjectTagging.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ObjectLockLegalHoldStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ObjectLockLegalHoldStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ObjectLockMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ObjectLockMode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ObjectLockRetainUntilDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ObjectLockRetainUntilDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RedirectLocation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RedirectLocation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequesterPays", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequesterPays = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SSEAwsKmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SSEAwsKmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetKeyPrefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetKeyPrefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetResource", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetResource = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UnModifiedSinceConstraint", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UnModifiedSinceConstraint = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, S3CopyObjectOperation unmarshalledObject, int targetDepth);

        private static S3CopyObjectOperationUnmarshaller _instance = new S3CopyObjectOperationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3CopyObjectOperationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}