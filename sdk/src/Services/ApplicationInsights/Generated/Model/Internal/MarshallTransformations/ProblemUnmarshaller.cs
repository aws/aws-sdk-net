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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Problem Object
    /// </summary>  
    public class ProblemUnmarshaller : ICborUnmarshaller<Problem, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Problem Unmarshall(CborUnmarshallerContext context)
        {
            Problem unmarshalledObject = new Problem();
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
                    case "AccountId":
                        {
                            context.AddPathSegment("AccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AffectedResource":
                        {
                            context.AddPathSegment("AffectedResource");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AffectedResource = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EndTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Feedback":
                        {
                            context.AddPathSegment("Feedback");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.Feedback = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Id":
                        {
                            context.AddPathSegment("Id");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Insights":
                        {
                            context.AddPathSegment("Insights");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Insights = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastRecurrenceTime":
                        {
                            context.AddPathSegment("LastRecurrenceTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastRecurrenceTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RecurringCount":
                        {
                            context.AddPathSegment("RecurringCount");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.RecurringCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResolutionMethod":
                        {
                            context.AddPathSegment("ResolutionMethod");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResolutionMethod = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResourceGroupName":
                        {
                            context.AddPathSegment("ResourceGroupName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceGroupName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SeverityLevel":
                        {
                            context.AddPathSegment("SeverityLevel");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SeverityLevel = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ShortName":
                        {
                            context.AddPathSegment("ShortName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ShortName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StartTime":
                        {
                            context.AddPathSegment("StartTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
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
                    case "Title":
                        {
                            context.AddPathSegment("Title");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Visibility":
                        {
                            context.AddPathSegment("Visibility");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Visibility = unmarshaller.Unmarshall(context);
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


        private static ProblemUnmarshaller _instance = new ProblemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProblemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}