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
    /// VmServer Marshaller
    /// </summary>       
    public class VmServerMarshaller : IRequestMarshaller<VmServer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VmServer requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetVmManagerName())
            {
                context.Writer.WritePropertyName("vmManagerName");
                context.Writer.Write(requestObject.VmManagerName);
            }

            if(requestObject.IsSetVmManagerType())
            {
                context.Writer.WritePropertyName("vmManagerType");
                context.Writer.Write(requestObject.VmManagerType);
            }

            if(requestObject.IsSetVmName())
            {
                context.Writer.WritePropertyName("vmName");
                context.Writer.Write(requestObject.VmName);
            }

            if(requestObject.IsSetVmPath())
            {
                context.Writer.WritePropertyName("vmPath");
                context.Writer.Write(requestObject.VmPath);
            }

            if(requestObject.IsSetVmServerAddress())
            {
                context.Writer.WritePropertyName("vmServerAddress");
                context.Writer.WriteObjectStart();

                var marshaller = VmServerAddressMarshaller.Instance;
                marshaller.Marshall(requestObject.VmServerAddress, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static VmServerMarshaller Instance = new VmServerMarshaller();

    }
}