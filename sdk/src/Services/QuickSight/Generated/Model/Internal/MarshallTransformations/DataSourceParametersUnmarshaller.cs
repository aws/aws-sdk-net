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
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataSourceParameters Object
    /// </summary>  
    public class DataSourceParametersUnmarshaller : IUnmarshaller<DataSourceParameters, XmlUnmarshallerContext>, IUnmarshaller<DataSourceParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataSourceParameters IUnmarshaller<DataSourceParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataSourceParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataSourceParameters unmarshalledObject = new DataSourceParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmazonElasticsearchParameters", targetDepth))
                {
                    var unmarshaller = AmazonElasticsearchParametersUnmarshaller.Instance;
                    unmarshalledObject.AmazonElasticsearchParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AthenaParameters", targetDepth))
                {
                    var unmarshaller = AthenaParametersUnmarshaller.Instance;
                    unmarshalledObject.AthenaParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuroraParameters", targetDepth))
                {
                    var unmarshaller = AuroraParametersUnmarshaller.Instance;
                    unmarshalledObject.AuroraParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AuroraPostgreSqlParameters", targetDepth))
                {
                    var unmarshaller = AuroraPostgreSqlParametersUnmarshaller.Instance;
                    unmarshalledObject.AuroraPostgreSqlParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsIotAnalyticsParameters", targetDepth))
                {
                    var unmarshaller = AwsIotAnalyticsParametersUnmarshaller.Instance;
                    unmarshalledObject.AwsIotAnalyticsParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JiraParameters", targetDepth))
                {
                    var unmarshaller = JiraParametersUnmarshaller.Instance;
                    unmarshalledObject.JiraParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MariaDbParameters", targetDepth))
                {
                    var unmarshaller = MariaDbParametersUnmarshaller.Instance;
                    unmarshalledObject.MariaDbParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MySqlParameters", targetDepth))
                {
                    var unmarshaller = MySqlParametersUnmarshaller.Instance;
                    unmarshalledObject.MySqlParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OracleParameters", targetDepth))
                {
                    var unmarshaller = OracleParametersUnmarshaller.Instance;
                    unmarshalledObject.OracleParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostgreSqlParameters", targetDepth))
                {
                    var unmarshaller = PostgreSqlParametersUnmarshaller.Instance;
                    unmarshalledObject.PostgreSqlParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrestoParameters", targetDepth))
                {
                    var unmarshaller = PrestoParametersUnmarshaller.Instance;
                    unmarshalledObject.PrestoParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RdsParameters", targetDepth))
                {
                    var unmarshaller = RdsParametersUnmarshaller.Instance;
                    unmarshalledObject.RdsParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftParameters", targetDepth))
                {
                    var unmarshaller = RedshiftParametersUnmarshaller.Instance;
                    unmarshalledObject.RedshiftParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3Parameters", targetDepth))
                {
                    var unmarshaller = S3ParametersUnmarshaller.Instance;
                    unmarshalledObject.S3Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceNowParameters", targetDepth))
                {
                    var unmarshaller = ServiceNowParametersUnmarshaller.Instance;
                    unmarshalledObject.ServiceNowParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnowflakeParameters", targetDepth))
                {
                    var unmarshaller = SnowflakeParametersUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SparkParameters", targetDepth))
                {
                    var unmarshaller = SparkParametersUnmarshaller.Instance;
                    unmarshalledObject.SparkParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SqlServerParameters", targetDepth))
                {
                    var unmarshaller = SqlServerParametersUnmarshaller.Instance;
                    unmarshalledObject.SqlServerParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TeradataParameters", targetDepth))
                {
                    var unmarshaller = TeradataParametersUnmarshaller.Instance;
                    unmarshalledObject.TeradataParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TwitterParameters", targetDepth))
                {
                    var unmarshaller = TwitterParametersUnmarshaller.Instance;
                    unmarshalledObject.TwitterParameters = unmarshaller.Unmarshall(context);
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