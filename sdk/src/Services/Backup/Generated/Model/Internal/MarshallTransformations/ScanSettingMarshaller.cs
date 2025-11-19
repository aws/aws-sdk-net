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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScanSetting Marshaller
    /// </summary>
    public class ScanSettingMarshaller : IRequestMarshaller<ScanSetting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScanSetting requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMalwareScanner())
            {
                context.Writer.WritePropertyName("MalwareScanner");
                context.Writer.Write(requestObject.MalwareScanner);
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("ResourceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.Write(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScannerRoleArn())
            {
                context.Writer.WritePropertyName("ScannerRoleArn");
                context.Writer.Write(requestObject.ScannerRoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScanSettingMarshaller Instance = new ScanSettingMarshaller();

    }
}