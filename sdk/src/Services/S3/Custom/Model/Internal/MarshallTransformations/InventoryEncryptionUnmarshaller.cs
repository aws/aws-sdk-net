﻿/*
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
    ///   InventoryEncryption Unmarshaller
    /// </summary>
    public class InventoryEncryptionUnmarshaller : IUnmarshaller<InventoryEncryption, XmlUnmarshallerContext>, IUnmarshaller<InventoryEncryption, JsonUnmarshallerContext>
    {
        public InventoryEncryption Unmarshall(XmlUnmarshallerContext context)
        {
            InventoryEncryption condition = new InventoryEncryption();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("SSE-KMS", targetDepth))
                    {
                        condition.SSEKMS = SSEKMSUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("SSE-S3", targetDepth))
                    {
                        condition.SSES3 = SSES3Unmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return condition;
                }
            }



            return condition;
        }

        public InventoryEncryption Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static InventoryEncryptionUnmarshaller _instance;

        public static InventoryEncryptionUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryEncryptionUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
