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
    /// TransformStep Marshaller
    /// </summary>
    public class TransformStepMarshaller : IRequestMarshaller<TransformStep, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TransformStep requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggregateStep())
            {
                context.Writer.WritePropertyName("AggregateStep");
                context.Writer.WriteStartObject();

                var marshaller = AggregateOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.AggregateStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAppendStep())
            {
                context.Writer.WritePropertyName("AppendStep");
                context.Writer.WriteStartObject();

                var marshaller = AppendOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.AppendStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCastColumnTypesStep())
            {
                context.Writer.WritePropertyName("CastColumnTypesStep");
                context.Writer.WriteStartObject();

                var marshaller = CastColumnTypesOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.CastColumnTypesStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateColumnsStep())
            {
                context.Writer.WritePropertyName("CreateColumnsStep");
                context.Writer.WriteStartObject();

                var marshaller = CreateColumnsOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateColumnsStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFiltersStep())
            {
                context.Writer.WritePropertyName("FiltersStep");
                context.Writer.WriteStartObject();

                var marshaller = FiltersOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.FiltersStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImportTableStep())
            {
                context.Writer.WritePropertyName("ImportTableStep");
                context.Writer.WriteStartObject();

                var marshaller = ImportTableOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.ImportTableStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJoinStep())
            {
                context.Writer.WritePropertyName("JoinStep");
                context.Writer.WriteStartObject();

                var marshaller = JoinOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.JoinStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPivotStep())
            {
                context.Writer.WritePropertyName("PivotStep");
                context.Writer.WriteStartObject();

                var marshaller = PivotOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.PivotStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProjectStep())
            {
                context.Writer.WritePropertyName("ProjectStep");
                context.Writer.WriteStartObject();

                var marshaller = ProjectOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProjectStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRenameColumnsStep())
            {
                context.Writer.WritePropertyName("RenameColumnsStep");
                context.Writer.WriteStartObject();

                var marshaller = RenameColumnsOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.RenameColumnsStep, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUnpivotStep())
            {
                context.Writer.WritePropertyName("UnpivotStep");
                context.Writer.WriteStartObject();

                var marshaller = UnpivotOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.UnpivotStep, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TransformStepMarshaller Instance = new TransformStepMarshaller();

    }
}