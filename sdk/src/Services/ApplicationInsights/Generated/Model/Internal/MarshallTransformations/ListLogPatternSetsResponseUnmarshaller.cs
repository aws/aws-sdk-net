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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListLogPatternSets operation
    /// </summary>  
    public class ListLogPatternSetsResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            ListLogPatternSetsResponse response = new ListLogPatternSetsResponse();
            var reader = context.Reader;
            context.AddPathSegment("ListLogPatternSets");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AccountId":
                        {
                            context.AddPathSegment("AccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.AccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LogPatternSets":
                        {
                            context.AddPathSegment("LogPatternSets");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            response.LogPatternSets = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NextToken":
                        {
                            context.AddPathSegment("NextToken");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.NextToken = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResourceGroupName":
                        {
                            context.AddPathSegment("ResourceGroupName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.ResourceGroupName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonApplicationInsightsException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static ListLogPatternSetsResponseUnmarshaller _instance = new ListLogPatternSetsResponseUnmarshaller();        

        internal static ListLogPatternSetsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListLogPatternSetsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}