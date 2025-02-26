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
    /// MetricsFilte Unmarshaller 
    /// </summary>  
    public class MetricsPredicateListFilterUnmarshaller : IXmlUnmarshaller<List<MetricsFilterPredicate>, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<MetricsFilterPredicate> Unmarshall(XmlUnmarshallerContext context)
        {
            List<MetricsFilterPredicate> filterPredicateList = new List<MetricsFilterPredicate>();
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
                        filterPredicateList.Add(new MetricsPrefixPredicate(StringUnmarshaller.Instance.Unmarshall(context)));

                        continue;
                    }

                    if (context.TestExpression("Tag", targetDepth))
                    {
                        filterPredicateList.Add(new MetricsTagPredicate(TagUnmarshaller.Instance.Unmarshall(context)));

                        continue;
                    }

                    if (context.TestExpression("AccessPointArn", targetDepth))
                    {
                        filterPredicateList.Add(new MetricsAccessPointArnPredicate(StringUnmarshaller.Instance.Unmarshall(context)));

                        continue;
                    }
                    
                    if (context.TestExpression("And", targetDepth))
                    {
                        filterPredicateList.Add(new MetricsAndOperator(Unmarshall(context)));

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

        private static MetricsPredicateListFilterUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static MetricsPredicateListFilterUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MetricsPredicateListFilterUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
