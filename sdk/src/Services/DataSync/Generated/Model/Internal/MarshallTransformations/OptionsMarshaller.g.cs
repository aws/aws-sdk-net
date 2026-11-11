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

using Amazon.DataSync.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Options Marshaller
    /// </summary>
    public partial class OptionsMarshaller : IRequestMarshaller<Options, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Options requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAtime())
            {
                context.Writer.WriteTextString("Atime");
                context.Writer.WriteTextString(requestObject.Atime);
            }

            if (requestObject.IsSetBytesPerSecond())
            {
                context.Writer.WriteTextString("BytesPerSecond");
                context.Writer.WriteInt64(requestObject.BytesPerSecond.Value);
            }

            if (requestObject.IsSetGid())
            {
                context.Writer.WriteTextString("Gid");
                context.Writer.WriteTextString(requestObject.Gid);
            }

            if (requestObject.IsSetLogLevel())
            {
                context.Writer.WriteTextString("LogLevel");
                context.Writer.WriteTextString(requestObject.LogLevel);
            }

            if (requestObject.IsSetMtime())
            {
                context.Writer.WriteTextString("Mtime");
                context.Writer.WriteTextString(requestObject.Mtime);
            }

            if (requestObject.IsSetObjectMetadata())
            {
                context.Writer.WriteTextString("ObjectMetadata");
                context.Writer.WriteTextString(requestObject.ObjectMetadata);
            }

            if (requestObject.IsSetObjectTags())
            {
                context.Writer.WriteTextString("ObjectTags");
                context.Writer.WriteTextString(requestObject.ObjectTags);
            }

            if (requestObject.IsSetOverwriteMode())
            {
                context.Writer.WriteTextString("OverwriteMode");
                context.Writer.WriteTextString(requestObject.OverwriteMode);
            }

            if (requestObject.IsSetPosixPermissions())
            {
                context.Writer.WriteTextString("PosixPermissions");
                context.Writer.WriteTextString(requestObject.PosixPermissions);
            }

            if (requestObject.IsSetPreserveDeletedFiles())
            {
                context.Writer.WriteTextString("PreserveDeletedFiles");
                context.Writer.WriteTextString(requestObject.PreserveDeletedFiles);
            }

            if (requestObject.IsSetPreserveDevices())
            {
                context.Writer.WriteTextString("PreserveDevices");
                context.Writer.WriteTextString(requestObject.PreserveDevices);
            }

            if (requestObject.IsSetSecurityDescriptorCopyFlags())
            {
                context.Writer.WriteTextString("SecurityDescriptorCopyFlags");
                context.Writer.WriteTextString(requestObject.SecurityDescriptorCopyFlags);
            }

            if (requestObject.IsSetTaskQueueing())
            {
                context.Writer.WriteTextString("TaskQueueing");
                context.Writer.WriteTextString(requestObject.TaskQueueing);
            }

            if (requestObject.IsSetTransferMode())
            {
                context.Writer.WriteTextString("TransferMode");
                context.Writer.WriteTextString(requestObject.TransferMode);
            }

            if (requestObject.IsSetUid())
            {
                context.Writer.WriteTextString("Uid");
                context.Writer.WriteTextString(requestObject.Uid);
            }

            if (requestObject.IsSetVerifyMode())
            {
                context.Writer.WriteTextString("VerifyMode");
                context.Writer.WriteTextString(requestObject.VerifyMode);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OptionsMarshaller Instance = new OptionsMarshaller();
    }
}
