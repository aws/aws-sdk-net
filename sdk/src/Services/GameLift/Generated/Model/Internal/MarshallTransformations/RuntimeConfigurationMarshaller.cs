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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuntimeConfiguration Marshaller
    /// </summary>       
    public class RuntimeConfigurationMarshaller : IRequestMarshaller<RuntimeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuntimeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetGameSessionActivationTimeoutSeconds())
            {
                context.Writer.WritePropertyName("GameSessionActivationTimeoutSeconds");
                context.Writer.Write(requestObject.GameSessionActivationTimeoutSeconds);
            }

            if(requestObject.IsSetMaxConcurrentGameSessionActivations())
            {
                context.Writer.WritePropertyName("MaxConcurrentGameSessionActivations");
                context.Writer.Write(requestObject.MaxConcurrentGameSessionActivations);
            }

            if(requestObject.IsSetServerProcesses())
            {
                context.Writer.WritePropertyName("ServerProcesses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServerProcessesListValue in requestObject.ServerProcesses)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ServerProcessMarshaller.Instance;
                    marshaller.Marshall(requestObjectServerProcessesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RuntimeConfigurationMarshaller Instance = new RuntimeConfigurationMarshaller();

    }
}