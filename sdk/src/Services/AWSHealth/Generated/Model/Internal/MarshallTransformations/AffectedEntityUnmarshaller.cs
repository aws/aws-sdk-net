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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AffectedEntity Object
    /// </summary>  
    public class AffectedEntityUnmarshaller : ICborUnmarshaller<AffectedEntity, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AffectedEntity Unmarshall(CborUnmarshallerContext context)
        {
            AffectedEntity unmarshalledObject = new AffectedEntity();
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
                    case "awsAccountId":
                        {
                            context.AddPathSegment("AwsAccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AwsAccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "entityArn":
                        {
                            context.AddPathSegment("EntityArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EntityArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "entityMetadata":
                        {
                            context.AddPathSegment("EntityMetadata");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.EntityMetadata = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "entityUrl":
                        {
                            context.AddPathSegment("EntityUrl");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EntityUrl = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "entityValue":
                        {
                            context.AddPathSegment("EntityValue");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EntityValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventArn":
                        {
                            context.AddPathSegment("EventArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastUpdatedTime":
                        {
                            context.AddPathSegment("LastUpdatedTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "statusCode":
                        {
                            context.AddPathSegment("StatusCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatusCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "tags":
                        {
                            context.AddPathSegment("Tags");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
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


        private static AffectedEntityUnmarshaller _instance = new AffectedEntityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AffectedEntityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}