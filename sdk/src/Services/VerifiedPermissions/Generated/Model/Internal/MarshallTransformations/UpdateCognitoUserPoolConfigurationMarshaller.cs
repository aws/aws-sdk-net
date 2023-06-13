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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VerifiedPermissions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCognitoUserPoolConfiguration Marshaller
    /// </summary>
    public class UpdateCognitoUserPoolConfigurationMarshaller : IRequestMarshaller<UpdateCognitoUserPoolConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateCognitoUserPoolConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetClientIds())
            {
                context.Writer.WritePropertyName("clientIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectClientIdsListValue in requestObject.ClientIds)
                {
                        context.Writer.Write(requestObjectClientIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUserPoolArn())
            {
                context.Writer.WritePropertyName("userPoolArn");
                context.Writer.Write(requestObject.UserPoolArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateCognitoUserPoolConfigurationMarshaller Instance = new UpdateCognitoUserPoolConfigurationMarshaller();

    }
}