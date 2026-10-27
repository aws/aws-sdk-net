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

using Amazon.PI.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnalysisReport Object
    /// </summary>
    public partial class AnalysisReportUnmarshaller : ICborUnmarshaller<AnalysisReport, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AnalysisReport Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AnalysisReport();
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
                    case "AnalysisReportId":
                        context.AddPathSegment("AnalysisReportId");
                        unmarshalledObject.AnalysisReportId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreateTime":
                        context.AddPathSegment("CreateTime");
                        unmarshalledObject.CreateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Identifier":
                        context.AddPathSegment("Identifier");
                        unmarshalledObject.Identifier = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Insights":
                        context.AddPathSegment("Insights");
                        unmarshalledObject.Insights = new CborListUnmarshaller<Insight, InsightUnmarshaller>(InsightUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ServiceType":
                        context.AddPathSegment("ServiceType");
                        unmarshalledObject.ServiceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StartTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static AnalysisReportUnmarshaller _instance = new AnalysisReportUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AnalysisReportUnmarshaller Instance => _instance;
    }
}
