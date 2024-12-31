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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Processor Object
    /// </summary>  
    public class ProcessorUnmarshaller : IUnmarshaller<Processor, XmlUnmarshallerContext>, IUnmarshaller<Processor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Processor IUnmarshaller<Processor, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Processor Unmarshall(JsonUnmarshallerContext context)
        {
            Processor unmarshalledObject = new Processor();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("addKeys", targetDepth))
                {
                    var unmarshaller = AddKeysUnmarshaller.Instance;
                    unmarshalledObject.AddKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("copyValue", targetDepth))
                {
                    var unmarshaller = CopyValueUnmarshaller.Instance;
                    unmarshalledObject.CopyValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("csv", targetDepth))
                {
                    var unmarshaller = CSVUnmarshaller.Instance;
                    unmarshalledObject.Csv = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dateTimeConverter", targetDepth))
                {
                    var unmarshaller = DateTimeConverterUnmarshaller.Instance;
                    unmarshalledObject.DateTimeConverter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deleteKeys", targetDepth))
                {
                    var unmarshaller = DeleteKeysUnmarshaller.Instance;
                    unmarshalledObject.DeleteKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("grok", targetDepth))
                {
                    var unmarshaller = GrokUnmarshaller.Instance;
                    unmarshalledObject.Grok = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listToMap", targetDepth))
                {
                    var unmarshaller = ListToMapUnmarshaller.Instance;
                    unmarshalledObject.ListToMap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lowerCaseString", targetDepth))
                {
                    var unmarshaller = LowerCaseStringUnmarshaller.Instance;
                    unmarshalledObject.LowerCaseString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("moveKeys", targetDepth))
                {
                    var unmarshaller = MoveKeysUnmarshaller.Instance;
                    unmarshalledObject.MoveKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parseCloudfront", targetDepth))
                {
                    var unmarshaller = ParseCloudfrontUnmarshaller.Instance;
                    unmarshalledObject.ParseCloudfront = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parseJSON", targetDepth))
                {
                    var unmarshaller = ParseJSONUnmarshaller.Instance;
                    unmarshalledObject.ParseJSON = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parseKeyValue", targetDepth))
                {
                    var unmarshaller = ParseKeyValueUnmarshaller.Instance;
                    unmarshalledObject.ParseKeyValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parsePostgres", targetDepth))
                {
                    var unmarshaller = ParsePostgresUnmarshaller.Instance;
                    unmarshalledObject.ParsePostgres = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parseRoute53", targetDepth))
                {
                    var unmarshaller = ParseRoute53Unmarshaller.Instance;
                    unmarshalledObject.ParseRoute53 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parseVPC", targetDepth))
                {
                    var unmarshaller = ParseVPCUnmarshaller.Instance;
                    unmarshalledObject.ParseVPC = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parseWAF", targetDepth))
                {
                    var unmarshaller = ParseWAFUnmarshaller.Instance;
                    unmarshalledObject.ParseWAF = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("renameKeys", targetDepth))
                {
                    var unmarshaller = RenameKeysUnmarshaller.Instance;
                    unmarshalledObject.RenameKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("splitString", targetDepth))
                {
                    var unmarshaller = SplitStringUnmarshaller.Instance;
                    unmarshalledObject.SplitString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("substituteString", targetDepth))
                {
                    var unmarshaller = SubstituteStringUnmarshaller.Instance;
                    unmarshalledObject.SubstituteString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trimString", targetDepth))
                {
                    var unmarshaller = TrimStringUnmarshaller.Instance;
                    unmarshalledObject.TrimString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("typeConverter", targetDepth))
                {
                    var unmarshaller = TypeConverterUnmarshaller.Instance;
                    unmarshalledObject.TypeConverter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("upperCaseString", targetDepth))
                {
                    var unmarshaller = UpperCaseStringUnmarshaller.Instance;
                    unmarshalledObject.UpperCaseString = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ProcessorUnmarshaller _instance = new ProcessorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProcessorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}