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

using Amazon.Route53Domains.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDomainDetail operation.
    /// </summary>
    public partial class GetDomainDetailResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new GetDomainDetailResponse();
            var reader = context.Reader;

            context.AddPathSegment("GetDomainDetail");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AbuseContactEmail":
                        context.AddPathSegment("AbuseContactEmail");
                        unmarshalledObject.AbuseContactEmail = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AbuseContactPhone":
                        context.AddPathSegment("AbuseContactPhone");
                        unmarshalledObject.AbuseContactPhone = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AdminContact":
                        context.AddPathSegment("AdminContact");
                        unmarshalledObject.AdminContact = ContactDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AdminPrivacy":
                        context.AddPathSegment("AdminPrivacy");
                        unmarshalledObject.AdminPrivacy = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AutoRenew":
                        context.AddPathSegment("AutoRenew");
                        unmarshalledObject.AutoRenew = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BillingContact":
                        context.AddPathSegment("BillingContact");
                        unmarshalledObject.BillingContact = ContactDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BillingPrivacy":
                        context.AddPathSegment("BillingPrivacy");
                        unmarshalledObject.BillingPrivacy = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationDate":
                        context.AddPathSegment("CreationDate");
                        unmarshalledObject.CreationDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnsSec":
                        context.AddPathSegment("DnsSec");
                        unmarshalledObject.DnsSec = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DnssecKeys":
                        context.AddPathSegment("DnssecKeys");
                        unmarshalledObject.DnssecKeys = new CborListUnmarshaller<DnssecKey, DnssecKeyUnmarshaller>(DnssecKeyUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DomainName":
                        context.AddPathSegment("DomainName");
                        unmarshalledObject.DomainName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExpirationDate":
                        context.AddPathSegment("ExpirationDate");
                        unmarshalledObject.ExpirationDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Nameservers":
                        context.AddPathSegment("Nameservers");
                        unmarshalledObject.Nameservers = new CborListUnmarshaller<Nameserver, NameserverUnmarshaller>(NameserverUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RegistrantContact":
                        context.AddPathSegment("RegistrantContact");
                        unmarshalledObject.RegistrantContact = ContactDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RegistrantPrivacy":
                        context.AddPathSegment("RegistrantPrivacy");
                        unmarshalledObject.RegistrantPrivacy = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RegistrarName":
                        context.AddPathSegment("RegistrarName");
                        unmarshalledObject.RegistrarName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RegistrarUrl":
                        context.AddPathSegment("RegistrarUrl");
                        unmarshalledObject.RegistrarUrl = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RegistryDomainId":
                        context.AddPathSegment("RegistryDomainId");
                        unmarshalledObject.RegistryDomainId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Reseller":
                        context.AddPathSegment("Reseller");
                        unmarshalledObject.Reseller = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StatusList":
                        context.AddPathSegment("StatusList");
                        unmarshalledObject.StatusList = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TechContact":
                        context.AddPathSegment("TechContact");
                        unmarshalledObject.TechContact = ContactDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TechPrivacy":
                        context.AddPathSegment("TechPrivacy");
                        unmarshalledObject.TechPrivacy = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UpdatedDate":
                        context.AddPathSegment("UpdatedDate");
                        unmarshalledObject.UpdatedDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WhoIsServer":
                        context.AddPathSegment("WhoIsServer");
                        unmarshalledObject.WhoIsServer = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInput"))
                    {
                        return InvalidInputExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedTLD"))
                    {
                        return UnsupportedTLDExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonRoute53DomainsException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetDomainDetailResponseUnmarshaller _instance = new GetDomainDetailResponseUnmarshaller();

        internal static GetDomainDetailResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDomainDetailResponseUnmarshaller Instance => _instance;
    }
}
