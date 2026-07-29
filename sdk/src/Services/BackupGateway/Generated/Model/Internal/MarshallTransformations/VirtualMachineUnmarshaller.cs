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
    /// Response Unmarshaller for VirtualMachine Object
    /// </summary>  
    public class VirtualMachineUnmarshaller : ICborUnmarshaller<VirtualMachine, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public VirtualMachine Unmarshall(CborUnmarshallerContext context)
        {
            VirtualMachine unmarshalledObject = new VirtualMachine();
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
                    case "HostName":
                        {
                            context.AddPathSegment("HostName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HostName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HypervisorId":
                        {
                            context.AddPathSegment("HypervisorId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HypervisorId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastBackupDate":
                        {
                            context.AddPathSegment("LastBackupDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastBackupDate = unmarshaller.Unmarshall(context);
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
                    case "Path":
                        {
                            context.AddPathSegment("Path");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Path = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResourceArn":
                        {
                            context.AddPathSegment("ResourceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
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


        private static VirtualMachineUnmarshaller _instance = new VirtualMachineUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VirtualMachineUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}