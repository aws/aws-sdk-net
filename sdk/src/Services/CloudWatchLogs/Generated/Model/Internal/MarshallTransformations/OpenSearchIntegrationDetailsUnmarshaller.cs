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
    /// Response Unmarshaller for OpenSearchIntegrationDetails Object
    /// </summary>  
    public class OpenSearchIntegrationDetailsUnmarshaller : ICborUnmarshaller<OpenSearchIntegrationDetails, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OpenSearchIntegrationDetails Unmarshall(CborUnmarshallerContext context)
        {
            OpenSearchIntegrationDetails unmarshalledObject = new OpenSearchIntegrationDetails();
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
                    case "accessPolicy":
                        {
                            context.AddPathSegment("AccessPolicy");
                            var unmarshaller = OpenSearchDataAccessPolicyUnmarshaller.Instance;
                            unmarshalledObject.AccessPolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "application":
                        {
                            context.AddPathSegment("Application");
                            var unmarshaller = OpenSearchApplicationUnmarshaller.Instance;
                            unmarshalledObject.Application = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "collection":
                        {
                            context.AddPathSegment("Collection");
                            var unmarshaller = OpenSearchCollectionUnmarshaller.Instance;
                            unmarshalledObject.Collection = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "dataSource":
                        {
                            context.AddPathSegment("DataSource");
                            var unmarshaller = OpenSearchDataSourceUnmarshaller.Instance;
                            unmarshalledObject.DataSource = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "encryptionPolicy":
                        {
                            context.AddPathSegment("EncryptionPolicy");
                            var unmarshaller = OpenSearchEncryptionPolicyUnmarshaller.Instance;
                            unmarshalledObject.EncryptionPolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lifecyclePolicy":
                        {
                            context.AddPathSegment("LifecyclePolicy");
                            var unmarshaller = OpenSearchLifecyclePolicyUnmarshaller.Instance;
                            unmarshalledObject.LifecyclePolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "networkPolicy":
                        {
                            context.AddPathSegment("NetworkPolicy");
                            var unmarshaller = OpenSearchNetworkPolicyUnmarshaller.Instance;
                            unmarshalledObject.NetworkPolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "workspace":
                        {
                            context.AddPathSegment("Workspace");
                            var unmarshaller = OpenSearchWorkspaceUnmarshaller.Instance;
                            unmarshalledObject.Workspace = unmarshaller.Unmarshall(context);
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


        private static OpenSearchIntegrationDetailsUnmarshaller _instance = new OpenSearchIntegrationDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpenSearchIntegrationDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}