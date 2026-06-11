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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Processor Object
    /// </summary>  
    public class ProcessorUnmarshaller : IJsonUnmarshaller<Processor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Processor Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Processor unmarshalledObject = new Processor();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("addKeys", targetDepth, ref reader))
                {
                    var unmarshaller = AddKeysUnmarshaller.Instance;
                    unmarshalledObject.AddKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("copyValue", targetDepth, ref reader))
                {
                    var unmarshaller = CopyValueUnmarshaller.Instance;
                    unmarshalledObject.CopyValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("csv", targetDepth, ref reader))
                {
                    var unmarshaller = CSVUnmarshaller.Instance;
                    unmarshalledObject.Csv = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dateTimeConverter", targetDepth, ref reader))
                {
                    var unmarshaller = DateTimeConverterUnmarshaller.Instance;
                    unmarshalledObject.DateTimeConverter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deleteKeys", targetDepth, ref reader))
                {
                    var unmarshaller = DeleteKeysUnmarshaller.Instance;
                    unmarshalledObject.DeleteKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("grok", targetDepth, ref reader))
                {
                    var unmarshaller = GrokUnmarshaller.Instance;
                    unmarshalledObject.Grok = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("listToMap", targetDepth, ref reader))
                {
                    var unmarshaller = ListToMapUnmarshaller.Instance;
                    unmarshalledObject.ListToMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lowerCaseString", targetDepth, ref reader))
                {
                    var unmarshaller = LowerCaseStringUnmarshaller.Instance;
                    unmarshalledObject.LowerCaseString = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("moveKeys", targetDepth, ref reader))
                {
                    var unmarshaller = MoveKeysUnmarshaller.Instance;
                    unmarshalledObject.MoveKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parseCloudfront", targetDepth, ref reader))
                {
                    var unmarshaller = ParseCloudfrontUnmarshaller.Instance;
                    unmarshalledObject.ParseCloudfront = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parseJSON", targetDepth, ref reader))
                {
                    var unmarshaller = ParseJSONUnmarshaller.Instance;
                    unmarshalledObject.ParseJSON = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parseKeyValue", targetDepth, ref reader))
                {
                    var unmarshaller = ParseKeyValueUnmarshaller.Instance;
                    unmarshalledObject.ParseKeyValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parsePostgres", targetDepth, ref reader))
                {
                    var unmarshaller = ParsePostgresUnmarshaller.Instance;
                    unmarshalledObject.ParsePostgres = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parseRoute53", targetDepth, ref reader))
                {
                    var unmarshaller = ParseRoute53Unmarshaller.Instance;
                    unmarshalledObject.ParseRoute53 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parseToOCSF", targetDepth, ref reader))
                {
                    var unmarshaller = ParseToOCSFUnmarshaller.Instance;
                    unmarshalledObject.ParseToOCSF = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parseVPC", targetDepth, ref reader))
                {
                    var unmarshaller = ParseVPCUnmarshaller.Instance;
                    unmarshalledObject.ParseVPC = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parseWAF", targetDepth, ref reader))
                {
                    var unmarshaller = ParseWAFUnmarshaller.Instance;
                    unmarshalledObject.ParseWAF = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("renameKeys", targetDepth, ref reader))
                {
                    var unmarshaller = RenameKeysUnmarshaller.Instance;
                    unmarshalledObject.RenameKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("splitString", targetDepth, ref reader))
                {
                    var unmarshaller = SplitStringUnmarshaller.Instance;
                    unmarshalledObject.SplitString = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("substituteString", targetDepth, ref reader))
                {
                    var unmarshaller = SubstituteStringUnmarshaller.Instance;
                    unmarshalledObject.SubstituteString = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("trimString", targetDepth, ref reader))
                {
                    var unmarshaller = TrimStringUnmarshaller.Instance;
                    unmarshalledObject.TrimString = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("typeConverter", targetDepth, ref reader))
                {
                    var unmarshaller = TypeConverterUnmarshaller.Instance;
                    unmarshalledObject.TypeConverter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("upperCaseString", targetDepth, ref reader))
                {
                    var unmarshaller = UpperCaseStringUnmarshaller.Instance;
                    unmarshalledObject.UpperCaseString = unmarshaller.Unmarshall(context, ref reader);
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