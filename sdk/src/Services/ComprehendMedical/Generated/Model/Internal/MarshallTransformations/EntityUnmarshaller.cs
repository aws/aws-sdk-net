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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComprehendMedical.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Entity Object
    /// </summary>  
    public class EntityUnmarshaller : ICborUnmarshaller<Entity, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Entity Unmarshall(CborUnmarshallerContext context)
        {
            Entity unmarshalledObject = new Entity();
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
                    case "Attributes":
                        {
                            context.AddPathSegment("Attributes");
                            var unmarshaller = new CborListUnmarshaller<Attribute, AttributeUnmarshaller>(AttributeUnmarshaller.Instance);
                            unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BeginOffset":
                        {
                            context.AddPathSegment("BeginOffset");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.BeginOffset = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Category":
                        {
                            context.AddPathSegment("Category");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Category = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EndOffset":
                        {
                            context.AddPathSegment("EndOffset");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.EndOffset = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Id":
                        {
                            context.AddPathSegment("Id");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Score":
                        {
                            context.AddPathSegment("Score");
                            var unmarshaller = CborNullableFloatUnmarshaller.Instance;
                            unmarshalledObject.Score = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Text":
                        {
                            context.AddPathSegment("Text");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Text = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Traits":
                        {
                            context.AddPathSegment("Traits");
                            var unmarshaller = new CborListUnmarshaller<Trait, TraitUnmarshaller>(TraitUnmarshaller.Instance);
                            unmarshalledObject.Traits = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Type":
                        {
                            context.AddPathSegment("Type");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Type = unmarshaller.Unmarshall(context);
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


        private static EntityUnmarshaller _instance = new EntityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EntityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}