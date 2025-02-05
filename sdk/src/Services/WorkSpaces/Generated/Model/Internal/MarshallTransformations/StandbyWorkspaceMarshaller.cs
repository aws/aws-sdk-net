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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StandbyWorkspace Marshaller
    /// </summary>
    public class StandbyWorkspaceMarshaller : IRequestMarshaller<StandbyWorkspace, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StandbyWorkspace requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataReplication())
            {
                context.Writer.WritePropertyName("DataReplication");
                context.Writer.WriteStringValue(requestObject.DataReplication);
            }

            if(requestObject.IsSetDirectoryId())
            {
                context.Writer.WritePropertyName("DirectoryId");
                context.Writer.WriteStringValue(requestObject.DirectoryId);
            }

            if(requestObject.IsSetPrimaryWorkspaceId())
            {
                context.Writer.WritePropertyName("PrimaryWorkspaceId");
                context.Writer.WriteStringValue(requestObject.PrimaryWorkspaceId);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVolumeEncryptionKey())
            {
                context.Writer.WritePropertyName("VolumeEncryptionKey");
                context.Writer.WriteStringValue(requestObject.VolumeEncryptionKey);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StandbyWorkspaceMarshaller Instance = new StandbyWorkspaceMarshaller();

    }
}