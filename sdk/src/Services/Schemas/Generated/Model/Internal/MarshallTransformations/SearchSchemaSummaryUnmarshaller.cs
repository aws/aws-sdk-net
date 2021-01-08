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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Schemas.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Schemas.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SearchSchemaSummary Object
    /// </summary>  
    public class SearchSchemaSummaryUnmarshaller : IUnmarshaller<SearchSchemaSummary, XmlUnmarshallerContext>, IUnmarshaller<SearchSchemaSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SearchSchemaSummary IUnmarshaller<SearchSchemaSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SearchSchemaSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SearchSchemaSummary unmarshalledObject = new SearchSchemaSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("RegistryName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegistryName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaVersions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SearchSchemaVersionSummary, SearchSchemaVersionSummaryUnmarshaller>(SearchSchemaVersionSummaryUnmarshaller.Instance);
                    unmarshalledObject.SchemaVersions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SearchSchemaSummaryUnmarshaller _instance = new SearchSchemaSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchSchemaSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}