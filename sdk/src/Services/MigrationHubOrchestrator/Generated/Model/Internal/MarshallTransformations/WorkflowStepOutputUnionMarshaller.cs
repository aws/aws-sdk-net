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
#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubOrchestrator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkflowStepOutputUnion Marshaller
    /// </summary>
    public class WorkflowStepOutputUnionMarshaller : IRequestMarshaller<WorkflowStepOutputUnion, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkflowStepOutputUnion requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIntegerValue())
            {
                context.Writer.WritePropertyName("integerValue");
                context.Writer.WriteNumberValue(requestObject.IntegerValue.Value);
            }

            if(requestObject.IsSetListOfStringValue())
            {
                context.Writer.WritePropertyName("listOfStringValue");
                context.Writer.WriteStartArray();
                foreach(var requestObjectListOfStringValueListValue in requestObject.ListOfStringValue)
                {
                        context.Writer.WriteStringValue(requestObjectListOfStringValueListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("stringValue");
                context.Writer.WriteStringValue(requestObject.StringValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkflowStepOutputUnionMarshaller Instance = new WorkflowStepOutputUnionMarshaller();

    }
}