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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CrawlerTargets Object
    /// </summary>  
    public class CrawlerTargetsUnmarshaller : IJsonUnmarshaller<CrawlerTargets, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CrawlerTargets Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CrawlerTargets unmarshalledObject = new CrawlerTargets();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CatalogTargets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CatalogTarget, CatalogTargetUnmarshaller>(CatalogTargetUnmarshaller.Instance);
                    unmarshalledObject.CatalogTargets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeltaTargets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DeltaTarget, DeltaTargetUnmarshaller>(DeltaTargetUnmarshaller.Instance);
                    unmarshalledObject.DeltaTargets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DynamoDBTargets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DynamoDBTarget, DynamoDBTargetUnmarshaller>(DynamoDBTargetUnmarshaller.Instance);
                    unmarshalledObject.DynamoDBTargets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HudiTargets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HudiTarget, HudiTargetUnmarshaller>(HudiTargetUnmarshaller.Instance);
                    unmarshalledObject.HudiTargets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IcebergTargets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<IcebergTarget, IcebergTargetUnmarshaller>(IcebergTargetUnmarshaller.Instance);
                    unmarshalledObject.IcebergTargets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JdbcTargets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<JdbcTarget, JdbcTargetUnmarshaller>(JdbcTargetUnmarshaller.Instance);
                    unmarshalledObject.JdbcTargets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MongoDBTargets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MongoDBTarget, MongoDBTargetUnmarshaller>(MongoDBTargetUnmarshaller.Instance);
                    unmarshalledObject.MongoDBTargets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3Targets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<S3Target, S3TargetUnmarshaller>(S3TargetUnmarshaller.Instance);
                    unmarshalledObject.S3Targets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CrawlerTargetsUnmarshaller _instance = new CrawlerTargetsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CrawlerTargetsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}