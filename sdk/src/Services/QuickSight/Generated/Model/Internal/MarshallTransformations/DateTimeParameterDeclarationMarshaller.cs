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
    /// DateTimeParameterDeclaration Marshaller
    /// </summary>
    public class DateTimeParameterDeclarationMarshaller : IRequestMarshaller<DateTimeParameterDeclaration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DateTimeParameterDeclaration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultValues())
            {
                context.Writer.WritePropertyName("DefaultValues");
                context.Writer.WriteStartObject();

                var marshaller = DateTimeDefaultValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultValues, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMappedDataSetParameters())
            {
                context.Writer.WritePropertyName("MappedDataSetParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMappedDataSetParametersListValue in requestObject.MappedDataSetParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MappedDataSetParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMappedDataSetParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetTimeGranularity())
            {
                context.Writer.WritePropertyName("TimeGranularity");
                context.Writer.WriteStringValue(requestObject.TimeGranularity);
            }

            if(requestObject.IsSetValueWhenUnset())
            {
                context.Writer.WritePropertyName("ValueWhenUnset");
                context.Writer.WriteStartObject();

                var marshaller = DateTimeValueWhenUnsetConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueWhenUnset, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DateTimeParameterDeclarationMarshaller Instance = new DateTimeParameterDeclarationMarshaller();

    }
}