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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KeyUsage Object
    /// </summary>  
    public class KeyUsageUnmarshaller : ICborUnmarshaller<KeyUsage, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public KeyUsage Unmarshall(CborUnmarshallerContext context)
        {
            KeyUsage unmarshalledObject = new KeyUsage();
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
                    case "CRLSign":
                        {
                            context.AddPathSegment("CRLSign");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.CRLSign = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DataEncipherment":
                        {
                            context.AddPathSegment("DataEncipherment");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.DataEncipherment = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DecipherOnly":
                        {
                            context.AddPathSegment("DecipherOnly");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.DecipherOnly = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DigitalSignature":
                        {
                            context.AddPathSegment("DigitalSignature");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.DigitalSignature = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EncipherOnly":
                        {
                            context.AddPathSegment("EncipherOnly");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.EncipherOnly = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "KeyAgreement":
                        {
                            context.AddPathSegment("KeyAgreement");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.KeyAgreement = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "KeyCertSign":
                        {
                            context.AddPathSegment("KeyCertSign");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.KeyCertSign = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "KeyEncipherment":
                        {
                            context.AddPathSegment("KeyEncipherment");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.KeyEncipherment = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NonRepudiation":
                        {
                            context.AddPathSegment("NonRepudiation");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.NonRepudiation = unmarshaller.Unmarshall(context);
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


        private static KeyUsageUnmarshaller _instance = new KeyUsageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KeyUsageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}