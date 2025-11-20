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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReportContext Marshaller
    /// </summary>
    public class ReportContextMarshaller : IRequestMarshaller<ReportContext, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReportContext requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLicenseAssetGroupArns())
            {
                context.Writer.WritePropertyName("licenseAssetGroupArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLicenseAssetGroupArnsListValue in requestObject.LicenseAssetGroupArns)
                {
                        context.Writer.WriteStringValue(requestObjectLicenseAssetGroupArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLicenseConfigurationArns())
            {
                context.Writer.WritePropertyName("licenseConfigurationArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLicenseConfigurationArnsListValue in requestObject.LicenseConfigurationArns)
                {
                        context.Writer.WriteStringValue(requestObjectLicenseConfigurationArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetReportEndDate())
            {
                context.Writer.WritePropertyName("reportEndDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.ReportEndDate.Value)));
            }

            if(requestObject.IsSetReportStartDate())
            {
                context.Writer.WritePropertyName("reportStartDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.ReportStartDate.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReportContextMarshaller Instance = new ReportContextMarshaller();

    }
}