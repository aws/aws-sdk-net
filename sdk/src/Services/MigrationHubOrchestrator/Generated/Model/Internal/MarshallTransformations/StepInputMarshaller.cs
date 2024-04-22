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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubOrchestrator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubOrchestrator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StepInput Marshaller
    /// </summary>
    public class StepInputMarshaller : IRequestMarshaller<StepInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StepInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIntegerValue())
            {
                context.Writer.WritePropertyName("integerValue");
                context.Writer.Write(requestObject.IntegerValue);
            }

            if(requestObject.IsSetListOfStringsValue())
            {
                context.Writer.WritePropertyName("listOfStringsValue");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectListOfStringsValueListValue in requestObject.ListOfStringsValue)
                {
                        context.Writer.Write(requestObjectListOfStringsValueListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMapOfStringValue())
            {
                context.Writer.WritePropertyName("mapOfStringValue");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectMapOfStringValueKvp in requestObject.MapOfStringValue)
                {
                    context.Writer.WritePropertyName(requestObjectMapOfStringValueKvp.Key);
                    var requestObjectMapOfStringValueValue = requestObjectMapOfStringValueKvp.Value;

                        context.Writer.Write(requestObjectMapOfStringValueValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("stringValue");
                context.Writer.Write(requestObject.StringValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StepInputMarshaller Instance = new StepInputMarshaller();

    }
}
#pragma warning restore CS0612,CS0618