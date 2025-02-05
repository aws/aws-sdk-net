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
#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PasswordPolicyType Marshaller
    /// </summary>
    public class PasswordPolicyTypeMarshaller : IRequestMarshaller<PasswordPolicyType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PasswordPolicyType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMinimumLength())
            {
                context.Writer.WritePropertyName("MinimumLength");
                context.Writer.WriteNumberValue(requestObject.MinimumLength.Value);
            }

            if(requestObject.IsSetPasswordHistorySize())
            {
                context.Writer.WritePropertyName("PasswordHistorySize");
                context.Writer.WriteNumberValue(requestObject.PasswordHistorySize.Value);
            }

            if(requestObject.IsSetRequireLowercase())
            {
                context.Writer.WritePropertyName("RequireLowercase");
                context.Writer.WriteBooleanValue(requestObject.RequireLowercase.Value);
            }

            if(requestObject.IsSetRequireNumbers())
            {
                context.Writer.WritePropertyName("RequireNumbers");
                context.Writer.WriteBooleanValue(requestObject.RequireNumbers.Value);
            }

            if(requestObject.IsSetRequireSymbols())
            {
                context.Writer.WritePropertyName("RequireSymbols");
                context.Writer.WriteBooleanValue(requestObject.RequireSymbols.Value);
            }

            if(requestObject.IsSetRequireUppercase())
            {
                context.Writer.WritePropertyName("RequireUppercase");
                context.Writer.WriteBooleanValue(requestObject.RequireUppercase.Value);
            }

            if(requestObject.IsSetTemporaryPasswordValidityDays())
            {
                context.Writer.WritePropertyName("TemporaryPasswordValidityDays");
                context.Writer.WriteNumberValue(requestObject.TemporaryPasswordValidityDays.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PasswordPolicyTypeMarshaller Instance = new PasswordPolicyTypeMarshaller();

    }
}