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

using Amazon.WorkSpaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkspaceRequest Marshaller
    /// </summary>
    public partial class WorkspaceRequestMarshaller : IRequestMarshaller<WorkspaceRequest, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(WorkspaceRequest requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBundleId())
            {
                context.Writer.WriteTextString("BundleId");
                context.Writer.WriteTextString(requestObject.BundleId);
            }

            if (requestObject.IsSetDirectoryId())
            {
                context.Writer.WriteTextString("DirectoryId");
                context.Writer.WriteTextString(requestObject.DirectoryId);
            }

            if (requestObject.IsSetIpv6Address())
            {
                context.Writer.WriteTextString("Ipv6Address");
                context.Writer.WriteTextString(requestObject.Ipv6Address);
            }

            if (requestObject.IsSetRootVolumeEncryptionEnabled())
            {
                context.Writer.WriteTextString("RootVolumeEncryptionEnabled");
                context.Writer.WriteBoolean(requestObject.RootVolumeEncryptionEnabled.Value);
            }

            if (requestObject.IsSetTags())
            {
                context.Writer.WriteTextString("Tags");
                context.Writer.WriteStartArray(requestObject.Tags.Count);
                foreach (var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetUserName())
            {
                context.Writer.WriteTextString("UserName");
                context.Writer.WriteTextString(requestObject.UserName);
            }

            if (requestObject.IsSetUserVolumeEncryptionEnabled())
            {
                context.Writer.WriteTextString("UserVolumeEncryptionEnabled");
                context.Writer.WriteBoolean(requestObject.UserVolumeEncryptionEnabled.Value);
            }

            if (requestObject.IsSetVolumeEncryptionKey())
            {
                context.Writer.WriteTextString("VolumeEncryptionKey");
                context.Writer.WriteTextString(requestObject.VolumeEncryptionKey);
            }

            if (requestObject.IsSetWorkspaceName())
            {
                context.Writer.WriteTextString("WorkspaceName");
                context.Writer.WriteTextString(requestObject.WorkspaceName);
            }

            if (requestObject.IsSetWorkspaceProperties())
            {
                context.Writer.WriteTextString("WorkspaceProperties");
                context.Writer.WriteStartMap(null);

                var marshaller = WorkspacePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.WorkspaceProperties, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static WorkspaceRequestMarshaller Instance = new WorkspaceRequestMarshaller();
    }
}
