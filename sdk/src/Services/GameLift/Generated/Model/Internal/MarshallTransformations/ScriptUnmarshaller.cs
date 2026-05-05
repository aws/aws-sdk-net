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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Script Object
    /// </summary>  
    public class ScriptUnmarshaller : ICborUnmarshaller<Script, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Script Unmarshall(CborUnmarshallerContext context)
        {
            Script unmarshalledObject = new Script();
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
                    case "CreationTime":
                        {
                            context.AddPathSegment("CreationTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NodeJsVersion":
                        {
                            context.AddPathSegment("NodeJsVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NodeJsVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScriptArn":
                        {
                            context.AddPathSegment("ScriptArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ScriptArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScriptId":
                        {
                            context.AddPathSegment("ScriptId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ScriptId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SizeOnDisk":
                        {
                            context.AddPathSegment("SizeOnDisk");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.SizeOnDisk = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StorageLocation":
                        {
                            context.AddPathSegment("StorageLocation");
                            var unmarshaller = S3LocationUnmarshaller.Instance;
                            unmarshalledObject.StorageLocation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Version":
                        {
                            context.AddPathSegment("Version");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Version = unmarshaller.Unmarshall(context);
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


        private static ScriptUnmarshaller _instance = new ScriptUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScriptUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}