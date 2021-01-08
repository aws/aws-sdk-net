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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Honeycode.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Honeycode.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TableDataImportJobMetadata Object
    /// </summary>  
    public class TableDataImportJobMetadataUnmarshaller : IUnmarshaller<TableDataImportJobMetadata, XmlUnmarshallerContext>, IUnmarshaller<TableDataImportJobMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TableDataImportJobMetadata IUnmarshaller<TableDataImportJobMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TableDataImportJobMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TableDataImportJobMetadata unmarshalledObject = new TableDataImportJobMetadata();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("dataSource", targetDepth))
                {
                    var unmarshaller = ImportDataSourceUnmarshaller.Instance;
                    unmarshalledObject.DataSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("importOptions", targetDepth))
                {
                    var unmarshaller = ImportOptionsUnmarshaller.Instance;
                    unmarshalledObject.ImportOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("submitter", targetDepth))
                {
                    var unmarshaller = ImportJobSubmitterUnmarshaller.Instance;
                    unmarshalledObject.Submitter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("submitTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.SubmitTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TableDataImportJobMetadataUnmarshaller _instance = new TableDataImportJobMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TableDataImportJobMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}