/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActionDeclaration Marshaller
    /// </summary>       
    public class ActionDeclarationMarshaller : IRequestMarshaller<ActionDeclaration, JsonMarshallerContext> 
    {
        public void Marshall(ActionDeclaration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActionTypeId())
            {
                context.Writer.WritePropertyName("actionTypeId");
                context.Writer.WriteObjectStart();

                var marshaller = ActionTypeIdMarshaller.Instance;
                marshaller.Marshall(requestObject.ActionTypeId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectConfigurationKvp in requestObject.Configuration)
                {
                    context.Writer.WritePropertyName(requestObjectConfigurationKvp.Key);
                    var requestObjectConfigurationValue = requestObjectConfigurationKvp.Value;

                        context.Writer.Write(requestObjectConfigurationValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputArtifacts())
            {
                context.Writer.WritePropertyName("inputArtifacts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputArtifactsListValue in requestObject.InputArtifacts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InputArtifactMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputArtifactsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOutputArtifacts())
            {
                context.Writer.WritePropertyName("outputArtifacts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputArtifactsListValue in requestObject.OutputArtifacts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputArtifactMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputArtifactsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetRunOrder())
            {
                context.Writer.WritePropertyName("runOrder");
                context.Writer.Write(requestObject.RunOrder);
            }

        }

        public readonly static ActionDeclarationMarshaller Instance = new ActionDeclarationMarshaller();

    }
}