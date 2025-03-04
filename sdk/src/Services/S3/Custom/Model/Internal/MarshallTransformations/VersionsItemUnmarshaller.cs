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
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   VersionsItem Unmarshaller
     /// </summary>
    public class VersionsItemUnmarshaller : IXmlUnmarshaller<S3ObjectVersion, XmlUnmarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public S3ObjectVersion Unmarshall(XmlUnmarshallerContext context) 
        {
            S3ObjectVersion versionsItem = new S3ObjectVersion();
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
                        if (versionsItem.ChecksumAlgorithm == null)
                        {
                            versionsItem.ChecksumAlgorithm = new List<string>();
                        }
                        versionsItem.ChecksumAlgorithm.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ETag", targetDepth))
                    {
                        versionsItem.ETag = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("IsLatest", targetDepth))
                    {
                        versionsItem.IsLatest = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        versionsItem.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LastModified", targetDepth))
                    {
                        versionsItem.LastModified = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Owner", targetDepth))
                    {
                        versionsItem.Owner = OwnerUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Size", targetDepth))
                    {
                        versionsItem.Size = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        versionsItem.StorageClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("VersionId", targetDepth))
                    {
                        versionsItem.VersionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if(context.TestExpression("RestoreStatus", targetDepth))
                    {
                        versionsItem.RestoreStatus = RestoreStatusUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("ChecksumType", targetDepth))
                    {
                        versionsItem.ChecksumType = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return versionsItem;
                }
            }
                        


            return versionsItem;
        }

        private static VersionsItemUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static VersionsItemUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VersionsItemUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
