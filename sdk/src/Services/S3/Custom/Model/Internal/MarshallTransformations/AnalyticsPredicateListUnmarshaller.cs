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
    ///   AnalyticsFilter Unmarshaller
    /// </summary>
    public class AnalyticsPredicateListUnmarshaller : IUnmarshaller<List<AnalyticsFilterPredicate>, XmlUnmarshallerContext>, IUnmarshaller<List<AnalyticsFilterPredicate>, JsonUnmarshallerContext>
    {
        public List<AnalyticsFilterPredicate> Unmarshall(XmlUnmarshallerContext context)
        {
            List<AnalyticsFilterPredicate> filterPredicateList = new List<AnalyticsFilterPredicate>();
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
                        filterPredicateList.Add(new AnalyticsPrefixPredicate(StringUnmarshaller.Instance.Unmarshall(context)));

                        continue;
                    }

                    if (context.TestExpression("Tag", targetDepth))
                    {
                        filterPredicateList.Add(new AnalyticsTagPredicate(TagUnmarshaller.Instance.Unmarshall(context)));

                        continue;
                    }

                    if (context.TestExpression("And", targetDepth))
                    {
                        filterPredicateList.Add(new AnalyticsAndOperator(Unmarshall(context)));

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return filterPredicateList;
                }
            }



            return filterPredicateList;
        }

        public List<AnalyticsFilterPredicate> Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static AnalyticsPredicateListUnmarshaller _instance;

        public static AnalyticsPredicateListUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnalyticsPredicateListUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
