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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JwtTokenTypeConfiguration Marshaller
    /// </summary>
    public class JwtTokenTypeConfigurationMarshaller : IRequestMarshaller<JwtTokenTypeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JwtTokenTypeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClaimRegex())
            {
                context.Writer.WritePropertyName("ClaimRegex");
                context.Writer.WriteStringValue(requestObject.ClaimRegex);
            }

            if(requestObject.IsSetGroupAttributeField())
            {
                context.Writer.WritePropertyName("GroupAttributeField");
                context.Writer.WriteStringValue(requestObject.GroupAttributeField);
            }

            if(requestObject.IsSetIssuer())
            {
                context.Writer.WritePropertyName("Issuer");
                context.Writer.WriteStringValue(requestObject.Issuer);
            }

            if(requestObject.IsSetKeyLocation())
            {
                context.Writer.WritePropertyName("KeyLocation");
                context.Writer.WriteStringValue(requestObject.KeyLocation);
            }

            if(requestObject.IsSetSecretManagerArn())
            {
                context.Writer.WritePropertyName("SecretManagerArn");
                context.Writer.WriteStringValue(requestObject.SecretManagerArn);
            }

            if(requestObject.IsSetURL())
            {
                context.Writer.WritePropertyName("URL");
                context.Writer.WriteStringValue(requestObject.URL);
            }

            if(requestObject.IsSetUserNameAttributeField())
            {
                context.Writer.WritePropertyName("UserNameAttributeField");
                context.Writer.WriteStringValue(requestObject.UserNameAttributeField);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JwtTokenTypeConfigurationMarshaller Instance = new JwtTokenTypeConfigurationMarshaller();

    }
}