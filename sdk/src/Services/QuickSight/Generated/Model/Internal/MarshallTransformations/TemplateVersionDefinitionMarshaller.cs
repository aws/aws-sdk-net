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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAnalysisDefaults())
            {
                context.Writer.WritePropertyName("AnalysisDefaults");
                context.Writer.WriteObjectStart();

                var marshaller = AnalysisDefaultsMarshaller.Instance;
                marshaller.Marshall(requestObject.AnalysisDefaults, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCalculatedFields())
            {
                context.Writer.WritePropertyName("CalculatedFields");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCalculatedFieldsListValue in requestObject.CalculatedFields)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CalculatedFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectCalculatedFieldsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetColumnConfigurations())
            {
                context.Writer.WritePropertyName("ColumnConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectColumnConfigurationsListValue in requestObject.ColumnConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ColumnConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectColumnConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataSetConfigurations())
            {
                context.Writer.WritePropertyName("DataSetConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataSetConfigurationsListValue in requestObject.DataSetConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSetConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSetConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFilterGroups())
            {
                context.Writer.WritePropertyName("FilterGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFilterGroupsListValue in requestObject.FilterGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FilterGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectFilterGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetParameterDeclarations())
            {
                context.Writer.WritePropertyName("ParameterDeclarations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectParameterDeclarationsListValue in requestObject.ParameterDeclarations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ParameterDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectParameterDeclarationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSheets())
            {
                context.Writer.WritePropertyName("Sheets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSheetsListValue in requestObject.Sheets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SheetDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectSheetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TemplateVersionDefinitionMarshaller Instance = new TemplateVersionDefinitionMarshaller();

    }
}