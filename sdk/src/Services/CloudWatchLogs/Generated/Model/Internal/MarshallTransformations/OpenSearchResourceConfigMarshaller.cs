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

/*
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OpenSearchResourceConfig Marshaller
    /// </summary>
    public class OpenSearchResourceConfigMarshaller : IRequestMarshaller<OpenSearchResourceConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OpenSearchResourceConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationArn())
            {
                context.Writer.WritePropertyName("applicationArn");
                context.Writer.WriteStringValue(requestObject.ApplicationArn);
            }

            if(requestObject.IsSetDashboardViewerPrincipals())
            {
                context.Writer.WritePropertyName("dashboardViewerPrincipals");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDashboardViewerPrincipalsListValue in requestObject.DashboardViewerPrincipals)
                {
                        context.Writer.WriteStringValue(requestObjectDashboardViewerPrincipalsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDataSourceRoleArn())
            {
                context.Writer.WritePropertyName("dataSourceRoleArn");
                context.Writer.WriteStringValue(requestObject.DataSourceRoleArn);
            }

            if(requestObject.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("kmsKeyArn");
                context.Writer.WriteStringValue(requestObject.KmsKeyArn);
            }

            if(requestObject.IsSetRetentionDays())
            {
                context.Writer.WritePropertyName("retentionDays");
                context.Writer.WriteNumberValue(requestObject.RetentionDays.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OpenSearchResourceConfigMarshaller Instance = new OpenSearchResourceConfigMarshaller();

    }
}