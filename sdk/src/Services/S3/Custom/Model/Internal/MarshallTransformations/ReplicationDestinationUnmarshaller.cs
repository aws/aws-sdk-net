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
    public class ReplicationDestinationUnmarshaller : IUnmarshaller<ReplicationDestination, XmlUnmarshallerContext>, IUnmarshaller<ReplicationDestination, JsonUnmarshallerContext>
    {

        public ReplicationDestination Unmarshall(XmlUnmarshallerContext context)
        {
            ReplicationDestination destination = new ReplicationDestination();
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
                        destination.BucketArn = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        destination.StorageClass = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Account", targetDepth))
                    {
                        destination.AccountId = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("AccessControlTranslation", targetDepth))
                    {
                        destination.AccessControlTranslation = AccessControlTranslationUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("EncryptionConfiguration", targetDepth))
                    {
                        destination.EncryptionConfiguration = EncryptionConfigurationUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("ReplicationTime", targetDepth))
                    {
                        destination.ReplicationTime = ReplicationTimeUnmarshaller.Instance.Unmarshall(context);
                    }
                    if (context.TestExpression("Metrics", targetDepth)) 
                    {
                        destination.Metrics = MetricsUnmarshaller.Instance.Unmarshall(context);
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return destination;
                }
            }

            return destination;
        }

        public ReplicationDestination Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static ReplicationDestinationUnmarshaller _instance;

        public static ReplicationDestinationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReplicationDestinationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
