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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Space Object
    /// </summary>  
    public class SpaceUnmarshaller : ICborUnmarshaller<Space, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Space Unmarshall(CborUnmarshallerContext context)
        {
            Space unmarshalledObject = new Space();
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
                    case "agentCoreEvaluationRoleArn":
                        {
                            context.AddPathSegment("AgentCoreEvaluationRoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AgentCoreEvaluationRoleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "createdAt":
                        {
                            context.AddPathSegment("CreatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "dataAccessRoleArn":
                        {
                            context.AddPathSegment("DataAccessRoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DataAccessRoleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "domainArn":
                        {
                            context.AddPathSegment("DomainArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DomainArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "encryptionConfiguration":
                        {
                            context.AddPathSegment("EncryptionConfiguration");
                            var unmarshaller = EncryptionConfigurationUnmarshaller.Instance;
                            unmarshalledObject.EncryptionConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ownerAccountId":
                        {
                            context.AddPathSegment("OwnerAccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.OwnerAccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "region":
                        {
                            context.AddPathSegment("Region");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "spaceArn":
                        {
                            context.AddPathSegment("SpaceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SpaceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "spaceId":
                        {
                            context.AddPathSegment("SpaceId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SpaceId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "statusReason":
                        {
                            context.AddPathSegment("StatusReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "updatedAt":
                        {
                            context.AddPathSegment("UpdatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
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


        private static SpaceUnmarshaller _instance = new SpaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SpaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}