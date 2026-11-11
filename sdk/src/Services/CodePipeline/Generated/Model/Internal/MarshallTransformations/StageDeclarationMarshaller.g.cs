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
    /// StageDeclaration Marshaller
    /// </summary>
    public partial class StageDeclarationMarshaller : IRequestMarshaller<StageDeclaration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(StageDeclaration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetActions())
            {
                context.Writer.WriteTextString("actions");
                context.Writer.WriteStartArray(requestObject.Actions.Count);
                foreach (var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ActionDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetBeforeEntry())
            {
                context.Writer.WriteTextString("beforeEntry");
                context.Writer.WriteStartMap(null);

                var marshaller = BeforeEntryConditionsMarshaller.Instance;
                marshaller.Marshall(requestObject.BeforeEntry, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetBlockers())
            {
                context.Writer.WriteTextString("blockers");
                context.Writer.WriteStartArray(requestObject.Blockers.Count);
                foreach (var requestObjectBlockersListValue in requestObject.Blockers)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = BlockerDeclarationMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockersListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("name");
                context.Writer.WriteTextString(requestObject.Name);
            }

            if (requestObject.IsSetOnFailure())
            {
                context.Writer.WriteTextString("onFailure");
                context.Writer.WriteStartMap(null);

                var marshaller = FailureConditionsMarshaller.Instance;
                marshaller.Marshall(requestObject.OnFailure, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetOnSuccess())
            {
                context.Writer.WriteTextString("onSuccess");
                context.Writer.WriteStartMap(null);

                var marshaller = SuccessConditionsMarshaller.Instance;
                marshaller.Marshall(requestObject.OnSuccess, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static StageDeclarationMarshaller Instance = new StageDeclarationMarshaller();
    }
}
