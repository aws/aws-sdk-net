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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Model.Internal.MarshallTransformations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
	/// <summary>
	///    Response Unmarshaller for GetBucketIntelligentTieringConfiguration operation
	/// </summary>
	public class GetBucketIntelligentTieringConfigurationResponseUnmarshaller : S3ReponseUnmarshaller
	{
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetBucketIntelligentTieringConfigurationResponse response = new GetBucketIntelligentTieringConfigurationResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    UnmarshallResult(context, response);
                    continue;
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetBucketIntelligentTieringConfigurationResponse response)
        {

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            response.IntelligentTieringConfiguration = new IntelligentTieringConfiguration();

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        response.IntelligentTieringConfiguration.IntelligentTieringFilter = new IntelligentTieringFilter()
                        {
                            IntelligentTieringFilterPredicate = (IntelligentTieringPredicateListFilterUnmarshaller.Instance.Unmarshall(context))[0]
                        };
                        continue;
                    }

                    if (context.TestExpression("Id", targetDepth))
                    {
                        response.IntelligentTieringConfiguration.IntelligentTieringId = StringUnmarshaller.Instance.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Status", targetDepth))
					{
                        response.IntelligentTieringConfiguration.Status = StringUnmarshaller.Instance.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Tiering", targetDepth))
                    {
                        if (response.IntelligentTieringConfiguration.Tierings == null)
                        {
                            response.IntelligentTieringConfiguration.Tierings = new List<Tiering>();
                        }
                        response.IntelligentTieringConfiguration.Tierings.Add(TieringUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }

                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }

            return;
        }

        private static GetBucketIntelligentTieringConfigurationResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static GetBucketIntelligentTieringConfigurationResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketIntelligentTieringConfigurationResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
