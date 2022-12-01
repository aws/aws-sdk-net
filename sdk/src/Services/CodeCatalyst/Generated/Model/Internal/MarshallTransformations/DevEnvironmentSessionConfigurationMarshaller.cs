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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCatalyst.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCatalyst.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DevEnvironmentSessionConfiguration Marshaller
    /// </summary>
    public class DevEnvironmentSessionConfigurationMarshaller : IRequestMarshaller<DevEnvironmentSessionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DevEnvironmentSessionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetExecuteCommandSessionConfiguration())
            {
                context.Writer.WritePropertyName("executeCommandSessionConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ExecuteCommandSessionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecuteCommandSessionConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSessionType())
            {
                context.Writer.WritePropertyName("sessionType");
                context.Writer.Write(requestObject.SessionType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DevEnvironmentSessionConfigurationMarshaller Instance = new DevEnvironmentSessionConfigurationMarshaller();

    }
}