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
     ///   RulesItem Unmarshaller
     /// </summary>
    internal class RulesItemUnmarshaller : IUnmarshaller<LifecycleRule, XmlUnmarshallerContext>, IUnmarshaller<LifecycleRule, JsonUnmarshallerContext> 
    {
        public LifecycleRule Unmarshall(XmlUnmarshallerContext context) 
        {
            LifecycleRule rulesItem = new LifecycleRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Expiration", targetDepth))
                    {
                        rulesItem.Expiration = ExpirationUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ID", targetDepth))
                    {
                        rulesItem.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        rulesItem.Prefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        rulesItem.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Transition", targetDepth))
                    {
                        rulesItem.Transitions.Add(TransitionUnmarshaller.Instance.Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("NoncurrentVersionTransition", targetDepth))
                    {
                        rulesItem.NoncurrentVersionTransitions.Add(LifecycleRuleNoncurrentVersionTransitionUnmarshaller.Instance.Unmarshall(context));

                        continue;
                    }
                    if (context.TestExpression("NoncurrentVersionExpiration", targetDepth))
                    {
                        rulesItem.NoncurrentVersionExpiration = LifecycleRuleNoncurrentVersionExpirationUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("AbortIncompleteMultipartUpload", targetDepth))
                    {
                        rulesItem.AbortIncompleteMultipartUpload = AbortIncompleteMultipartUploadUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return rulesItem;
                }
            }
                        


            return rulesItem;
        }

        public LifecycleRule Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static RulesItemUnmarshaller _instance;

        public static RulesItemUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RulesItemUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
