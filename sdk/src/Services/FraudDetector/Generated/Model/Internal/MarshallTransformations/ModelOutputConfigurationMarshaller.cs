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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModelOutputConfiguration Marshaller
    /// </summary>
    public class ModelOutputConfigurationMarshaller : IRequestMarshaller<ModelOutputConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ModelOutputConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCsvIndexToVariableMap())
            {
                context.Writer.WritePropertyName("csvIndexToVariableMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCsvIndexToVariableMapKvp in requestObject.CsvIndexToVariableMap)
                {
                    context.Writer.WritePropertyName(requestObjectCsvIndexToVariableMapKvp.Key);
                    var requestObjectCsvIndexToVariableMapValue = requestObjectCsvIndexToVariableMapKvp.Value;

                        context.Writer.WriteStringValue(requestObjectCsvIndexToVariableMapValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("format");
                context.Writer.WriteStringValue(requestObject.Format);
            }

            if(requestObject.IsSetJsonKeyToVariableMap())
            {
                context.Writer.WritePropertyName("jsonKeyToVariableMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectJsonKeyToVariableMapKvp in requestObject.JsonKeyToVariableMap)
                {
                    context.Writer.WritePropertyName(requestObjectJsonKeyToVariableMapKvp.Key);
                    var requestObjectJsonKeyToVariableMapValue = requestObjectJsonKeyToVariableMapKvp.Value;

                        context.Writer.WriteStringValue(requestObjectJsonKeyToVariableMapValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ModelOutputConfigurationMarshaller Instance = new ModelOutputConfigurationMarshaller();

    }
}