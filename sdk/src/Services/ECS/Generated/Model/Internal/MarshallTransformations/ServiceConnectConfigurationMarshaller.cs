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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServiceConnectConfiguration Marshaller
    /// </summary>
    public class ServiceConnectConfigurationMarshaller : IRequestMarshaller<ServiceConnectConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServiceConnectConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("logConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = LogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNamespace())
            {
                context.Writer.WritePropertyName("namespace");
                context.Writer.Write(requestObject.Namespace);
            }

            if(requestObject.IsSetServices())
            {
                context.Writer.WritePropertyName("services");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServicesListValue in requestObject.Services)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceConnectServiceMarshaller.Instance;
                    marshaller.Marshall(requestObjectServicesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServiceConnectConfigurationMarshaller Instance = new ServiceConnectConfigurationMarshaller();

    }
}