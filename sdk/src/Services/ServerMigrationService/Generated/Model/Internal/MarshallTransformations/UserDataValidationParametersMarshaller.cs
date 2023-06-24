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
    /// UserDataValidationParameters Marshaller
    /// </summary>
    public class UserDataValidationParametersMarshaller : IRequestMarshaller<UserDataValidationParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UserDataValidationParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetScriptType())
            {
                context.Writer.WritePropertyName("scriptType");
                context.Writer.Write(requestObject.ScriptType);
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteObjectStart();

                var marshaller = SourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Source, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UserDataValidationParametersMarshaller Instance = new UserDataValidationParametersMarshaller();

    }
}