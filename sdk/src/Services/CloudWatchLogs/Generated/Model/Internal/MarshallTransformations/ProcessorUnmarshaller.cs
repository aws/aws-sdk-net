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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Processor Object
    /// </summary>  
    public class ProcessorUnmarshaller : ICborUnmarshaller<Processor, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Processor Unmarshall(CborUnmarshallerContext context)
        {
            Processor unmarshalledObject = new Processor();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "addKeys":
                        {
                            context.AddPathSegment("AddKeys");
                            var unmarshaller = AddKeysUnmarshaller.Instance;
                            unmarshalledObject.AddKeys = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "copyValue":
                        {
                            context.AddPathSegment("CopyValue");
                            var unmarshaller = CopyValueUnmarshaller.Instance;
                            unmarshalledObject.CopyValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "csv":
                        {
                            context.AddPathSegment("Csv");
                            var unmarshaller = CSVUnmarshaller.Instance;
                            unmarshalledObject.Csv = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "dateTimeConverter":
                        {
                            context.AddPathSegment("DateTimeConverter");
                            var unmarshaller = DateTimeConverterUnmarshaller.Instance;
                            unmarshalledObject.DateTimeConverter = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "deleteKeys":
                        {
                            context.AddPathSegment("DeleteKeys");
                            var unmarshaller = DeleteKeysUnmarshaller.Instance;
                            unmarshalledObject.DeleteKeys = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "grok":
                        {
                            context.AddPathSegment("Grok");
                            var unmarshaller = GrokUnmarshaller.Instance;
                            unmarshalledObject.Grok = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "listToMap":
                        {
                            context.AddPathSegment("ListToMap");
                            var unmarshaller = ListToMapUnmarshaller.Instance;
                            unmarshalledObject.ListToMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lowerCaseString":
                        {
                            context.AddPathSegment("LowerCaseString");
                            var unmarshaller = LowerCaseStringUnmarshaller.Instance;
                            unmarshalledObject.LowerCaseString = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "moveKeys":
                        {
                            context.AddPathSegment("MoveKeys");
                            var unmarshaller = MoveKeysUnmarshaller.Instance;
                            unmarshalledObject.MoveKeys = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "parseCloudfront":
                        {
                            context.AddPathSegment("ParseCloudfront");
                            var unmarshaller = ParseCloudfrontUnmarshaller.Instance;
                            unmarshalledObject.ParseCloudfront = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "parseJSON":
                        {
                            context.AddPathSegment("ParseJSON");
                            var unmarshaller = ParseJSONUnmarshaller.Instance;
                            unmarshalledObject.ParseJSON = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "parseKeyValue":
                        {
                            context.AddPathSegment("ParseKeyValue");
                            var unmarshaller = ParseKeyValueUnmarshaller.Instance;
                            unmarshalledObject.ParseKeyValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "parsePostgres":
                        {
                            context.AddPathSegment("ParsePostgres");
                            var unmarshaller = ParsePostgresUnmarshaller.Instance;
                            unmarshalledObject.ParsePostgres = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "parseRoute53":
                        {
                            context.AddPathSegment("ParseRoute53");
                            var unmarshaller = ParseRoute53Unmarshaller.Instance;
                            unmarshalledObject.ParseRoute53 = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "parseToOCSF":
                        {
                            context.AddPathSegment("ParseToOCSF");
                            var unmarshaller = ParseToOCSFUnmarshaller.Instance;
                            unmarshalledObject.ParseToOCSF = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "parseVPC":
                        {
                            context.AddPathSegment("ParseVPC");
                            var unmarshaller = ParseVPCUnmarshaller.Instance;
                            unmarshalledObject.ParseVPC = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "parseWAF":
                        {
                            context.AddPathSegment("ParseWAF");
                            var unmarshaller = ParseWAFUnmarshaller.Instance;
                            unmarshalledObject.ParseWAF = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "renameKeys":
                        {
                            context.AddPathSegment("RenameKeys");
                            var unmarshaller = RenameKeysUnmarshaller.Instance;
                            unmarshalledObject.RenameKeys = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "splitString":
                        {
                            context.AddPathSegment("SplitString");
                            var unmarshaller = SplitStringUnmarshaller.Instance;
                            unmarshalledObject.SplitString = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "substituteString":
                        {
                            context.AddPathSegment("SubstituteString");
                            var unmarshaller = SubstituteStringUnmarshaller.Instance;
                            unmarshalledObject.SubstituteString = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "trimString":
                        {
                            context.AddPathSegment("TrimString");
                            var unmarshaller = TrimStringUnmarshaller.Instance;
                            unmarshalledObject.TrimString = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "typeConverter":
                        {
                            context.AddPathSegment("TypeConverter");
                            var unmarshaller = TypeConverterUnmarshaller.Instance;
                            unmarshalledObject.TypeConverter = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "upperCaseString":
                        {
                            context.AddPathSegment("UpperCaseString");
                            var unmarshaller = UpperCaseStringUnmarshaller.Instance;
                            unmarshalledObject.UpperCaseString = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
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