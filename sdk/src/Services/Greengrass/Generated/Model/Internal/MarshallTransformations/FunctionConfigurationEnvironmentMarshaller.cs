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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FunctionConfigurationEnvironment Marshaller
    /// </summary>       
    public class FunctionConfigurationEnvironmentMarshaller : IRequestMarshaller<FunctionConfigurationEnvironment, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FunctionConfigurationEnvironment requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessSysfs())
            {
                context.Writer.WritePropertyName("AccessSysfs");
                context.Writer.Write(requestObject.AccessSysfs);
            }

            if(requestObject.IsSetExecution())
            {
                context.Writer.WritePropertyName("Execution");
                context.Writer.WriteObjectStart();

                var marshaller = FunctionExecutionConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.Execution, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResourceAccessPolicies())
            {
                context.Writer.WritePropertyName("ResourceAccessPolicies");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAccessPoliciesListValue in requestObject.ResourceAccessPolicies)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceAccessPolicyMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAccessPoliciesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVariables())
            {
                context.Writer.WritePropertyName("Variables");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectVariablesKvp in requestObject.Variables)
                {
                    context.Writer.WritePropertyName(requestObjectVariablesKvp.Key);
                    var requestObjectVariablesValue = requestObjectVariablesKvp.Value;

                        context.Writer.Write(requestObjectVariablesValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FunctionConfigurationEnvironmentMarshaller Instance = new FunctionConfigurationEnvironmentMarshaller();

    }
}