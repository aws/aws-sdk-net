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
    /// EncryptionConfiguration unmarshaller
    /// </summary>
    public class EncryptionConfigurationUnmarshaller : IXmlUnmarshaller<EncryptionConfiguration, XmlUnmarshallerContext>, IXmlUnmarshaller<EncryptionConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public EncryptionConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            EncryptionConfiguration EncryptionConfiguration = new EncryptionConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ReplicaKmsKeyID", targetDepth))
                    {
                        EncryptionConfiguration.ReplicaKmsKeyID = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return EncryptionConfiguration;
                }
            }

            return EncryptionConfiguration;
        }

        /// <summary>
        /// Not implemented and always returns null.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public EncryptionConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static EncryptionConfigurationUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static EncryptionConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EncryptionConfigurationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}