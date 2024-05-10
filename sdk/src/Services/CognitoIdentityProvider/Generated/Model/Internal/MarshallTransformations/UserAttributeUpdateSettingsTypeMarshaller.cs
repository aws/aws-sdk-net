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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UserAttributeUpdateSettingsType Marshaller
    /// </summary>
    public class UserAttributeUpdateSettingsTypeMarshaller : IRequestMarshaller<UserAttributeUpdateSettingsType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UserAttributeUpdateSettingsType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributesRequireVerificationBeforeUpdate())
            {
                context.Writer.WritePropertyName("AttributesRequireVerificationBeforeUpdate");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAttributesRequireVerificationBeforeUpdateListValue in requestObject.AttributesRequireVerificationBeforeUpdate)
                {
                        context.Writer.Write(requestObjectAttributesRequireVerificationBeforeUpdateListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UserAttributeUpdateSettingsTypeMarshaller Instance = new UserAttributeUpdateSettingsTypeMarshaller();

    }
}