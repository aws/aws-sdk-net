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

using Amazon.CodeBuild.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProjectSource Marshaller
    /// </summary>
    public partial class ProjectSourceMarshaller : IRequestMarshaller<ProjectSource, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ProjectSource requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAuth())
            {
                context.Writer.WriteTextString("auth");
                context.Writer.WriteStartMap(null);

                var marshaller = SourceAuthMarshaller.Instance;
                marshaller.Marshall(requestObject.Auth, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetBuildStatusConfig())
            {
                context.Writer.WriteTextString("buildStatusConfig");
                context.Writer.WriteStartMap(null);

                var marshaller = BuildStatusConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BuildStatusConfig, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetBuildspec())
            {
                context.Writer.WriteTextString("buildspec");
                context.Writer.WriteTextString(requestObject.Buildspec);
            }

            if (requestObject.IsSetGitCloneDepth())
            {
                context.Writer.WriteTextString("gitCloneDepth");
                context.Writer.WriteInt32(requestObject.GitCloneDepth.Value);
            }

            if (requestObject.IsSetGitSubmodulesConfig())
            {
                context.Writer.WriteTextString("gitSubmodulesConfig");
                context.Writer.WriteStartMap(null);

                var marshaller = GitSubmodulesConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.GitSubmodulesConfig, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetInsecureSsl())
            {
                context.Writer.WriteTextString("insecureSsl");
                context.Writer.WriteBoolean(requestObject.InsecureSsl.Value);
            }

            if (requestObject.IsSetLocation())
            {
                context.Writer.WriteTextString("location");
                context.Writer.WriteTextString(requestObject.Location);
            }

            if (requestObject.IsSetReportBuildStatus())
            {
                context.Writer.WriteTextString("reportBuildStatus");
                context.Writer.WriteBoolean(requestObject.ReportBuildStatus.Value);
            }

            if (requestObject.IsSetSourceIdentifier())
            {
                context.Writer.WriteTextString("sourceIdentifier");
                context.Writer.WriteTextString(requestObject.SourceIdentifier);
            }

            if (requestObject.IsSetType())
            {
                context.Writer.WriteTextString("type");
                context.Writer.WriteTextString(requestObject.Type);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ProjectSourceMarshaller Instance = new ProjectSourceMarshaller();
    }
}
