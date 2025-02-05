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
    /// CodeRepository Marshaller
    /// </summary>
    public class CodeRepositoryMarshaller : IRequestMarshaller<CodeRepository, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodeRepository requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCodeConfiguration())
            {
                context.Writer.WritePropertyName("CodeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CodeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CodeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRepositoryUrl())
            {
                context.Writer.WritePropertyName("RepositoryUrl");
                context.Writer.WriteStringValue(requestObject.RepositoryUrl);
            }

            if(requestObject.IsSetSourceCodeVersion())
            {
                context.Writer.WritePropertyName("SourceCodeVersion");
                context.Writer.WriteStartObject();

                var marshaller = SourceCodeVersionMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceCodeVersion, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceDirectory())
            {
                context.Writer.WritePropertyName("SourceDirectory");
                context.Writer.WriteStringValue(requestObject.SourceDirectory);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodeRepositoryMarshaller Instance = new CodeRepositoryMarshaller();

    }
}