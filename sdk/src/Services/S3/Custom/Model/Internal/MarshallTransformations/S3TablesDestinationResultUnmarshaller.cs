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

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{ 
    public class S3TablesDestinationResultUnmarshaller : IXmlUnmarshaller<S3TablesDestinationResult, XmlUnmarshallerContext>, IXmlUnmarshaller<S3TablesDestinationResult, JsonUnmarshallerContext>
    {
        public S3TablesDestinationResult Unmarshall(XmlUnmarshallerContext context)
        {
            S3TablesDestinationResult s3TablesDestinationResult = new S3TablesDestinationResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("TableBucketArn", targetDepth))
                    {
                        s3TablesDestinationResult.TableBucketArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TableArn", targetDepth))
                    {
                        s3TablesDestinationResult.TableArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TableName", targetDepth))
                    {
                        s3TablesDestinationResult.TableName = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TableNamespace", targetDepth))
                    {
                        s3TablesDestinationResult.TableNamespace = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return s3TablesDestinationResult;
                }
            }

            return s3TablesDestinationResult;
        }

        /// <summary>
        /// Not implemented and always returns null.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public S3TablesDestinationResult Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static S3TablesDestinationResultUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static S3TablesDestinationResultUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new S3TablesDestinationResultUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
