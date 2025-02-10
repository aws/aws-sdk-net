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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MaintenanceWindowTaskInvocationParameters Marshaller
    /// </summary>
    public class MaintenanceWindowTaskInvocationParametersMarshaller : IRequestMarshaller<MaintenanceWindowTaskInvocationParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MaintenanceWindowTaskInvocationParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutomation())
            {
                context.Writer.WritePropertyName("Automation");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceWindowAutomationParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.Automation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLambda())
            {
                context.Writer.WritePropertyName("Lambda");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceWindowLambdaParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.Lambda, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRunCommand())
            {
                context.Writer.WritePropertyName("RunCommand");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceWindowRunCommandParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RunCommand, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStepFunctions())
            {
                context.Writer.WritePropertyName("StepFunctions");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceWindowStepFunctionsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.StepFunctions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MaintenanceWindowTaskInvocationParametersMarshaller Instance = new MaintenanceWindowTaskInvocationParametersMarshaller();

    }
}