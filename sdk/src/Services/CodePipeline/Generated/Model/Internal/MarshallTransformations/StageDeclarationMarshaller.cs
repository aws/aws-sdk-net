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
    /// StageDeclaration Marshaller
    /// </summary>
    public class StageDeclarationMarshaller : IRequestMarshaller<StageDeclaration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StageDeclaration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("actions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ActionDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBeforeEntry())
            {
                context.Writer.WritePropertyName("beforeEntry");
                context.Writer.WriteStartObject();

                var marshaller = BeforeEntryConditionsMarshaller.Instance;
                marshaller.Marshall(requestObject.BeforeEntry, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBlockers())
            {
                context.Writer.WritePropertyName("blockers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBlockersListValue in requestObject.Blockers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BlockerDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOnFailure())
            {
                context.Writer.WritePropertyName("onFailure");
                context.Writer.WriteStartObject();

                var marshaller = FailureConditionsMarshaller.Instance;
                marshaller.Marshall(requestObject.OnFailure, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOnSuccess())
            {
                context.Writer.WritePropertyName("onSuccess");
                context.Writer.WriteStartObject();

                var marshaller = SuccessConditionsMarshaller.Instance;
                marshaller.Marshall(requestObject.OnSuccess, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StageDeclarationMarshaller Instance = new StageDeclarationMarshaller();

    }
}