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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SecurityControlsConfiguration Marshaller
    /// </summary>
    public class SecurityControlsConfigurationMarshaller : IRequestMarshaller<SecurityControlsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SecurityControlsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDisabledSecurityControlIdentifiers())
            {
                context.Writer.WritePropertyName("DisabledSecurityControlIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDisabledSecurityControlIdentifiersListValue in requestObject.DisabledSecurityControlIdentifiers)
                {
                        context.Writer.WriteStringValue(requestObjectDisabledSecurityControlIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnabledSecurityControlIdentifiers())
            {
                context.Writer.WritePropertyName("EnabledSecurityControlIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnabledSecurityControlIdentifiersListValue in requestObject.EnabledSecurityControlIdentifiers)
                {
                        context.Writer.WriteStringValue(requestObjectEnabledSecurityControlIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecurityControlCustomParameters())
            {
                context.Writer.WritePropertyName("SecurityControlCustomParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityControlCustomParametersListValue in requestObject.SecurityControlCustomParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SecurityControlCustomParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecurityControlCustomParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SecurityControlsConfigurationMarshaller Instance = new SecurityControlsConfigurationMarshaller();

    }
}