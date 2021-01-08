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
using ThirdParty.Json.LitJson;

namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TrainingDataSchema Marshaller
    /// </summary>       
    public class TrainingDataSchemaMarshaller : IRequestMarshaller<TrainingDataSchema, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TrainingDataSchema requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetLabelSchema())
            {
                context.Writer.WritePropertyName("labelSchema");
                context.Writer.WriteObjectStart();

                var marshaller = LabelSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.LabelSchema, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetModelVariables())
            {
                context.Writer.WritePropertyName("modelVariables");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectModelVariablesListValue in requestObject.ModelVariables)
                {
                        context.Writer.Write(requestObjectModelVariablesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TrainingDataSchemaMarshaller Instance = new TrainingDataSchemaMarshaller();

    }
}