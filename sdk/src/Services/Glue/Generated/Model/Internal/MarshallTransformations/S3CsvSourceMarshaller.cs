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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3CsvSource Marshaller
    /// </summary>
    public class S3CsvSourceMarshaller : IRequestMarshaller<S3CsvSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3CsvSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalOptions())
            {
                context.Writer.WritePropertyName("AdditionalOptions");
                context.Writer.WriteObjectStart();

                var marshaller = S3DirectSourceAdditionalOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.AdditionalOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCompressionType())
            {
                context.Writer.WritePropertyName("CompressionType");
                context.Writer.Write(requestObject.CompressionType);
            }

            if(requestObject.IsSetEscaper())
            {
                context.Writer.WritePropertyName("Escaper");
                context.Writer.Write(requestObject.Escaper);
            }

            if(requestObject.IsSetExclusions())
            {
                context.Writer.WritePropertyName("Exclusions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExclusionsListValue in requestObject.Exclusions)
                {
                        context.Writer.Write(requestObjectExclusionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetGroupFiles())
            {
                context.Writer.WritePropertyName("GroupFiles");
                context.Writer.Write(requestObject.GroupFiles);
            }

            if(requestObject.IsSetGroupSize())
            {
                context.Writer.WritePropertyName("GroupSize");
                context.Writer.Write(requestObject.GroupSize);
            }

            if(requestObject.IsSetMaxBand())
            {
                context.Writer.WritePropertyName("MaxBand");
                context.Writer.Write(requestObject.MaxBand);
            }

            if(requestObject.IsSetMaxFilesInBand())
            {
                context.Writer.WritePropertyName("MaxFilesInBand");
                context.Writer.Write(requestObject.MaxFilesInBand);
            }

            if(requestObject.IsSetMultiline())
            {
                context.Writer.WritePropertyName("Multiline");
                context.Writer.Write(requestObject.Multiline);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOptimizePerformance())
            {
                context.Writer.WritePropertyName("OptimizePerformance");
                context.Writer.Write(requestObject.OptimizePerformance);
            }

            if(requestObject.IsSetOutputSchemas())
            {
                context.Writer.WritePropertyName("OutputSchemas");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputSchemasListValue in requestObject.OutputSchemas)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = GlueSchemaMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputSchemasListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPaths())
            {
                context.Writer.WritePropertyName("Paths");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPathsListValue in requestObject.Paths)
                {
                        context.Writer.Write(requestObjectPathsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetQuoteChar())
            {
                context.Writer.WritePropertyName("QuoteChar");
                context.Writer.Write(requestObject.QuoteChar);
            }

            if(requestObject.IsSetRecurse())
            {
                context.Writer.WritePropertyName("Recurse");
                context.Writer.Write(requestObject.Recurse);
            }

            if(requestObject.IsSetSeparator())
            {
                context.Writer.WritePropertyName("Separator");
                context.Writer.Write(requestObject.Separator);
            }

            if(requestObject.IsSetSkipFirst())
            {
                context.Writer.WritePropertyName("SkipFirst");
                context.Writer.Write(requestObject.SkipFirst);
            }

            if(requestObject.IsSetWithHeader())
            {
                context.Writer.WritePropertyName("WithHeader");
                context.Writer.Write(requestObject.WithHeader);
            }

            if(requestObject.IsSetWriteHeader())
            {
                context.Writer.WritePropertyName("WriteHeader");
                context.Writer.Write(requestObject.WriteHeader);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3CsvSourceMarshaller Instance = new S3CsvSourceMarshaller();

    }
}