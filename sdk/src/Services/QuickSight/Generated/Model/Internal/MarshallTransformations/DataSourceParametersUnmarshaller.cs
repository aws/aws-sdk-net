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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataSourceParameters Object
    /// </summary>  
    public class DataSourceParametersUnmarshaller : IJsonUnmarshaller<DataSourceParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DataSourceParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DataSourceParameters unmarshalledObject = new DataSourceParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AmazonElasticsearchParameters", targetDepth))
                {
                    var unmarshaller = AmazonElasticsearchParametersUnmarshaller.Instance;
                    unmarshalledObject.AmazonElasticsearchParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AmazonOpenSearchParameters", targetDepth))
                {
                    var unmarshaller = AmazonOpenSearchParametersUnmarshaller.Instance;
                    unmarshalledObject.AmazonOpenSearchParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AthenaParameters", targetDepth))
                {
                    var unmarshaller = AthenaParametersUnmarshaller.Instance;
                    unmarshalledObject.AthenaParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AuroraParameters", targetDepth))
                {
                    var unmarshaller = AuroraParametersUnmarshaller.Instance;
                    unmarshalledObject.AuroraParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AuroraPostgreSqlParameters", targetDepth))
                {
                    var unmarshaller = AuroraPostgreSqlParametersUnmarshaller.Instance;
                    unmarshalledObject.AuroraPostgreSqlParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsIotAnalyticsParameters", targetDepth))
                {
                    var unmarshaller = AwsIotAnalyticsParametersUnmarshaller.Instance;
                    unmarshalledObject.AwsIotAnalyticsParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BigQueryParameters", targetDepth))
                {
                    var unmarshaller = BigQueryParametersUnmarshaller.Instance;
                    unmarshalledObject.BigQueryParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CustomConnectionParameters", targetDepth))
                {
                    var unmarshaller = CustomConnectionParametersUnmarshaller.Instance;
                    unmarshalledObject.CustomConnectionParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DatabricksParameters", targetDepth))
                {
                    var unmarshaller = DatabricksParametersUnmarshaller.Instance;
                    unmarshalledObject.DatabricksParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExasolParameters", targetDepth))
                {
                    var unmarshaller = ExasolParametersUnmarshaller.Instance;
                    unmarshalledObject.ExasolParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImpalaParameters", targetDepth))
                {
                    var unmarshaller = ImpalaParametersUnmarshaller.Instance;
                    unmarshalledObject.ImpalaParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JiraParameters", targetDepth))
                {
                    var unmarshaller = JiraParametersUnmarshaller.Instance;
                    unmarshalledObject.JiraParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MariaDbParameters", targetDepth))
                {
                    var unmarshaller = MariaDbParametersUnmarshaller.Instance;
                    unmarshalledObject.MariaDbParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MySqlParameters", targetDepth))
                {
                    var unmarshaller = MySqlParametersUnmarshaller.Instance;
                    unmarshalledObject.MySqlParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OracleParameters", targetDepth))
                {
                    var unmarshaller = OracleParametersUnmarshaller.Instance;
                    unmarshalledObject.OracleParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PostgreSqlParameters", targetDepth))
                {
                    var unmarshaller = PostgreSqlParametersUnmarshaller.Instance;
                    unmarshalledObject.PostgreSqlParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrestoParameters", targetDepth))
                {
                    var unmarshaller = PrestoParametersUnmarshaller.Instance;
                    unmarshalledObject.PrestoParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RdsParameters", targetDepth))
                {
                    var unmarshaller = RdsParametersUnmarshaller.Instance;
                    unmarshalledObject.RdsParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RedshiftParameters", targetDepth))
                {
                    var unmarshaller = RedshiftParametersUnmarshaller.Instance;
                    unmarshalledObject.RedshiftParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3Parameters", targetDepth))
                {
                    var unmarshaller = S3ParametersUnmarshaller.Instance;
                    unmarshalledObject.S3Parameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceNowParameters", targetDepth))
                {
                    var unmarshaller = ServiceNowParametersUnmarshaller.Instance;
                    unmarshalledObject.ServiceNowParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SnowflakeParameters", targetDepth))
                {
                    var unmarshaller = SnowflakeParametersUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SparkParameters", targetDepth))
                {
                    var unmarshaller = SparkParametersUnmarshaller.Instance;
                    unmarshalledObject.SparkParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SqlServerParameters", targetDepth))
                {
                    var unmarshaller = SqlServerParametersUnmarshaller.Instance;
                    unmarshalledObject.SqlServerParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StarburstParameters", targetDepth))
                {
                    var unmarshaller = StarburstParametersUnmarshaller.Instance;
                    unmarshalledObject.StarburstParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TeradataParameters", targetDepth))
                {
                    var unmarshaller = TeradataParametersUnmarshaller.Instance;
                    unmarshalledObject.TeradataParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrinoParameters", targetDepth))
                {
                    var unmarshaller = TrinoParametersUnmarshaller.Instance;
                    unmarshalledObject.TrinoParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TwitterParameters", targetDepth))
                {
                    var unmarshaller = TwitterParametersUnmarshaller.Instance;
                    unmarshalledObject.TwitterParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataSourceParametersUnmarshaller _instance = new DataSourceParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataSourceParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}