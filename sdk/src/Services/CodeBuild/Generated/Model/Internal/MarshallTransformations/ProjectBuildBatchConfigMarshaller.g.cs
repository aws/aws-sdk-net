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
    /// ProjectBuildBatchConfig Marshaller
    /// </summary>
    public partial class ProjectBuildBatchConfigMarshaller : IRequestMarshaller<ProjectBuildBatchConfig, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ProjectBuildBatchConfig requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBatchReportMode())
            {
                context.Writer.WriteTextString("batchReportMode");
                context.Writer.WriteTextString(requestObject.BatchReportMode);
            }

            if (requestObject.IsSetCombineArtifacts())
            {
                context.Writer.WriteTextString("combineArtifacts");
                context.Writer.WriteBoolean(requestObject.CombineArtifacts.Value);
            }

            if (requestObject.IsSetRestrictions())
            {
                context.Writer.WriteTextString("restrictions");
                context.Writer.WriteStartMap(null);

                var marshaller = BatchRestrictionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Restrictions, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetServiceRole())
            {
                context.Writer.WriteTextString("serviceRole");
                context.Writer.WriteTextString(requestObject.ServiceRole);
            }

            if (requestObject.IsSetTimeoutInMins())
            {
                context.Writer.WriteTextString("timeoutInMins");
                context.Writer.WriteInt32(requestObject.TimeoutInMins.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ProjectBuildBatchConfigMarshaller Instance = new ProjectBuildBatchConfigMarshaller();
    }
}
