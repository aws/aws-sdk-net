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

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReportSetting Marshaller
    /// </summary>
    public class ReportSettingMarshaller : IRequestMarshaller<ReportSetting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReportSetting requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccounts())
            {
                context.Writer.WritePropertyName("Accounts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccountsListValue in requestObject.Accounts)
                {
                        context.Writer.Write(requestObjectAccountsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFrameworkArns())
            {
                context.Writer.WritePropertyName("FrameworkArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFrameworkArnsListValue in requestObject.FrameworkArns)
                {
                        context.Writer.Write(requestObjectFrameworkArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNumberOfFrameworks())
            {
                context.Writer.WritePropertyName("NumberOfFrameworks");
                context.Writer.Write(requestObject.NumberOfFrameworks);
            }

            if(requestObject.IsSetOrganizationUnits())
            {
                context.Writer.WritePropertyName("OrganizationUnits");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrganizationUnitsListValue in requestObject.OrganizationUnits)
                {
                        context.Writer.Write(requestObjectOrganizationUnitsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("Regions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.Write(requestObjectRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetReportTemplate())
            {
                context.Writer.WritePropertyName("ReportTemplate");
                context.Writer.Write(requestObject.ReportTemplate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReportSettingMarshaller Instance = new ReportSettingMarshaller();

    }
}