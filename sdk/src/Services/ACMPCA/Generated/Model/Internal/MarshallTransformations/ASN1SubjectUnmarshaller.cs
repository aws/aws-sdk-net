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
    /// Response Unmarshaller for ASN1Subject Object
    /// </summary>  
    public class ASN1SubjectUnmarshaller : ICborUnmarshaller<ASN1Subject, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ASN1Subject Unmarshall(CborUnmarshallerContext context)
        {
            ASN1Subject unmarshalledObject = new ASN1Subject();
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
                    case "CommonName":
                        {
                            context.AddPathSegment("CommonName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CommonName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Country":
                        {
                            context.AddPathSegment("Country");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Country = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CustomAttributes":
                        {
                            context.AddPathSegment("CustomAttributes");
                            var unmarshaller = new CborListUnmarshaller<CustomAttribute, CustomAttributeUnmarshaller>(CustomAttributeUnmarshaller.Instance);
                            unmarshalledObject.CustomAttributes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DistinguishedNameQualifier":
                        {
                            context.AddPathSegment("DistinguishedNameQualifier");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DistinguishedNameQualifier = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GenerationQualifier":
                        {
                            context.AddPathSegment("GenerationQualifier");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GenerationQualifier = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "GivenName":
                        {
                            context.AddPathSegment("GivenName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GivenName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Initials":
                        {
                            context.AddPathSegment("Initials");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Initials = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Locality":
                        {
                            context.AddPathSegment("Locality");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Locality = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Organization":
                        {
                            context.AddPathSegment("Organization");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Organization = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OrganizationalUnit":
                        {
                            context.AddPathSegment("OrganizationalUnit");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.OrganizationalUnit = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Pseudonym":
                        {
                            context.AddPathSegment("Pseudonym");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Pseudonym = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SerialNumber":
                        {
                            context.AddPathSegment("SerialNumber");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SerialNumber = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "State":
                        {
                            context.AddPathSegment("State");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.State = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Surname":
                        {
                            context.AddPathSegment("Surname");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Surname = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Title":
                        {
                            context.AddPathSegment("Title");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Title = unmarshaller.Unmarshall(context);
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


        private static ASN1SubjectUnmarshaller _instance = new ASN1SubjectUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ASN1SubjectUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}