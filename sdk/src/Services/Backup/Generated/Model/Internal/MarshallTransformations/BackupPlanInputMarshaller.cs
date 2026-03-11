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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BackupPlanInput Marshaller
    /// </summary>
    public class BackupPlanInputMarshaller : IRequestMarshaller<BackupPlanInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BackupPlanInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdvancedBackupSettings())
            {
                context.Writer.WritePropertyName("AdvancedBackupSettings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdvancedBackupSettingsListValue in requestObject.AdvancedBackupSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdvancedBackupSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdvancedBackupSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBackupPlanName())
            {
                context.Writer.WritePropertyName("BackupPlanName");
                context.Writer.WriteStringValue(requestObject.BackupPlanName);
            }

            if(requestObject.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRulesListValue in requestObject.Rules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BackupRuleInputMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanSettings())
            {
                context.Writer.WritePropertyName("ScanSettings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanSettingsListValue in requestObject.ScanSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ScanSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BackupPlanInputMarshaller Instance = new BackupPlanInputMarshaller();

    }
}