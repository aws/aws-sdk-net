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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Assets Marshaller
    /// </summary>
    public class AssetsMarshaller : IRequestMarshaller<Assets, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Assets requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActors())
            {
                context.Writer.WritePropertyName("actors");
                context.Writer.WriteStartArray();
                foreach(var requestObjectActorsListValue in requestObject.Actors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ActorMarshaller.Instance;
                    marshaller.Marshall(requestObjectActorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDocuments())
            {
                context.Writer.WritePropertyName("documents");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDocumentsListValue in requestObject.Documents)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DocumentInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectDocumentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEndpoints())
            {
                context.Writer.WritePropertyName("endpoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEndpointsListValue in requestObject.Endpoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EndpointMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndpointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIntegratedRepositories())
            {
                context.Writer.WritePropertyName("integratedRepositories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIntegratedRepositoriesListValue in requestObject.IntegratedRepositories)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IntegratedRepositoryMarshaller.Instance;
                    marshaller.Marshall(requestObjectIntegratedRepositoriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourceCode())
            {
                context.Writer.WritePropertyName("sourceCode");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSourceCodeListValue in requestObject.SourceCode)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SourceCodeRepositoryMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourceCodeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssetsMarshaller Instance = new AssetsMarshaller();

    }
}