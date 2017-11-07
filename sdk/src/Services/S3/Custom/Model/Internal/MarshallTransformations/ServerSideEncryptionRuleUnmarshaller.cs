/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public class ServerSideEncryptionRuleUnmarshaller : IUnmarshaller<ServerSideEncryptionRule, XmlUnmarshallerContext>, IUnmarshaller<ServerSideEncryptionRule, JsonUnmarshallerContext>
    {
        public ServerSideEncryptionRule Unmarshall(XmlUnmarshallerContext context)
        {
            ServerSideEncryptionRule rule = new ServerSideEncryptionRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ApplyServerSideEncryptionByDefault", targetDepth))
                    {
                        rule.ServerSideEncryptionByDefault = ServerSideEncryptionByDefaultUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return rule;
                }
            }

            return rule;
        }

        public ServerSideEncryptionRule Unmarshall(JsonUnmarshallerContext input)
        {
            return null;
        }
        private static ServerSideEncryptionRuleUnmarshaller _instance;

        public static ServerSideEncryptionRuleUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ServerSideEncryptionRuleUnmarshaller();
                }
                return _instance;
            }
        }

    }
}