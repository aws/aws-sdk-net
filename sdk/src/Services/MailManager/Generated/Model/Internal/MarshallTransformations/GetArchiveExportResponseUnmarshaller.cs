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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetArchiveExport operation
    /// </summary>  
    public class GetArchiveExportResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            GetArchiveExportResponse response = new GetArchiveExportResponse();
            var reader = context.Reader;
            context.AddPathSegment("GetArchiveExport");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "ArchiveId":
                        {
                            context.AddPathSegment("ArchiveId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.ArchiveId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ExportDestinationConfiguration":
                        {
                            context.AddPathSegment("ExportDestinationConfiguration");
                            var unmarshaller = ExportDestinationConfigurationUnmarshaller.Instance;
                            response.ExportDestinationConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Filters":
                        {
                            context.AddPathSegment("Filters");
                            var unmarshaller = ArchiveFiltersUnmarshaller.Instance;
                            response.Filters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FromTimestamp":
                        {
                            context.AddPathSegment("FromTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.FromTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MaxResults":
                        {
                            context.AddPathSegment("MaxResults");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            response.MaxResults = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = ExportStatusUnmarshaller.Instance;
                            response.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ToTimestamp":
                        {
                            context.AddPathSegment("ToTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.ToTimestamp = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonMailManagerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetArchiveExportResponseUnmarshaller _instance = new GetArchiveExportResponseUnmarshaller();        

        internal static GetArchiveExportResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetArchiveExportResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}