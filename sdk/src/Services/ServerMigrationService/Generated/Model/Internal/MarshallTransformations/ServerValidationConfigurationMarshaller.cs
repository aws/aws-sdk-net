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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServerValidationConfiguration Marshaller
    /// </summary>       
    public class ServerValidationConfigurationMarshaller : IRequestMarshaller<ServerValidationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServerValidationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetServer())
            {
                context.Writer.WritePropertyName("server");
                context.Writer.WriteObjectStart();

                var marshaller = ServerMarshaller.Instance;
                marshaller.Marshall(requestObject.Server, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServerValidationStrategy())
            {
                context.Writer.WritePropertyName("serverValidationStrategy");
                context.Writer.Write(requestObject.ServerValidationStrategy);
            }

            if(requestObject.IsSetUserDataValidationParameters())
            {
                context.Writer.WritePropertyName("userDataValidationParameters");
                context.Writer.WriteObjectStart();

                var marshaller = UserDataValidationParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.UserDataValidationParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetValidationId())
            {
                context.Writer.WritePropertyName("validationId");
                context.Writer.Write(requestObject.ValidationId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ServerValidationConfigurationMarshaller Instance = new ServerValidationConfigurationMarshaller();

    }
}