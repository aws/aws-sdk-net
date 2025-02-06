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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AthenaSourceConfig Marshaller
    /// </summary>
    public class AthenaSourceConfigMarshaller : IRequestMarshaller<AthenaSourceConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AthenaSourceConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBackTestConfiguration())
            {
                context.Writer.WritePropertyName("BackTestConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = BackTestConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BackTestConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDataCatalog())
            {
                context.Writer.WritePropertyName("DataCatalog");
                context.Writer.WriteStringValue(requestObject.DataCatalog);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetS3ResultsPath())
            {
                context.Writer.WritePropertyName("S3ResultsPath");
                context.Writer.WriteStringValue(requestObject.S3ResultsPath);
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(requestObject.TableName);
            }

            if(requestObject.IsSetWorkGroupName())
            {
                context.Writer.WritePropertyName("WorkGroupName");
                context.Writer.WriteStringValue(requestObject.WorkGroupName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AthenaSourceConfigMarshaller Instance = new AthenaSourceConfigMarshaller();

    }
}