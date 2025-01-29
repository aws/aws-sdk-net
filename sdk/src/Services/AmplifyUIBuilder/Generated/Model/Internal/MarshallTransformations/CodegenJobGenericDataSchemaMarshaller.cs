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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CodegenJobGenericDataSchema Marshaller
    /// </summary>
    public class CodegenJobGenericDataSchemaMarshaller : IRequestMarshaller<CodegenJobGenericDataSchema, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodegenJobGenericDataSchema requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataSourceType())
            {
                context.Writer.WritePropertyName("dataSourceType");
                context.Writer.WriteStringValue(requestObject.DataSourceType);
            }

            if(requestObject.IsSetEnums())
            {
                context.Writer.WritePropertyName("enums");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEnumsKvp in requestObject.Enums)
                {
                    context.Writer.WritePropertyName(requestObjectEnumsKvp.Key);
                    var requestObjectEnumsValue = requestObjectEnumsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = CodegenGenericDataEnumMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnumsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModels())
            {
                context.Writer.WritePropertyName("models");
                context.Writer.WriteStartObject();
                foreach (var requestObjectModelsKvp in requestObject.Models)
                {
                    context.Writer.WritePropertyName(requestObjectModelsKvp.Key);
                    var requestObjectModelsValue = requestObjectModelsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = CodegenGenericDataModelMarshaller.Instance;
                    marshaller.Marshall(requestObjectModelsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNonModels())
            {
                context.Writer.WritePropertyName("nonModels");
                context.Writer.WriteStartObject();
                foreach (var requestObjectNonModelsKvp in requestObject.NonModels)
                {
                    context.Writer.WritePropertyName(requestObjectNonModelsKvp.Key);
                    var requestObjectNonModelsValue = requestObjectNonModelsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = CodegenGenericDataNonModelMarshaller.Instance;
                    marshaller.Marshall(requestObjectNonModelsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodegenJobGenericDataSchemaMarshaller Instance = new CodegenJobGenericDataSchemaMarshaller();

    }
}