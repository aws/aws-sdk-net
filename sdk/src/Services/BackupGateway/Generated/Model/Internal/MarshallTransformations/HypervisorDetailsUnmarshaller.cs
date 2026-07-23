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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.BackupGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HypervisorDetails Object
    /// </summary>  
    public class HypervisorDetailsUnmarshaller : ICborUnmarshaller<HypervisorDetails, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public HypervisorDetails Unmarshall(CborUnmarshallerContext context)
        {
            HypervisorDetails unmarshalledObject = new HypervisorDetails();
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
                    case "Host":
                        {
                            context.AddPathSegment("Host");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Host = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HypervisorArn":
                        {
                            context.AddPathSegment("HypervisorArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HypervisorArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "KmsKeyArn":
                        {
                            context.AddPathSegment("KmsKeyArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.KmsKeyArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastSuccessfulMetadataSyncTime":
                        {
                            context.AddPathSegment("LastSuccessfulMetadataSyncTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastSuccessfulMetadataSyncTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LatestMetadataSyncStatus":
                        {
                            context.AddPathSegment("LatestMetadataSyncStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LatestMetadataSyncStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LatestMetadataSyncStatusMessage":
                        {
                            context.AddPathSegment("LatestMetadataSyncStatusMessage");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LatestMetadataSyncStatusMessage = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LogGroupArn":
                        {
                            context.AddPathSegment("LogGroupArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogGroupArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "State":
                        {
                            context.AddPathSegment("State");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.State = unmarshaller.Unmarshall(context);
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


        private static HypervisorDetailsUnmarshaller _instance = new HypervisorDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HypervisorDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}