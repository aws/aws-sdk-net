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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ACMPCA.Model;
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
    public partial class KeyUsageUnmarshaller : ICborUnmarshaller<KeyUsage, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public KeyUsage Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new KeyUsage();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "CRLSign":
                        context.AddPathSegment("CRLSign");
                        unmarshalledObject.CRLSign = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DataEncipherment":
                        context.AddPathSegment("DataEncipherment");
                        unmarshalledObject.DataEncipherment = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DecipherOnly":
                        context.AddPathSegment("DecipherOnly");
                        unmarshalledObject.DecipherOnly = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DigitalSignature":
                        context.AddPathSegment("DigitalSignature");
                        unmarshalledObject.DigitalSignature = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EncipherOnly":
                        context.AddPathSegment("EncipherOnly");
                        unmarshalledObject.EncipherOnly = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "KeyAgreement":
                        context.AddPathSegment("KeyAgreement");
                        unmarshalledObject.KeyAgreement = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "KeyCertSign":
                        context.AddPathSegment("KeyCertSign");
                        unmarshalledObject.KeyCertSign = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "KeyEncipherment":
                        context.AddPathSegment("KeyEncipherment");
                        unmarshalledObject.KeyEncipherment = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NonRepudiation":
                        context.AddPathSegment("NonRepudiation");
                        unmarshalledObject.NonRepudiation = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

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
        public static KeyUsageUnmarshaller Instance => _instance;
    }
}
