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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3LogConfiguration Marshaller
    /// </summary>
    public class S3LogConfigurationMarshaller : IRequestMarshaller<S3LogConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3LogConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBucket())
            {
                context.Writer.WritePropertyName("bucket");
                context.Writer.WriteStringValue(requestObject.Bucket);
            }

            if(requestObject.IsSetBucketOwner())
            {
                context.Writer.WritePropertyName("bucketOwner");
                context.Writer.WriteStringValue(requestObject.BucketOwner);
            }

            if(requestObject.IsSetFolderStructure())
            {
                context.Writer.WritePropertyName("folderStructure");
                context.Writer.WriteStringValue(requestObject.FolderStructure);
            }

            if(requestObject.IsSetKeyPrefix())
            {
                context.Writer.WritePropertyName("keyPrefix");
                context.Writer.WriteStringValue(requestObject.KeyPrefix);
            }

            if(requestObject.IsSetLogFileFormat())
            {
                context.Writer.WritePropertyName("logFileFormat");
                context.Writer.WriteStringValue(requestObject.LogFileFormat);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3LogConfigurationMarshaller Instance = new S3LogConfigurationMarshaller();

    }
}