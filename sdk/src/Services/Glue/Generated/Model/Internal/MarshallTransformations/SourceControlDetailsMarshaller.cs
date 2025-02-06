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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceControlDetails Marshaller
    /// </summary>
    public class SourceControlDetailsMarshaller : IRequestMarshaller<SourceControlDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceControlDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthStrategy())
            {
                context.Writer.WritePropertyName("AuthStrategy");
                context.Writer.WriteStringValue(requestObject.AuthStrategy);
            }

            if(requestObject.IsSetAuthToken())
            {
                context.Writer.WritePropertyName("AuthToken");
                context.Writer.WriteStringValue(requestObject.AuthToken);
            }

            if(requestObject.IsSetBranch())
            {
                context.Writer.WritePropertyName("Branch");
                context.Writer.WriteStringValue(requestObject.Branch);
            }

            if(requestObject.IsSetFolder())
            {
                context.Writer.WritePropertyName("Folder");
                context.Writer.WriteStringValue(requestObject.Folder);
            }

            if(requestObject.IsSetLastCommitId())
            {
                context.Writer.WritePropertyName("LastCommitId");
                context.Writer.WriteStringValue(requestObject.LastCommitId);
            }

            if(requestObject.IsSetOwner())
            {
                context.Writer.WritePropertyName("Owner");
                context.Writer.WriteStringValue(requestObject.Owner);
            }

            if(requestObject.IsSetProvider())
            {
                context.Writer.WritePropertyName("Provider");
                context.Writer.WriteStringValue(requestObject.Provider);
            }

            if(requestObject.IsSetRepository())
            {
                context.Writer.WritePropertyName("Repository");
                context.Writer.WriteStringValue(requestObject.Repository);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceControlDetailsMarshaller Instance = new SourceControlDetailsMarshaller();

    }
}