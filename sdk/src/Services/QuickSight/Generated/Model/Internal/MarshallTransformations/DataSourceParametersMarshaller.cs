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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataSourceParameters Marshaller
    /// </summary>
    public class DataSourceParametersMarshaller : IRequestMarshaller<DataSourceParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataSourceParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmazonElasticsearchParameters())
            {
                context.Writer.WritePropertyName("AmazonElasticsearchParameters");
                context.Writer.WriteStartObject();

                var marshaller = AmazonElasticsearchParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonElasticsearchParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAmazonOpenSearchParameters())
            {
                context.Writer.WritePropertyName("AmazonOpenSearchParameters");
                context.Writer.WriteStartObject();

                var marshaller = AmazonOpenSearchParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonOpenSearchParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAthenaParameters())
            {
                context.Writer.WritePropertyName("AthenaParameters");
                context.Writer.WriteStartObject();

                var marshaller = AthenaParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AthenaParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAuroraParameters())
            {
                context.Writer.WritePropertyName("AuroraParameters");
                context.Writer.WriteStartObject();

                var marshaller = AuroraParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AuroraParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAuroraPostgreSqlParameters())
            {
                context.Writer.WritePropertyName("AuroraPostgreSqlParameters");
                context.Writer.WriteStartObject();

                var marshaller = AuroraPostgreSqlParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AuroraPostgreSqlParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsIotAnalyticsParameters())
            {
                context.Writer.WritePropertyName("AwsIotAnalyticsParameters");
                context.Writer.WriteStartObject();

                var marshaller = AwsIotAnalyticsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIotAnalyticsParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBigQueryParameters())
            {
                context.Writer.WritePropertyName("BigQueryParameters");
                context.Writer.WriteStartObject();

                var marshaller = BigQueryParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.BigQueryParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomConnectionParameters())
            {
                context.Writer.WritePropertyName("CustomConnectionParameters");
                context.Writer.WriteStartObject();

                var marshaller = CustomConnectionParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomConnectionParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabricksParameters())
            {
                context.Writer.WritePropertyName("DatabricksParameters");
                context.Writer.WriteStartObject();

                var marshaller = DatabricksParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabricksParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExasolParameters())
            {
                context.Writer.WritePropertyName("ExasolParameters");
                context.Writer.WriteStartObject();

                var marshaller = ExasolParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ExasolParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImpalaParameters())
            {
                context.Writer.WritePropertyName("ImpalaParameters");
                context.Writer.WriteStartObject();

                var marshaller = ImpalaParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ImpalaParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJiraParameters())
            {
                context.Writer.WritePropertyName("JiraParameters");
                context.Writer.WriteStartObject();

                var marshaller = JiraParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.JiraParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMariaDbParameters())
            {
                context.Writer.WritePropertyName("MariaDbParameters");
                context.Writer.WriteStartObject();

                var marshaller = MariaDbParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.MariaDbParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMySqlParameters())
            {
                context.Writer.WritePropertyName("MySqlParameters");
                context.Writer.WriteStartObject();

                var marshaller = MySqlParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.MySqlParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOracleParameters())
            {
                context.Writer.WritePropertyName("OracleParameters");
                context.Writer.WriteStartObject();

                var marshaller = OracleParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.OracleParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPostgreSqlParameters())
            {
                context.Writer.WritePropertyName("PostgreSqlParameters");
                context.Writer.WriteStartObject();

                var marshaller = PostgreSqlParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.PostgreSqlParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrestoParameters())
            {
                context.Writer.WritePropertyName("PrestoParameters");
                context.Writer.WriteStartObject();

                var marshaller = PrestoParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.PrestoParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRdsParameters())
            {
                context.Writer.WritePropertyName("RdsParameters");
                context.Writer.WriteStartObject();

                var marshaller = RdsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RdsParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRedshiftParameters())
            {
                context.Writer.WritePropertyName("RedshiftParameters");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Parameters())
            {
                context.Writer.WritePropertyName("S3Parameters");
                context.Writer.WriteStartObject();

                var marshaller = S3ParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Parameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceNowParameters())
            {
                context.Writer.WritePropertyName("ServiceNowParameters");
                context.Writer.WriteStartObject();

                var marshaller = ServiceNowParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceNowParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnowflakeParameters())
            {
                context.Writer.WritePropertyName("SnowflakeParameters");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SnowflakeParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSparkParameters())
            {
                context.Writer.WritePropertyName("SparkParameters");
                context.Writer.WriteStartObject();

                var marshaller = SparkParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqlServerParameters())
            {
                context.Writer.WritePropertyName("SqlServerParameters");
                context.Writer.WriteStartObject();

                var marshaller = SqlServerParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SqlServerParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStarburstParameters())
            {
                context.Writer.WritePropertyName("StarburstParameters");
                context.Writer.WriteStartObject();

                var marshaller = StarburstParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.StarburstParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTeradataParameters())
            {
                context.Writer.WritePropertyName("TeradataParameters");
                context.Writer.WriteStartObject();

                var marshaller = TeradataParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.TeradataParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrinoParameters())
            {
                context.Writer.WritePropertyName("TrinoParameters");
                context.Writer.WriteStartObject();

                var marshaller = TrinoParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.TrinoParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTwitterParameters())
            {
                context.Writer.WritePropertyName("TwitterParameters");
                context.Writer.WriteStartObject();

                var marshaller = TwitterParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.TwitterParameters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataSourceParametersMarshaller Instance = new DataSourceParametersMarshaller();

    }
}