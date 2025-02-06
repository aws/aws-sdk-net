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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Domains.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDomainDetail operation
    /// </summary>  
    public class GetDomainDetailResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetDomainDetailResponse response = new GetDomainDetailResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AbuseContactEmail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AbuseContactEmail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AbuseContactPhone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AbuseContactPhone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AdminContact", targetDepth))
                {
                    var unmarshaller = ContactDetailUnmarshaller.Instance;
                    response.AdminContact = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AdminPrivacy", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.AdminPrivacy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AutoRenew", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.AutoRenew = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BillingContact", targetDepth))
                {
                    var unmarshaller = ContactDetailUnmarshaller.Instance;
                    response.BillingContact = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BillingPrivacy", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.BillingPrivacy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreationDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsSec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DnsSec = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnssecKeys", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DnssecKey, DnssecKeyUnmarshaller>(DnssecKeyUnmarshaller.Instance);
                    response.DnssecKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExpirationDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.ExpirationDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Nameservers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Nameserver, NameserverUnmarshaller>(NameserverUnmarshaller.Instance);
                    response.Nameservers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegistrantContact", targetDepth))
                {
                    var unmarshaller = ContactDetailUnmarshaller.Instance;
                    response.RegistrantContact = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegistrantPrivacy", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.RegistrantPrivacy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegistrarName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RegistrarName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegistrarUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RegistrarUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegistryDomainId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RegistryDomainId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Reseller", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Reseller = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatusList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.StatusList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TechContact", targetDepth))
                {
                    var unmarshaller = ContactDetailUnmarshaller.Instance;
                    response.TechContact = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TechPrivacy", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.TechPrivacy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdatedDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.UpdatedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WhoIsServer", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.WhoIsServer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInput"))
                {
                    return InvalidInputExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedTLD"))
                {
                    return UnsupportedTLDExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonRoute53DomainsException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetDomainDetailResponseUnmarshaller _instance = new GetDomainDetailResponseUnmarshaller();        

        internal static GetDomainDetailResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDomainDetailResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}