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
    /// LifecycleFilterPredicate Unmarshaller
    /// </summary>
    public class LifecycleFilterPredicateListUnmarshaller : IUnmarshaller<List<LifecycleFilterPredicate>, XmlUnmarshallerContext>,
        IUnmarshaller<List<LifecycleFilterPredicate>, JsonUnmarshallerContext>
    {
        public List<LifecycleFilterPredicate> Unmarshall(XmlUnmarshallerContext context)
        {
            var predicateList = new List<LifecycleFilterPredicate>();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        var prefix = StringUnmarshaller.Instance.Unmarshall(context);
                        predicateList.Add(new LifecyclePrefixPredicate()
                        {
                            Prefix = prefix
                        });
                    }
                    if (context.TestExpression("Tag", targetDepth))
                    {
                        var tag = TagUnmarshaller.Instance.Unmarshall(context);
                        predicateList.Add(new LifecycleTagPredicate()
                        {
                            Tag = tag
                        });
                    }
                    if (context.TestExpression("And", targetDepth))
                    {
                        predicateList.Add(new LifecycleAndOperator()
                        {
                            Operands = Unmarshall(context)
                        });
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return predicateList;
                }
            }

            return predicateList;
        }

        public List<LifecycleFilterPredicate> Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static LifecycleFilterPredicateListUnmarshaller _instance;

        public static LifecycleFilterPredicateListUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LifecycleFilterPredicateListUnmarshaller();
                }
                return _instance;
            }
        }
    }
}

