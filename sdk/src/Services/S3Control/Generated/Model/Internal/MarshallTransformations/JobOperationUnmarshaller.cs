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
    /// Response Unmarshaller for JobOperation Object
    /// </summary>  
    public partial class JobOperationUnmarshaller : IXmlUnmarshaller<JobOperation, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public JobOperation Unmarshall(XmlUnmarshallerContext context)
        {
            JobOperation unmarshalledObject = new JobOperation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("LambdaInvoke", targetDepth))
                    {
                        var unmarshaller = LambdaInvokeOperationUnmarshaller.Instance;
                        unmarshalledObject.LambdaInvoke = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3ComputeObjectChecksum", targetDepth))
                    {
                        var unmarshaller = S3ComputeObjectChecksumOperationUnmarshaller.Instance;
                        unmarshalledObject.S3ComputeObjectChecksum = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3DeleteObjectTagging", targetDepth))
                    {
                        var unmarshaller = S3DeleteObjectTaggingOperationUnmarshaller.Instance;
                        unmarshalledObject.S3DeleteObjectTagging = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3InitiateRestoreObject", targetDepth))
                    {
                        var unmarshaller = S3InitiateRestoreObjectOperationUnmarshaller.Instance;
                        unmarshalledObject.S3InitiateRestoreObject = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3PutObjectAcl", targetDepth))
                    {
                        var unmarshaller = S3SetObjectAclOperationUnmarshaller.Instance;
                        unmarshalledObject.S3PutObjectAcl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3PutObjectCopy", targetDepth))
                    {
                        var unmarshaller = S3CopyObjectOperationUnmarshaller.Instance;
                        unmarshalledObject.S3PutObjectCopy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3PutObjectLegalHold", targetDepth))
                    {
                        var unmarshaller = S3SetObjectLegalHoldOperationUnmarshaller.Instance;
                        unmarshalledObject.S3PutObjectLegalHold = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3PutObjectRetention", targetDepth))
                    {
                        var unmarshaller = S3SetObjectRetentionOperationUnmarshaller.Instance;
                        unmarshalledObject.S3PutObjectRetention = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3PutObjectTagging", targetDepth))
                    {
                        var unmarshaller = S3SetObjectTaggingOperationUnmarshaller.Instance;
                        unmarshalledObject.S3PutObjectTagging = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3ReplicateObject", targetDepth))
                    {
                        var unmarshaller = S3ReplicateObjectOperationUnmarshaller.Instance;
                        unmarshalledObject.S3ReplicateObject = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, JobOperation unmarshalledObject, int targetDepth);

        private static JobOperationUnmarshaller _instance = new JobOperationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobOperationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}