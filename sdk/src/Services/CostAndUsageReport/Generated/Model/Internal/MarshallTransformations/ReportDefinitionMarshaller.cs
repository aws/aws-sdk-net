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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAdditionalArtifacts())
            {
                context.Writer.WritePropertyName("AdditionalArtifacts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdditionalArtifactsListValue in requestObject.AdditionalArtifacts)
                {
                        context.Writer.Write(requestObjectAdditionalArtifactsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAdditionalSchemaElements())
            {
                context.Writer.WritePropertyName("AdditionalSchemaElements");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdditionalSchemaElementsListValue in requestObject.AdditionalSchemaElements)
                {
                        context.Writer.Write(requestObjectAdditionalSchemaElementsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCompression())
            {
                context.Writer.WritePropertyName("Compression");
                context.Writer.Write(requestObject.Compression);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.Write(requestObject.Format);
            }

            if(requestObject.IsSetReportName())
            {
                context.Writer.WritePropertyName("ReportName");
                context.Writer.Write(requestObject.ReportName);
            }

            if(requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.Write(requestObject.S3Bucket);
            }

            if(requestObject.IsSetS3Prefix())
            {
                context.Writer.WritePropertyName("S3Prefix");
                context.Writer.Write(requestObject.S3Prefix);
            }

            if(requestObject.IsSetS3Region())
            {
                context.Writer.WritePropertyName("S3Region");
                context.Writer.Write(requestObject.S3Region);
            }

            if(requestObject.IsSetTimeUnit())
            {
                context.Writer.WritePropertyName("TimeUnit");
                context.Writer.Write(requestObject.TimeUnit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ReportDefinitionMarshaller Instance = new ReportDefinitionMarshaller();

    }
}