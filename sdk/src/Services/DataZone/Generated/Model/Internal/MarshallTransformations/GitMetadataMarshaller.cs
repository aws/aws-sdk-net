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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GitMetadata Marshaller
    /// </summary>
    public class GitMetadataMarshaller : IRequestMarshaller<GitMetadata, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GitMetadata requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBranch())
            {
                context.Writer.WritePropertyName("branch");
                context.Writer.WriteStringValue(requestObject.Branch);
            }

            if(requestObject.IsSetCommitHash())
            {
                context.Writer.WritePropertyName("commitHash");
                context.Writer.WriteStringValue(requestObject.CommitHash);
            }

            if(requestObject.IsSetCommitMessage())
            {
                context.Writer.WritePropertyName("commitMessage");
                context.Writer.WriteStringValue(requestObject.CommitMessage);
            }

            if(requestObject.IsSetCommittedAt())
            {
                context.Writer.WritePropertyName("committedAt");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.CommittedAt.Value)));
            }

            if(requestObject.IsSetConnectionId())
            {
                context.Writer.WritePropertyName("connectionId");
                context.Writer.WriteStringValue(requestObject.ConnectionId);
            }

            if(requestObject.IsSetFileName())
            {
                context.Writer.WritePropertyName("fileName");
                context.Writer.WriteStringValue(requestObject.FileName);
            }

            if(requestObject.IsSetRepository())
            {
                context.Writer.WritePropertyName("repository");
                context.Writer.WriteStringValue(requestObject.Repository);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GitMetadataMarshaller Instance = new GitMetadataMarshaller();

    }
}