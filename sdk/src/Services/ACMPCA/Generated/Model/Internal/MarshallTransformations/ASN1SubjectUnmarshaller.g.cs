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
    /// Response Unmarshaller for ASN1Subject Object
    /// </summary>
    public partial class ASN1SubjectUnmarshaller : ICborUnmarshaller<ASN1Subject, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ASN1Subject Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ASN1Subject();
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
                    case "CommonName":
                        context.AddPathSegment("CommonName");
                        unmarshalledObject.CommonName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Country":
                        context.AddPathSegment("Country");
                        unmarshalledObject.Country = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CustomAttributes":
                        context.AddPathSegment("CustomAttributes");
                        unmarshalledObject.CustomAttributes = new CborListUnmarshaller<CustomAttribute, CustomAttributeUnmarshaller>(CustomAttributeUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DistinguishedNameQualifier":
                        context.AddPathSegment("DistinguishedNameQualifier");
                        unmarshalledObject.DistinguishedNameQualifier = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GenerationQualifier":
                        context.AddPathSegment("GenerationQualifier");
                        unmarshalledObject.GenerationQualifier = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "GivenName":
                        context.AddPathSegment("GivenName");
                        unmarshalledObject.GivenName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Initials":
                        context.AddPathSegment("Initials");
                        unmarshalledObject.Initials = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Locality":
                        context.AddPathSegment("Locality");
                        unmarshalledObject.Locality = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Organization":
                        context.AddPathSegment("Organization");
                        unmarshalledObject.Organization = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OrganizationalUnit":
                        context.AddPathSegment("OrganizationalUnit");
                        unmarshalledObject.OrganizationalUnit = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Pseudonym":
                        context.AddPathSegment("Pseudonym");
                        unmarshalledObject.Pseudonym = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SerialNumber":
                        context.AddPathSegment("SerialNumber");
                        unmarshalledObject.SerialNumber = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Surname":
                        context.AddPathSegment("Surname");
                        unmarshalledObject.Surname = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Title":
                        context.AddPathSegment("Title");
                        unmarshalledObject.Title = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ASN1SubjectUnmarshaller _instance = new ASN1SubjectUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ASN1SubjectUnmarshaller Instance => _instance;
    }
}
