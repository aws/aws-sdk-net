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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateOTelEnrichment operation
    /// </summary>  
    public class UpdateOTelEnrichmentResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            UpdateOTelEnrichmentResponse response = new UpdateOTelEnrichmentResponse();
            var reader = context.Reader;
            context.AddPathSegment("UpdateOTelEnrichment");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "CreatedAt":
                        {
                            context.AddPathSegment("CreatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.CreatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ExcludeFilters":
                        {
                            context.AddPathSegment("ExcludeFilters");
                            var unmarshaller = new CborListUnmarshaller<OTelEnrichmentMetricSelector, OTelEnrichmentMetricSelectorUnmarshaller>(OTelEnrichmentMetricSelectorUnmarshaller.Instance);
                            response.ExcludeFilters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IncludeFilters":
                        {
                            context.AddPathSegment("IncludeFilters");
                            var unmarshaller = new CborListUnmarshaller<OTelEnrichmentMetricSelector, OTelEnrichmentMetricSelectorUnmarshaller>(OTelEnrichmentMetricSelectorUnmarshaller.Instance);
                            response.IncludeFilters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "UpdatedAt":
                        {
                            context.AddPathSegment("UpdatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.UpdatedAt = unmarshaller.Unmarshall(context);
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
            using (var contextCopy = new CborUnmarshallerContext(streamCopy, true, context.ResponseData))
            {
                var errorTypeName = errorResponse.Code;
                Amazon.Runtime.Internal.Transform.AwsQueryCompatibleErrorHandler.ApplyQueryErrorHeader(errorResponse, context.ResponseData);
                if (errorTypeName != null && errorTypeName.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorTypeName != null && errorTypeName.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudWatchException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static UpdateOTelEnrichmentResponseUnmarshaller _instance = new UpdateOTelEnrichmentResponseUnmarshaller();        

        internal static UpdateOTelEnrichmentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOTelEnrichmentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}