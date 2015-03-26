/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
     ///   UploadsItem Unmarshaller
     /// </summary>
    internal class MultipartUploadUnmarshaller : IUnmarshaller<MultipartUpload, XmlUnmarshallerContext>, IUnmarshaller<MultipartUpload, JsonUnmarshallerContext> 
    {
        public MultipartUpload Unmarshall(XmlUnmarshallerContext context) 
        {
            MultipartUpload uploadsItem = new MultipartUpload();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Initiated", targetDepth))
                    {
                        uploadsItem.Initiated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Initiator", targetDepth))
                    {
                        uploadsItem.Initiator = InitiatorUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        uploadsItem.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Owner", targetDepth))
                    {
                        uploadsItem.Owner = OwnerUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        uploadsItem.StorageClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("UploadId", targetDepth))
                    {
                        uploadsItem.UploadId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return uploadsItem;
                }
            }
                        


            return uploadsItem;
        }

        public MultipartUpload Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static MultipartUploadUnmarshaller _instance;

        public static MultipartUploadUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MultipartUploadUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
    
