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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteObjectStart();

                var marshaller = AmazonElasticsearchParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonElasticsearchParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAmazonOpenSearchParameters())
            {
                context.Writer.WritePropertyName("AmazonOpenSearchParameters");
                context.Writer.WriteObjectStart();

                var marshaller = AmazonOpenSearchParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonOpenSearchParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAthenaParameters())
            {
                context.Writer.WritePropertyName("AthenaParameters");
                context.Writer.WriteObjectStart();

                var marshaller = AthenaParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AthenaParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAuroraParameters())
            {
                context.Writer.WritePropertyName("AuroraParameters");
                context.Writer.WriteObjectStart();

                var marshaller = AuroraParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AuroraParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAuroraPostgreSqlParameters())
            {
                context.Writer.WritePropertyName("AuroraPostgreSqlParameters");
                context.Writer.WriteObjectStart();

                var marshaller = AuroraPostgreSqlParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AuroraPostgreSqlParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIotAnalyticsParameters())
            {
                context.Writer.WritePropertyName("AwsIotAnalyticsParameters");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIotAnalyticsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIotAnalyticsParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBigQueryParameters())
            {
                context.Writer.WritePropertyName("BigQueryParameters");
                context.Writer.WriteObjectStart();

                var marshaller = BigQueryParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.BigQueryParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabricksParameters())
            {
                context.Writer.WritePropertyName("DatabricksParameters");
                context.Writer.WriteObjectStart();

                var marshaller = DatabricksParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabricksParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExasolParameters())
            {
                context.Writer.WritePropertyName("ExasolParameters");
                context.Writer.WriteObjectStart();

                var marshaller = ExasolParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ExasolParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImpalaParameters())
            {
                context.Writer.WritePropertyName("ImpalaParameters");
                context.Writer.WriteObjectStart();

                var marshaller = ImpalaParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ImpalaParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJiraParameters())
            {
                context.Writer.WritePropertyName("JiraParameters");
                context.Writer.WriteObjectStart();

                var marshaller = JiraParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.JiraParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMariaDbParameters())
            {
                context.Writer.WritePropertyName("MariaDbParameters");
                context.Writer.WriteObjectStart();

                var marshaller = MariaDbParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.MariaDbParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMySqlParameters())
            {
                context.Writer.WritePropertyName("MySqlParameters");
                context.Writer.WriteObjectStart();

                var marshaller = MySqlParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.MySqlParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOracleParameters())
            {
                context.Writer.WritePropertyName("OracleParameters");
                context.Writer.WriteObjectStart();

                var marshaller = OracleParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.OracleParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPostgreSqlParameters())
            {
                context.Writer.WritePropertyName("PostgreSqlParameters");
                context.Writer.WriteObjectStart();

                var marshaller = PostgreSqlParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.PostgreSqlParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrestoParameters())
            {
                context.Writer.WritePropertyName("PrestoParameters");
                context.Writer.WriteObjectStart();

                var marshaller = PrestoParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.PrestoParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRdsParameters())
            {
                context.Writer.WritePropertyName("RdsParameters");
                context.Writer.WriteObjectStart();

                var marshaller = RdsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RdsParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRedshiftParameters())
            {
                context.Writer.WritePropertyName("RedshiftParameters");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3Parameters())
            {
                context.Writer.WritePropertyName("S3Parameters");
                context.Writer.WriteObjectStart();

                var marshaller = S3ParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Parameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServiceNowParameters())
            {
                context.Writer.WritePropertyName("ServiceNowParameters");
                context.Writer.WriteObjectStart();

                var marshaller = ServiceNowParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceNowParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSnowflakeParameters())
            {
                context.Writer.WritePropertyName("SnowflakeParameters");
                context.Writer.WriteObjectStart();

                var marshaller = SnowflakeParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SnowflakeParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSparkParameters())
            {
                context.Writer.WritePropertyName("SparkParameters");
                context.Writer.WriteObjectStart();

                var marshaller = SparkParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSqlServerParameters())
            {
                context.Writer.WritePropertyName("SqlServerParameters");
                context.Writer.WriteObjectStart();

                var marshaller = SqlServerParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SqlServerParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStarburstParameters())
            {
                context.Writer.WritePropertyName("StarburstParameters");
                context.Writer.WriteObjectStart();

                var marshaller = StarburstParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.StarburstParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTeradataParameters())
            {
                context.Writer.WritePropertyName("TeradataParameters");
                context.Writer.WriteObjectStart();

                var marshaller = TeradataParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.TeradataParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTrinoParameters())
            {
                context.Writer.WritePropertyName("TrinoParameters");
                context.Writer.WriteObjectStart();

                var marshaller = TrinoParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.TrinoParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTwitterParameters())
            {
                context.Writer.WritePropertyName("TwitterParameters");
                context.Writer.WriteObjectStart();

                var marshaller = TwitterParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.TwitterParameters, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataSourceParametersMarshaller Instance = new DataSourceParametersMarshaller();

    }
}