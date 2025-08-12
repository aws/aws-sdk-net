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
    /// Response Unmarshaller for IndexPolicy Object
    /// </summary>  
    public class IndexPolicyUnmarshaller : ICborUnmarshaller<IndexPolicy, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IndexPolicy Unmarshall(CborUnmarshallerContext context)
        {
            IndexPolicy unmarshalledObject = new IndexPolicy();
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
                    case "lastUpdateTime":
                        {
                            context.AddPathSegment("LastUpdateTime");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.LastUpdateTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupIdentifier":
                        {
                            context.AddPathSegment("LogGroupIdentifier");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogGroupIdentifier = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "policyDocument":
                        {
                            context.AddPathSegment("PolicyDocument");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyDocument = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "policyName":
                        {
                            context.AddPathSegment("PolicyName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "source":
                        {
                            context.AddPathSegment("Source");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Source = unmarshaller.Unmarshall(context);
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


        private static IndexPolicyUnmarshaller _instance = new IndexPolicyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IndexPolicyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}