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
    ///   InventoryS3BucketDestination Unmarshaller
    /// </summary>
    public class InventoryS3BucketDestinationUnmarshaller : IXmlUnmarshaller<InventoryS3BucketDestination, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public InventoryS3BucketDestination Unmarshall(XmlUnmarshallerContext context)
        {
            InventoryS3BucketDestination condition = new InventoryS3BucketDestination();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccountId", targetDepth))
                    {
                        condition.AccountId = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        condition.BucketName = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Format", targetDepth))
                    {
                        condition.InventoryFormat = InventoryFormat.FindValue(StringUnmarshaller.GetInstance().Unmarshall(context));

                        continue;
                    }
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        condition.Prefix = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Encryption", targetDepth))
                    {
                        condition.InventoryEncryption = InventoryEncryptionUnmarshaller.Instance.Unmarshall(context);
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return condition;
                }
            }



            return condition;
        }

        private static InventoryS3BucketDestinationUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static InventoryS3BucketDestinationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryS3BucketDestinationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
