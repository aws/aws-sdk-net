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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppRunner.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppRunner.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthenticationConfiguration Marshaller
    /// </summary>
    public class AuthenticationConfigurationMarshaller : IRequestMarshaller<AuthenticationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AuthenticationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessRoleArn())
            {
                context.Writer.WritePropertyName("AccessRoleArn");
                context.Writer.WriteStringValue(requestObject.AccessRoleArn);
            }

            if(requestObject.IsSetConnectionArn())
            {
                context.Writer.WritePropertyName("ConnectionArn");
                context.Writer.WriteStringValue(requestObject.ConnectionArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AuthenticationConfigurationMarshaller Instance = new AuthenticationConfigurationMarshaller();

    }
}