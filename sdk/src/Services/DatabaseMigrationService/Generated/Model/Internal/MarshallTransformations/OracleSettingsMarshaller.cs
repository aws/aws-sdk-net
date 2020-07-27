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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OracleSettings Marshaller
    /// </summary>       
    public class OracleSettingsMarshaller : IRequestMarshaller<OracleSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OracleSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAsmPassword())
            {
                context.Writer.WritePropertyName("AsmPassword");
                context.Writer.Write(requestObject.AsmPassword);
            }

            if(requestObject.IsSetAsmServer())
            {
                context.Writer.WritePropertyName("AsmServer");
                context.Writer.Write(requestObject.AsmServer);
            }

            if(requestObject.IsSetAsmUser())
            {
                context.Writer.WritePropertyName("AsmUser");
                context.Writer.Write(requestObject.AsmUser);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.Write(requestObject.Password);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
            }

            if(requestObject.IsSetSecurityDbEncryption())
            {
                context.Writer.WritePropertyName("SecurityDbEncryption");
                context.Writer.Write(requestObject.SecurityDbEncryption);
            }

            if(requestObject.IsSetSecurityDbEncryptionName())
            {
                context.Writer.WritePropertyName("SecurityDbEncryptionName");
                context.Writer.Write(requestObject.SecurityDbEncryptionName);
            }

            if(requestObject.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.Write(requestObject.ServerName);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.Write(requestObject.Username);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OracleSettingsMarshaller Instance = new OracleSettingsMarshaller();

    }
}