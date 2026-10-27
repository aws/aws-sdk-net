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

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Problem Object
    /// </summary>
    public partial class ProblemUnmarshaller : ICborUnmarshaller<Problem, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Problem Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Problem();
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
                    case "AccountId":
                        context.AddPathSegment("AccountId");
                        unmarshalledObject.AccountId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AffectedResource":
                        context.AddPathSegment("AffectedResource");
                        unmarshalledObject.AffectedResource = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Feedback":
                        context.AddPathSegment("Feedback");
                        unmarshalledObject.Feedback = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Insights":
                        context.AddPathSegment("Insights");
                        unmarshalledObject.Insights = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastRecurrenceTime":
                        context.AddPathSegment("LastRecurrenceTime");
                        unmarshalledObject.LastRecurrenceTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RecurringCount":
                        context.AddPathSegment("RecurringCount");
                        unmarshalledObject.RecurringCount = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResolutionMethod":
                        context.AddPathSegment("ResolutionMethod");
                        unmarshalledObject.ResolutionMethod = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceGroupName":
                        context.AddPathSegment("ResourceGroupName");
                        unmarshalledObject.ResourceGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SeverityLevel":
                        context.AddPathSegment("SeverityLevel");
                        unmarshalledObject.SeverityLevel = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShortName":
                        context.AddPathSegment("ShortName");
                        unmarshalledObject.ShortName = CborStringUnmarshaller.Instance.Unmarshall(context);
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

                    case "Title":
                        context.AddPathSegment("Title");
                        unmarshalledObject.Title = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Visibility":
                        context.AddPathSegment("Visibility");
                        unmarshalledObject.Visibility = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ProblemUnmarshaller _instance = new ProblemUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ProblemUnmarshaller Instance => _instance;
    }
}
