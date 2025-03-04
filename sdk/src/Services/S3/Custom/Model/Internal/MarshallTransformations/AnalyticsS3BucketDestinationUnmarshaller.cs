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
    ///   AnalyticsS3BucketDestination Unmarshaller
    /// </summary>
    public class AnalyticsS3BucketDestinationUnmarshaller : IXmlUnmarshaller<AnalyticsS3BucketDestination, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public AnalyticsS3BucketDestination Unmarshall(XmlUnmarshallerContext context)
        {
            AnalyticsS3BucketDestination AnalyticsS3BucketDestination = new AnalyticsS3BucketDestination();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Format", targetDepth))
                    {
                        AnalyticsS3BucketDestination.Format = AnalyticsS3ExportFileFormat.FindValue(StringUnmarshaller.Instance.Unmarshall(context));

                        continue;
                    }
                    if (context.TestExpression("BucketAccountId", targetDepth))
                    {
                        AnalyticsS3BucketDestination.BucketAccountId = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        AnalyticsS3BucketDestination.BucketName = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        AnalyticsS3BucketDestination.Prefix = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return AnalyticsS3BucketDestination;
                }
            }



            return AnalyticsS3BucketDestination;
        }

        private static AnalyticsS3BucketDestinationUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static AnalyticsS3BucketDestinationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnalyticsS3BucketDestinationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
