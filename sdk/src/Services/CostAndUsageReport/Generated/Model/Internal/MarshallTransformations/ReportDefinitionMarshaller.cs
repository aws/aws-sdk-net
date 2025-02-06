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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostAndUsageReport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostAndUsageReport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReportDefinition Marshaller
    /// </summary>
    public class ReportDefinitionMarshaller : IRequestMarshaller<ReportDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReportDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalArtifacts())
            {
                context.Writer.WritePropertyName("AdditionalArtifacts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalArtifactsListValue in requestObject.AdditionalArtifacts)
                {
                        context.Writer.WriteStringValue(requestObjectAdditionalArtifactsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAdditionalSchemaElements())
            {
                context.Writer.WritePropertyName("AdditionalSchemaElements");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalSchemaElementsListValue in requestObject.AdditionalSchemaElements)
                {
                        context.Writer.WriteStringValue(requestObjectAdditionalSchemaElementsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBillingViewArn())
            {
                context.Writer.WritePropertyName("BillingViewArn");
                context.Writer.WriteStringValue(requestObject.BillingViewArn);
            }

            if(requestObject.IsSetCompression())
            {
                context.Writer.WritePropertyName("Compression");
                context.Writer.WriteStringValue(requestObject.Compression);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.WriteStringValue(requestObject.Format);
            }

            if(requestObject.IsSetRefreshClosedReports())
            {
                context.Writer.WritePropertyName("RefreshClosedReports");
                context.Writer.WriteBooleanValue(requestObject.RefreshClosedReports.Value);
            }

            if(requestObject.IsSetReportName())
            {
                context.Writer.WritePropertyName("ReportName");
                context.Writer.WriteStringValue(requestObject.ReportName);
            }

            if(requestObject.IsSetReportStatus())
            {
                context.Writer.WritePropertyName("ReportStatus");
                context.Writer.WriteStartObject();

                var marshaller = ReportStatusMarshaller.Instance;
                marshaller.Marshall(requestObject.ReportStatus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReportVersioning())
            {
                context.Writer.WritePropertyName("ReportVersioning");
                context.Writer.WriteStringValue(requestObject.ReportVersioning);
            }

            if(requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.WriteStringValue(requestObject.S3Bucket);
            }

            if(requestObject.IsSetS3Prefix())
            {
                context.Writer.WritePropertyName("S3Prefix");
                context.Writer.WriteStringValue(requestObject.S3Prefix);
            }

            if(requestObject.IsSetS3Region())
            {
                context.Writer.WritePropertyName("S3Region");
                context.Writer.WriteStringValue(requestObject.S3Region);
            }

            if(requestObject.IsSetTimeUnit())
            {
                context.Writer.WritePropertyName("TimeUnit");
                context.Writer.WriteStringValue(requestObject.TimeUnit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReportDefinitionMarshaller Instance = new ReportDefinitionMarshaller();

    }
}