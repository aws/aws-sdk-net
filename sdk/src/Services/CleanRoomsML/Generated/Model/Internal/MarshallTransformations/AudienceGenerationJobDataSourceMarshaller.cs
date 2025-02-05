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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AudienceGenerationJobDataSource Marshaller
    /// </summary>
    public class AudienceGenerationJobDataSourceMarshaller : IRequestMarshaller<AudienceGenerationJobDataSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudienceGenerationJobDataSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataSource())
            {
                context.Writer.WritePropertyName("dataSource");
                context.Writer.WriteStartObject();

                var marshaller = S3ConfigMapMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetSqlComputeConfiguration())
            {
                context.Writer.WritePropertyName("sqlComputeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ComputeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SqlComputeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqlParameters())
            {
                context.Writer.WritePropertyName("sqlParameters");
                context.Writer.WriteStartObject();

                var marshaller = ProtectedQuerySQLParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SqlParameters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AudienceGenerationJobDataSourceMarshaller Instance = new AudienceGenerationJobDataSourceMarshaller();

    }
}