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

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class GetBucketMetadataTableConfigurationResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetBucketMetadataTableConfigurationResponse response = new GetBucketMetadataTableConfigurationResponse();

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

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetBucketMetadataTableConfigurationResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            response.GetBucketMetadataTableConfigurationResult = new GetBucketMetadataTableConfigurationResult();

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("MetadataTableConfigurationResult", targetDepth))
                    {
                        response.GetBucketMetadataTableConfigurationResult.MetadataTableConfigurationResult = MetadataTableConfigurationResultUnmarshaller.Instance.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        response.GetBucketMetadataTableConfigurationResult.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Error", targetDepth))
                    {
                        response.GetBucketMetadataTableConfigurationResult.Error = ErrorUnmarshaller.Instance.Unmarshall(context);
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

        private static GetBucketMetadataTableConfigurationResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static GetBucketMetadataTableConfigurationResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketMetadataTableConfigurationResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
