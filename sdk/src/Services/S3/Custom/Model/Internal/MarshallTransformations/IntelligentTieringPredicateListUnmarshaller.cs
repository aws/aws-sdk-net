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
	/// IntelligentTieringFilter Unmarshaller 
	/// </summary>  
	public class IntelligentTieringPredicateListFilterUnmarshaller : IXmlUnmarshaller<List<IntelligentTieringFilterPredicate>, XmlUnmarshallerContext>
	{
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<IntelligentTieringFilterPredicate> Unmarshall(XmlUnmarshallerContext context)
        {
            List<IntelligentTieringFilterPredicate> filterPredicateList = new List<IntelligentTieringFilterPredicate>();
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
                        filterPredicateList.Add(new IntelligentTieringPrefixPredicate(StringUnmarshaller.Instance.Unmarshall(context)));

                        continue;
                    }

                    if (context.TestExpression("Tag", targetDepth))
                    {
                        filterPredicateList.Add(new IntelligentTieringTagPredicate(TagUnmarshaller.Instance.Unmarshall(context)));

                        continue;
                    }

                    if (context.TestExpression("And", targetDepth))
                    {
                        filterPredicateList.Add(new IntelligentTieringAndOperator(Unmarshall(context)));

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

        private static IntelligentTieringPredicateListFilterUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static IntelligentTieringPredicateListFilterUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IntelligentTieringPredicateListFilterUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
