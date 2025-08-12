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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeStreaming.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CharacterOffsets Object
    /// </summary>  
    public class CharacterOffsetsUnmarshaller : ICborUnmarshaller<CharacterOffsets, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CharacterOffsets Unmarshall(CborUnmarshallerContext context)
        {
            CharacterOffsets unmarshalledObject = new CharacterOffsets();
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
                    case "Begin":
                        {
                            context.AddPathSegment("Begin");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.Begin = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "End":
                        {
                            context.AddPathSegment("End");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.End = unmarshaller.Unmarshall(context);
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


        private static CharacterOffsetsUnmarshaller _instance = new CharacterOffsetsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CharacterOffsetsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}