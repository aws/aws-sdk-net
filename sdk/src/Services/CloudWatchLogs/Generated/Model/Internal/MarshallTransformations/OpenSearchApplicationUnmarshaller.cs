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
    /// Response Unmarshaller for OpenSearchApplication Object
    /// </summary>  
    public class OpenSearchApplicationUnmarshaller : ICborUnmarshaller<OpenSearchApplication, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OpenSearchApplication Unmarshall(CborUnmarshallerContext context)
        {
            OpenSearchApplication unmarshalledObject = new OpenSearchApplication();
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
                    case "applicationArn":
                        {
                            context.AddPathSegment("ApplicationArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ApplicationArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "applicationEndpoint":
                        {
                            context.AddPathSegment("ApplicationEndpoint");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ApplicationEndpoint = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "applicationId":
                        {
                            context.AddPathSegment("ApplicationId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ApplicationId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = OpenSearchResourceStatusUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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


        private static OpenSearchApplicationUnmarshaller _instance = new OpenSearchApplicationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpenSearchApplicationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}