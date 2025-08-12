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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SubscriptionFilter Object
    /// </summary>  
    public class SubscriptionFilterUnmarshaller : ICborUnmarshaller<SubscriptionFilter, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SubscriptionFilter Unmarshall(CborUnmarshallerContext context)
        {
            SubscriptionFilter unmarshalledObject = new SubscriptionFilter();
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
                    case "applyOnTransformedLogs":
                        {
                            context.AddPathSegment("ApplyOnTransformedLogs");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.ApplyOnTransformedLogs = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "creationTime":
                        {
                            context.AddPathSegment("CreationTime");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "destinationArn":
                        {
                            context.AddPathSegment("DestinationArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DestinationArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "distribution":
                        {
                            context.AddPathSegment("Distribution");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Distribution = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "filterName":
                        {
                            context.AddPathSegment("FilterName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FilterName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "filterPattern":
                        {
                            context.AddPathSegment("FilterPattern");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FilterPattern = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupName":
                        {
                            context.AddPathSegment("LogGroupName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "roleArn":
                        {
                            context.AddPathSegment("RoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
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


        private static SubscriptionFilterUnmarshaller _instance = new SubscriptionFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubscriptionFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}