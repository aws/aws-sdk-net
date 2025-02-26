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
    /// AnalyticsConfiguration Unmarshaller
    /// </summary>
    public class AnalyticsConfigurationUnmarshaller : IXmlUnmarshaller<AnalyticsConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public AnalyticsConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            AnalyticsConfiguration analyticsConfiguration = new AnalyticsConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Id", targetDepth))
                    {
                        analyticsConfiguration.AnalyticsId = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }

                    if (context.TestExpression("Filter", targetDepth))
                    {
                        analyticsConfiguration.AnalyticsFilter = new AnalyticsFilter(){
                            AnalyticsFilterPredicate =  (AnalyticsPredicateListUnmarshaller.Instance.Unmarshall(context))[0]
                        };
                        continue;
                    }

                    if (context.TestExpression("StorageClassAnalysis", targetDepth))
                    {
                        analyticsConfiguration.StorageClassAnalysis = StorageClassAnalysisUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return analyticsConfiguration;
                }
            }



            return analyticsConfiguration;
        }

        private static AnalyticsConfigurationUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static AnalyticsConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnalyticsConfigurationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
