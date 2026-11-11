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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CodePipeline.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActionTypeDeclaration Marshaller
    /// </summary>
    public partial class ActionTypeDeclarationMarshaller : IRequestMarshaller<ActionTypeDeclaration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ActionTypeDeclaration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDescription())
            {
                context.Writer.WriteTextString("description");
                context.Writer.WriteTextString(requestObject.Description);
            }

            if (requestObject.IsSetExecutor())
            {
                context.Writer.WriteTextString("executor");
                context.Writer.WriteStartMap(null);

                var marshaller = ActionTypeExecutorMarshaller.Instance;
                marshaller.Marshall(requestObject.Executor, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetId())
            {
                context.Writer.WriteTextString("id");
                context.Writer.WriteStartMap(null);

                var marshaller = ActionTypeIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.Id, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetInputArtifactDetails())
            {
                context.Writer.WriteTextString("inputArtifactDetails");
                context.Writer.WriteStartMap(null);

                var marshaller = ActionTypeArtifactDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.InputArtifactDetails, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetOutputArtifactDetails())
            {
                context.Writer.WriteTextString("outputArtifactDetails");
                context.Writer.WriteStartMap(null);

                var marshaller = ActionTypeArtifactDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputArtifactDetails, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetPermissions())
            {
                context.Writer.WriteTextString("permissions");
                context.Writer.WriteStartMap(null);

                var marshaller = ActionTypePermissionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Permissions, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetProperties())
            {
                context.Writer.WriteTextString("properties");
                context.Writer.WriteStartArray(requestObject.Properties.Count);
                foreach (var requestObjectPropertiesListValue in requestObject.Properties)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ActionTypePropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertiesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetUrls())
            {
                context.Writer.WriteTextString("urls");
                context.Writer.WriteStartMap(null);

                var marshaller = ActionTypeUrlsMarshaller.Instance;
                marshaller.Marshall(requestObject.Urls, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ActionTypeDeclarationMarshaller Instance = new ActionTypeDeclarationMarshaller();
    }
}
