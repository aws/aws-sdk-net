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

using Amazon.SecurityAgent.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Assets Object
    /// </summary>
    public partial class AssetsUnmarshaller : IJsonUnmarshaller<Assets, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Assets Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new Assets();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actors", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Actor, ActorUnmarshaller>(ActorUnmarshaller.Instance);
                    unmarshalledObject.Actors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("documents", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DocumentInfo, DocumentInfoUnmarshaller>(DocumentInfoUnmarshaller.Instance);
                    unmarshalledObject.Documents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("endpoints", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Endpoint, EndpointUnmarshaller>(EndpointUnmarshaller.Instance);
                    unmarshalledObject.Endpoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("integratedRepositories", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IntegratedRepository, IntegratedRepositoryUnmarshaller>(IntegratedRepositoryUnmarshaller.Instance);
                    unmarshalledObject.IntegratedRepositories = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sourceCode", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<SourceCodeRepository, SourceCodeRepositoryUnmarshaller>(SourceCodeRepositoryUnmarshaller.Instance);
                    unmarshalledObject.SourceCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("trustedCaCertificates", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<TrustedCaCertificate, TrustedCaCertificateUnmarshaller>(TrustedCaCertificateUnmarshaller.Instance);
                    unmarshalledObject.TrustedCaCertificates = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static AssetsUnmarshaller _instance = new AssetsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssetsUnmarshaller Instance => _instance;
    }
}
