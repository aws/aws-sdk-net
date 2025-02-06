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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActionTypeDeclaration Marshaller
    /// </summary>
    public class ActionTypeDeclarationMarshaller : IRequestMarshaller<ActionTypeDeclaration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ActionTypeDeclaration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetExecutor())
            {
                context.Writer.WritePropertyName("executor");
                context.Writer.WriteStartObject();

                var marshaller = ActionTypeExecutorMarshaller.Instance;
                marshaller.Marshall(requestObject.Executor, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStartObject();

                var marshaller = ActionTypeIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.Id, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputArtifactDetails())
            {
                context.Writer.WritePropertyName("inputArtifactDetails");
                context.Writer.WriteStartObject();

                var marshaller = ActionTypeArtifactDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.InputArtifactDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputArtifactDetails())
            {
                context.Writer.WritePropertyName("outputArtifactDetails");
                context.Writer.WriteStartObject();

                var marshaller = ActionTypeArtifactDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputArtifactDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPermissions())
            {
                context.Writer.WritePropertyName("permissions");
                context.Writer.WriteStartObject();

                var marshaller = ActionTypePermissionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Permissions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("properties");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPropertiesListValue in requestObject.Properties)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ActionTypePropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUrls())
            {
                context.Writer.WritePropertyName("urls");
                context.Writer.WriteStartObject();

                var marshaller = ActionTypeUrlsMarshaller.Instance;
                marshaller.Marshall(requestObject.Urls, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActionTypeDeclarationMarshaller Instance = new ActionTypeDeclarationMarshaller();

    }
}