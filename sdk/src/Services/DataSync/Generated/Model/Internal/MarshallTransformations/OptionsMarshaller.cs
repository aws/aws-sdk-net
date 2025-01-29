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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Options Marshaller
    /// </summary>
    public class OptionsMarshaller : IRequestMarshaller<Options, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Options requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAtime())
            {
                context.Writer.WritePropertyName("Atime");
                context.Writer.WriteStringValue(requestObject.Atime);
            }

            if(requestObject.IsSetBytesPerSecond())
            {
                context.Writer.WritePropertyName("BytesPerSecond");
                context.Writer.WriteNumberValue(requestObject.BytesPerSecond.Value);
            }

            if(requestObject.IsSetGid())
            {
                context.Writer.WritePropertyName("Gid");
                context.Writer.WriteStringValue(requestObject.Gid);
            }

            if(requestObject.IsSetLogLevel())
            {
                context.Writer.WritePropertyName("LogLevel");
                context.Writer.WriteStringValue(requestObject.LogLevel);
            }

            if(requestObject.IsSetMtime())
            {
                context.Writer.WritePropertyName("Mtime");
                context.Writer.WriteStringValue(requestObject.Mtime);
            }

            if(requestObject.IsSetObjectTags())
            {
                context.Writer.WritePropertyName("ObjectTags");
                context.Writer.WriteStringValue(requestObject.ObjectTags);
            }

            if(requestObject.IsSetOverwriteMode())
            {
                context.Writer.WritePropertyName("OverwriteMode");
                context.Writer.WriteStringValue(requestObject.OverwriteMode);
            }

            if(requestObject.IsSetPosixPermissions())
            {
                context.Writer.WritePropertyName("PosixPermissions");
                context.Writer.WriteStringValue(requestObject.PosixPermissions);
            }

            if(requestObject.IsSetPreserveDeletedFiles())
            {
                context.Writer.WritePropertyName("PreserveDeletedFiles");
                context.Writer.WriteStringValue(requestObject.PreserveDeletedFiles);
            }

            if(requestObject.IsSetPreserveDevices())
            {
                context.Writer.WritePropertyName("PreserveDevices");
                context.Writer.WriteStringValue(requestObject.PreserveDevices);
            }

            if(requestObject.IsSetSecurityDescriptorCopyFlags())
            {
                context.Writer.WritePropertyName("SecurityDescriptorCopyFlags");
                context.Writer.WriteStringValue(requestObject.SecurityDescriptorCopyFlags);
            }

            if(requestObject.IsSetTaskQueueing())
            {
                context.Writer.WritePropertyName("TaskQueueing");
                context.Writer.WriteStringValue(requestObject.TaskQueueing);
            }

            if(requestObject.IsSetTransferMode())
            {
                context.Writer.WritePropertyName("TransferMode");
                context.Writer.WriteStringValue(requestObject.TransferMode);
            }

            if(requestObject.IsSetUid())
            {
                context.Writer.WritePropertyName("Uid");
                context.Writer.WriteStringValue(requestObject.Uid);
            }

            if(requestObject.IsSetVerifyMode())
            {
                context.Writer.WritePropertyName("VerifyMode");
                context.Writer.WriteStringValue(requestObject.VerifyMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OptionsMarshaller Instance = new OptionsMarshaller();

    }
}