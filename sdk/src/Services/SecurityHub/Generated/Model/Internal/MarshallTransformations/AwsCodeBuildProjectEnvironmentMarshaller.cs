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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsCodeBuildProjectEnvironment Marshaller
    /// </summary>
    public class AwsCodeBuildProjectEnvironmentMarshaller : IRequestMarshaller<AwsCodeBuildProjectEnvironment, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCodeBuildProjectEnvironment requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCertificate())
            {
                context.Writer.WritePropertyName("Certificate");
                context.Writer.Write(requestObject.Certificate);
            }

            if(requestObject.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("EnvironmentVariables");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentVariablesListValue in requestObject.EnvironmentVariables)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentVariablesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetImagePullCredentialsType())
            {
                context.Writer.WritePropertyName("ImagePullCredentialsType");
                context.Writer.Write(requestObject.ImagePullCredentialsType);
            }

            if(requestObject.IsSetPrivilegedMode())
            {
                context.Writer.WritePropertyName("PrivilegedMode");
                context.Writer.Write(requestObject.PrivilegedMode);
            }

            if(requestObject.IsSetRegistryCredential())
            {
                context.Writer.WritePropertyName("RegistryCredential");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCodeBuildProjectEnvironmentRegistryCredentialMarshaller.Instance;
                marshaller.Marshall(requestObject.RegistryCredential, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCodeBuildProjectEnvironmentMarshaller Instance = new AwsCodeBuildProjectEnvironmentMarshaller();

    }
}