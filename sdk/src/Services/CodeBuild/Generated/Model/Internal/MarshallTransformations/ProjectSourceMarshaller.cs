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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProjectSource Marshaller
    /// </summary>
    public class ProjectSourceMarshaller : IRequestMarshaller<ProjectSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProjectSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuth())
            {
                context.Writer.WritePropertyName("auth");
                context.Writer.WriteStartObject();

                var marshaller = SourceAuthMarshaller.Instance;
                marshaller.Marshall(requestObject.Auth, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBuildspec())
            {
                context.Writer.WritePropertyName("buildspec");
                context.Writer.WriteStringValue(requestObject.Buildspec);
            }

            if(requestObject.IsSetBuildStatusConfig())
            {
                context.Writer.WritePropertyName("buildStatusConfig");
                context.Writer.WriteStartObject();

                var marshaller = BuildStatusConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BuildStatusConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGitCloneDepth())
            {
                context.Writer.WritePropertyName("gitCloneDepth");
                context.Writer.WriteNumberValue(requestObject.GitCloneDepth.Value);
            }

            if(requestObject.IsSetGitSubmodulesConfig())
            {
                context.Writer.WritePropertyName("gitSubmodulesConfig");
                context.Writer.WriteStartObject();

                var marshaller = GitSubmodulesConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.GitSubmodulesConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInsecureSsl())
            {
                context.Writer.WritePropertyName("insecureSsl");
                context.Writer.WriteBooleanValue(requestObject.InsecureSsl.Value);
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("location");
                context.Writer.WriteStringValue(requestObject.Location);
            }

            if(requestObject.IsSetReportBuildStatus())
            {
                context.Writer.WritePropertyName("reportBuildStatus");
                context.Writer.WriteBooleanValue(requestObject.ReportBuildStatus.Value);
            }

            if(requestObject.IsSetSourceIdentifier())
            {
                context.Writer.WritePropertyName("sourceIdentifier");
                context.Writer.WriteStringValue(requestObject.SourceIdentifier);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProjectSourceMarshaller Instance = new ProjectSourceMarshaller();

    }
}