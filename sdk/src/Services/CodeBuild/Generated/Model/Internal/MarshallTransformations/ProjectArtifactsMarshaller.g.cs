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
    /// ProjectArtifacts Marshaller
    /// </summary>
    public partial class ProjectArtifactsMarshaller : IRequestMarshaller<ProjectArtifacts, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ProjectArtifacts requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetArtifactIdentifier())
            {
                context.Writer.WriteTextString("artifactIdentifier");
                context.Writer.WriteTextString(requestObject.ArtifactIdentifier);
            }

            if (requestObject.IsSetBucketOwnerAccess())
            {
                context.Writer.WriteTextString("bucketOwnerAccess");
                context.Writer.WriteTextString(requestObject.BucketOwnerAccess);
            }

            if (requestObject.IsSetEncryptionDisabled())
            {
                context.Writer.WriteTextString("encryptionDisabled");
                context.Writer.WriteBoolean(requestObject.EncryptionDisabled.Value);
            }

            if (requestObject.IsSetLocation())
            {
                context.Writer.WriteTextString("location");
                context.Writer.WriteTextString(requestObject.Location);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("name");
                context.Writer.WriteTextString(requestObject.Name);
            }

            if (requestObject.IsSetNamespaceType())
            {
                context.Writer.WriteTextString("namespaceType");
                context.Writer.WriteTextString(requestObject.NamespaceType);
            }

            if (requestObject.IsSetOverrideArtifactName())
            {
                context.Writer.WriteTextString("overrideArtifactName");
                context.Writer.WriteBoolean(requestObject.OverrideArtifactName.Value);
            }

            if (requestObject.IsSetPackaging())
            {
                context.Writer.WriteTextString("packaging");
                context.Writer.WriteTextString(requestObject.Packaging);
            }

            if (requestObject.IsSetPath())
            {
                context.Writer.WriteTextString("path");
                context.Writer.WriteTextString(requestObject.Path);
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
        public readonly static ProjectArtifactsMarshaller Instance = new ProjectArtifactsMarshaller();
    }
}
