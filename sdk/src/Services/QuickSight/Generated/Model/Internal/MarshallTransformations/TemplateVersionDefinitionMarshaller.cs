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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TemplateVersionDefinition Marshaller
    /// </summary>
    public class TemplateVersionDefinitionMarshaller : IRequestMarshaller<TemplateVersionDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TemplateVersionDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnalysisDefaults())
            {
                context.Writer.WritePropertyName("AnalysisDefaults");
                context.Writer.WriteStartObject();

                var marshaller = AnalysisDefaultsMarshaller.Instance;
                marshaller.Marshall(requestObject.AnalysisDefaults, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCalculatedFields())
            {
                context.Writer.WritePropertyName("CalculatedFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCalculatedFieldsListValue in requestObject.CalculatedFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CalculatedFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectCalculatedFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetColumnConfigurations())
            {
                context.Writer.WritePropertyName("ColumnConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectColumnConfigurationsListValue in requestObject.ColumnConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ColumnConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectColumnConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDataSetConfigurations())
            {
                context.Writer.WritePropertyName("DataSetConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDataSetConfigurationsListValue in requestObject.DataSetConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSetConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSetConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFilterGroups())
            {
                context.Writer.WritePropertyName("FilterGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFilterGroupsListValue in requestObject.FilterGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FilterGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectFilterGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteStartObject();

                var marshaller = AssetOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Options, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParameterDeclarations())
            {
                context.Writer.WritePropertyName("ParameterDeclarations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectParameterDeclarationsListValue in requestObject.ParameterDeclarations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ParameterDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectParameterDeclarationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetQueryExecutionOptions())
            {
                context.Writer.WritePropertyName("QueryExecutionOptions");
                context.Writer.WriteStartObject();

                var marshaller = QueryExecutionOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.QueryExecutionOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSheets())
            {
                context.Writer.WritePropertyName("Sheets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSheetsListValue in requestObject.Sheets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SheetDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectSheetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStaticFiles())
            {
                context.Writer.WritePropertyName("StaticFiles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStaticFilesListValue in requestObject.StaticFiles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StaticFileMarshaller.Instance;
                    marshaller.Marshall(requestObjectStaticFilesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TemplateVersionDefinitionMarshaller Instance = new TemplateVersionDefinitionMarshaller();

    }
}