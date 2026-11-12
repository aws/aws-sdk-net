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
    /// Response Unmarshaller for CertificateAuthority Object
    /// </summary>
    public partial class CertificateAuthorityUnmarshaller : ICborUnmarshaller<CertificateAuthority, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CertificateAuthority Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new CertificateAuthority();
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
                    case "Arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CertificateAuthorityConfiguration":
                        context.AddPathSegment("CertificateAuthorityConfiguration");
                        unmarshalledObject.CertificateAuthorityConfiguration = CertificateAuthorityConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedAt":
                        context.AddPathSegment("CreatedAt");
                        unmarshalledObject.CreatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FailureReason":
                        context.AddPathSegment("FailureReason");
                        unmarshalledObject.FailureReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "KeyStorageSecurityStandard":
                        context.AddPathSegment("KeyStorageSecurityStandard");
                        unmarshalledObject.KeyStorageSecurityStandard = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastStateChangeAt":
                        context.AddPathSegment("LastStateChangeAt");
                        unmarshalledObject.LastStateChangeAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NotAfter":
                        context.AddPathSegment("NotAfter");
                        unmarshalledObject.NotAfter = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NotBefore":
                        context.AddPathSegment("NotBefore");
                        unmarshalledObject.NotBefore = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OwnerAccount":
                        context.AddPathSegment("OwnerAccount");
                        unmarshalledObject.OwnerAccount = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RestorableUntil":
                        context.AddPathSegment("RestorableUntil");
                        unmarshalledObject.RestorableUntil = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RevocationConfiguration":
                        context.AddPathSegment("RevocationConfiguration");
                        unmarshalledObject.RevocationConfiguration = RevocationConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Serial":
                        context.AddPathSegment("Serial");
                        unmarshalledObject.Serial = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UsageMode":
                        context.AddPathSegment("UsageMode");
                        unmarshalledObject.UsageMode = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static CertificateAuthorityUnmarshaller _instance = new CertificateAuthorityUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CertificateAuthorityUnmarshaller Instance => _instance;
    }
}
