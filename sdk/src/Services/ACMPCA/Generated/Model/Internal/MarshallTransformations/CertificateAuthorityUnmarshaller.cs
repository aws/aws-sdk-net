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
    /// Response Unmarshaller for CertificateAuthority Object
    /// </summary>  
    public class CertificateAuthorityUnmarshaller : ICborUnmarshaller<CertificateAuthority, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CertificateAuthority Unmarshall(CborUnmarshallerContext context)
        {
            CertificateAuthority unmarshalledObject = new CertificateAuthority();
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
                    case "Arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CertificateAuthorityConfiguration":
                        {
                            context.AddPathSegment("CertificateAuthorityConfiguration");
                            var unmarshaller = CertificateAuthorityConfigurationUnmarshaller.Instance;
                            unmarshalledObject.CertificateAuthorityConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatedAt":
                        {
                            context.AddPathSegment("CreatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FailureReason":
                        {
                            context.AddPathSegment("FailureReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "KeyStorageSecurityStandard":
                        {
                            context.AddPathSegment("KeyStorageSecurityStandard");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.KeyStorageSecurityStandard = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastStateChangeAt":
                        {
                            context.AddPathSegment("LastStateChangeAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastStateChangeAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NotAfter":
                        {
                            context.AddPathSegment("NotAfter");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.NotAfter = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NotBefore":
                        {
                            context.AddPathSegment("NotBefore");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.NotBefore = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OwnerAccount":
                        {
                            context.AddPathSegment("OwnerAccount");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.OwnerAccount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RestorableUntil":
                        {
                            context.AddPathSegment("RestorableUntil");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.RestorableUntil = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RevocationConfiguration":
                        {
                            context.AddPathSegment("RevocationConfiguration");
                            var unmarshaller = RevocationConfigurationUnmarshaller.Instance;
                            unmarshalledObject.RevocationConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Serial":
                        {
                            context.AddPathSegment("Serial");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Serial = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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
                    case "UsageMode":
                        {
                            context.AddPathSegment("UsageMode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.UsageMode = unmarshaller.Unmarshall(context);
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


        private static CertificateAuthorityUnmarshaller _instance = new CertificateAuthorityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CertificateAuthorityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}