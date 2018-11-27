/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Server Marshaller
    /// </summary>       
    public class ServerMarshaller : IRequestMarshaller<Server, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Server requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetReplicationJobId())
            {
                context.Writer.WritePropertyName("replicationJobId");
                context.Writer.Write(requestObject.ReplicationJobId);
            }

            if(requestObject.IsSetReplicationJobTerminated())
            {
                context.Writer.WritePropertyName("replicationJobTerminated");
                context.Writer.Write(requestObject.ReplicationJobTerminated);
            }

            if(requestObject.IsSetServerId())
            {
                context.Writer.WritePropertyName("serverId");
                context.Writer.Write(requestObject.ServerId);
            }

            if(requestObject.IsSetServerType())
            {
                context.Writer.WritePropertyName("serverType");
                context.Writer.Write(requestObject.ServerType);
            }

            if(requestObject.IsSetVmServer())
            {
                context.Writer.WritePropertyName("vmServer");
                context.Writer.WriteObjectStart();

                var marshaller = VmServerMarshaller.Instance;
                marshaller.Marshall(requestObject.VmServer, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ServerMarshaller Instance = new ServerMarshaller();

    }
}