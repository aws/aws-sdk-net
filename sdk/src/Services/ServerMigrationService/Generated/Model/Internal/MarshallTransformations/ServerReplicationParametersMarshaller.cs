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
    /// ServerReplicationParameters Marshaller
    /// </summary>       
    public class ServerReplicationParametersMarshaller : IRequestMarshaller<ServerReplicationParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServerReplicationParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("encrypted");
                context.Writer.Write(requestObject.Encrypted);
            }

            if(requestObject.IsSetFrequency())
            {
                context.Writer.WritePropertyName("frequency");
                context.Writer.Write(requestObject.Frequency);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLicenseType())
            {
                context.Writer.WritePropertyName("licenseType");
                context.Writer.Write(requestObject.LicenseType);
            }

            if(requestObject.IsSetNumberOfRecentAmisToKeep())
            {
                context.Writer.WritePropertyName("numberOfRecentAmisToKeep");
                context.Writer.Write(requestObject.NumberOfRecentAmisToKeep);
            }

            if(requestObject.IsSetRunOnce())
            {
                context.Writer.WritePropertyName("runOnce");
                context.Writer.Write(requestObject.RunOnce);
            }

            if(requestObject.IsSetSeedTime())
            {
                context.Writer.WritePropertyName("seedTime");
                context.Writer.Write(requestObject.SeedTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ServerReplicationParametersMarshaller Instance = new ServerReplicationParametersMarshaller();

    }
}