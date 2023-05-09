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
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AmazonRedshiftNodeData Object
    /// </summary>  
    public class AmazonRedshiftNodeDataUnmarshaller : IUnmarshaller<AmazonRedshiftNodeData, XmlUnmarshallerContext>, IUnmarshaller<AmazonRedshiftNodeData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AmazonRedshiftNodeData IUnmarshaller<AmazonRedshiftNodeData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AmazonRedshiftNodeData Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AmazonRedshiftNodeData unmarshalledObject = new AmazonRedshiftNodeData();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Action", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Action = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AdvancedOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AmazonRedshiftAdvancedOption, AmazonRedshiftAdvancedOptionUnmarshaller>(AmazonRedshiftAdvancedOptionUnmarshaller.Instance);
                    unmarshalledObject.AdvancedOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogDatabase", targetDepth))
                {
                    var unmarshaller = OptionUnmarshaller.Instance;
                    unmarshalledObject.CatalogDatabase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogRedshiftSchema", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CatalogRedshiftSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogRedshiftTable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CatalogRedshiftTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogTable", targetDepth))
                {
                    var unmarshaller = OptionUnmarshaller.Instance;
                    unmarshalledObject.CatalogTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Connection", targetDepth))
                {
                    var unmarshaller = OptionUnmarshaller.Instance;
                    unmarshalledObject.Connection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrawlerConnection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CrawlerConnection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IamRole", targetDepth))
                {
                    var unmarshaller = OptionUnmarshaller.Instance;
                    unmarshalledObject.IamRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MergeAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MergeAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MergeClause", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MergeClause = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MergeWhenMatched", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MergeWhenMatched = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MergeWhenNotMatched", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MergeWhenNotMatched = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PostAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SampleQuery", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SampleQuery = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Schema", targetDepth))
                {
                    var unmarshaller = OptionUnmarshaller.Instance;
                    unmarshalledObject.Schema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectedColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Option, OptionUnmarshaller>(OptionUnmarshaller.Instance);
                    unmarshalledObject.SelectedColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StagingTable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StagingTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Table", targetDepth))
                {
                    var unmarshaller = OptionUnmarshaller.Instance;
                    unmarshalledObject.Table = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TablePrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TablePrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableSchema", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Option, OptionUnmarshaller>(OptionUnmarshaller.Instance);
                    unmarshalledObject.TableSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TempDir", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TempDir = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Upsert", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Upsert = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AmazonRedshiftNodeDataUnmarshaller _instance = new AmazonRedshiftNodeDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AmazonRedshiftNodeDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}