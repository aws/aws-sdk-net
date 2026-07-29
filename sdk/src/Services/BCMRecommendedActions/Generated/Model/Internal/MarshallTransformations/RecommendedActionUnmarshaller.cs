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
 * Do not modify this file. This file is generated from the bcm-recommended-actions-2024-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMRecommendedActions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMRecommendedActions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecommendedAction Object
    /// </summary>  
    public class RecommendedActionUnmarshaller : ICborUnmarshaller<RecommendedAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RecommendedAction Unmarshall(CborUnmarshallerContext context)
        {
            RecommendedAction unmarshalledObject = new RecommendedAction();
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
                    case "accountId":
                        {
                            context.AddPathSegment("AccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "context":
                        {
                            context.AddPathSegment("Context");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.Context = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "feature":
                        {
                            context.AddPathSegment("Feature");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Feature = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "id":
                        {
                            context.AddPathSegment("Id");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastUpdatedTimeStamp":
                        {
                            context.AddPathSegment("LastUpdatedTimeStamp");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LastUpdatedTimeStamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "nextSteps":
                        {
                            context.AddPathSegment("NextSteps");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.NextSteps = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "severity":
                        {
                            context.AddPathSegment("Severity");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "type":
                        {
                            context.AddPathSegment("Type");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Type = unmarshaller.Unmarshall(context);
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


        private static RecommendedActionUnmarshaller _instance = new RecommendedActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecommendedActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}