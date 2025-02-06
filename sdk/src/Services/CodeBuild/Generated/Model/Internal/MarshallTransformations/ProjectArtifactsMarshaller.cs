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
    /// ProjectArtifacts Marshaller
    /// </summary>
    public class ProjectArtifactsMarshaller : IRequestMarshaller<ProjectArtifacts, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProjectArtifacts requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArtifactIdentifier())
            {
                context.Writer.WritePropertyName("artifactIdentifier");
                context.Writer.WriteStringValue(requestObject.ArtifactIdentifier);
            }

            if(requestObject.IsSetBucketOwnerAccess())
            {
                context.Writer.WritePropertyName("bucketOwnerAccess");
                context.Writer.WriteStringValue(requestObject.BucketOwnerAccess);
            }

            if(requestObject.IsSetEncryptionDisabled())
            {
                context.Writer.WritePropertyName("encryptionDisabled");
                context.Writer.WriteBooleanValue(requestObject.EncryptionDisabled.Value);
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("location");
                context.Writer.WriteStringValue(requestObject.Location);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetNamespaceType())
            {
                context.Writer.WritePropertyName("namespaceType");
                context.Writer.WriteStringValue(requestObject.NamespaceType);
            }

            if(requestObject.IsSetOverrideArtifactName())
            {
                context.Writer.WritePropertyName("overrideArtifactName");
                context.Writer.WriteBooleanValue(requestObject.OverrideArtifactName.Value);
            }

            if(requestObject.IsSetPackaging())
            {
                context.Writer.WritePropertyName("packaging");
                context.Writer.WriteStringValue(requestObject.Packaging);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.WriteStringValue(requestObject.Path);
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
        public readonly static ProjectArtifactsMarshaller Instance = new ProjectArtifactsMarshaller();

    }
}