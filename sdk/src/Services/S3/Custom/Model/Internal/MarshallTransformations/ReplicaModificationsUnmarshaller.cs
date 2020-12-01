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
using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Unmarshaller for ReplicaModifications
    /// </summary>
    public class ReplicaModificationsUnmarshaller : IUnmarshaller<ReplicaModifications, XmlUnmarshallerContext>, IUnmarshaller<ReplicaModifications, JsonUnmarshallerContext>
    {
        public ReplicaModifications Unmarshall(XmlUnmarshallerContext context)
        {
            ReplicaModifications response = new ReplicaModifications();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Status", targetDepth))
                    {
                        response.Status = StringUnmarshaller.Instance.Unmarshall(context);
                        continue;
                    }

                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return response;
                }
            }

            return response;
        }

        public ReplicaModifications Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static ReplicaModificationsUnmarshaller _instance;

        public static ReplicaModificationsUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReplicaModificationsUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
