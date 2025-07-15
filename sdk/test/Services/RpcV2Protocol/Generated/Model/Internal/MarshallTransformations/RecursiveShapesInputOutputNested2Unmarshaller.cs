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
 * Do not modify this file. This file is generated from the rpcv2protocol-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RpcV2Protocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecursiveShapesInputOutputNested2 Object
    /// </summary>  
    public class RecursiveShapesInputOutputNested2Unmarshaller : ICborUnmarshaller<RecursiveShapesInputOutputNested2, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RecursiveShapesInputOutputNested2 Unmarshall(CborUnmarshallerContext context)
        {
            RecursiveShapesInputOutputNested2 unmarshalledObject = new RecursiveShapesInputOutputNested2();
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
                    case "bar":
                        {
                            context.AddPathSegment("Bar");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Bar = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recursiveMember":
                        {
                            context.AddPathSegment("RecursiveMember");
                            var unmarshaller = RecursiveShapesInputOutputNested1Unmarshaller.Instance;
                            unmarshalledObject.RecursiveMember = unmarshaller.Unmarshall(context);
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


        private static RecursiveShapesInputOutputNested2Unmarshaller _instance = new RecursiveShapesInputOutputNested2Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecursiveShapesInputOutputNested2Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}