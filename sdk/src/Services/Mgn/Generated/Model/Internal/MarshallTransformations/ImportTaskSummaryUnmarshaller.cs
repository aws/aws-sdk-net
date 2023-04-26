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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImportTaskSummary Object
    /// </summary>  
    public class ImportTaskSummaryUnmarshaller : IUnmarshaller<ImportTaskSummary, XmlUnmarshallerContext>, IUnmarshaller<ImportTaskSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ImportTaskSummary IUnmarshaller<ImportTaskSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ImportTaskSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ImportTaskSummary unmarshalledObject = new ImportTaskSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("applications", targetDepth))
                {
                    var unmarshaller = ImportTaskSummaryApplicationsUnmarshaller.Instance;
                    unmarshalledObject.Applications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("servers", targetDepth))
                {
                    var unmarshaller = ImportTaskSummaryServersUnmarshaller.Instance;
                    unmarshalledObject.Servers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("waves", targetDepth))
                {
                    var unmarshaller = ImportTaskSummaryWavesUnmarshaller.Instance;
                    unmarshalledObject.Waves = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ImportTaskSummaryUnmarshaller _instance = new ImportTaskSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportTaskSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}