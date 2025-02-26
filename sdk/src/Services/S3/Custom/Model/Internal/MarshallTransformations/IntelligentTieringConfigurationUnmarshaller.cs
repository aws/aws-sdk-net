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
    /// Unmarshaller for IntelligentTieringConfiguration
    /// </summary>   
    public class IntelligentTieringConfigurationUnmarshaller : IXmlUnmarshaller<IntelligentTieringConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public IntelligentTieringConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            IntelligentTieringConfiguration response = new IntelligentTieringConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        response.IntelligentTieringFilter = new IntelligentTieringFilter()
                        {
                            IntelligentTieringFilterPredicate = (IntelligentTieringPredicateListFilterUnmarshaller.Instance.Unmarshall(context))[0]
                        };
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        response.IntelligentTieringId = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        response.Status = StringUnmarshaller.Instance.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Tiering", targetDepth))
                    {
                        if (response.Tierings == null)
                        {
                            response.Tierings = new List<Tiering>();
                        }
                        response.Tierings.Add(TieringUnmarshaller.Instance.Unmarshall(context));
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

        private static IntelligentTieringConfigurationUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static IntelligentTieringConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IntelligentTieringConfigurationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
