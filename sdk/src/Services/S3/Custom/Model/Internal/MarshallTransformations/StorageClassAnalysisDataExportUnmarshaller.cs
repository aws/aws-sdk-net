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
    /// StorageClassAnalysisDataExportDataExportUnmarshaller
    /// </summary>
    public class StorageClassAnalysisDataExportUnmarshaller : IXmlUnmarshaller<StorageClassAnalysisDataExport, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public StorageClassAnalysisDataExport Unmarshall(XmlUnmarshallerContext context)
        {
            StorageClassAnalysisDataExport StorageClassAnalysisDataExport = new StorageClassAnalysisDataExport();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("OutputSchemaVersion", targetDepth))
                    {
                        StorageClassAnalysisDataExport.OutputSchemaVersion = StorageClassAnalysisSchemaVersion.FindValue(StringUnmarshaller.Instance.Unmarshall(context));

                        continue;
                    }
                    if (context.TestExpression("Destination", targetDepth))
                    {
                        StorageClassAnalysisDataExport.Destination = AnalyticsExportDestinationUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return StorageClassAnalysisDataExport;
                }
            }



            return StorageClassAnalysisDataExport;
        }

        private static StorageClassAnalysisDataExportUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static StorageClassAnalysisDataExportUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StorageClassAnalysisDataExportUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
