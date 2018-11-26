/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAtime())
            {
                context.Writer.WritePropertyName("Atime");
                context.Writer.Write(requestObject.Atime);
            }

            if(requestObject.IsSetBytesPerSecond())
            {
                context.Writer.WritePropertyName("BytesPerSecond");
                context.Writer.Write(requestObject.BytesPerSecond);
            }

            if(requestObject.IsSetGid())
            {
                context.Writer.WritePropertyName("Gid");
                context.Writer.Write(requestObject.Gid);
            }

            if(requestObject.IsSetMtime())
            {
                context.Writer.WritePropertyName("Mtime");
                context.Writer.Write(requestObject.Mtime);
            }

            if(requestObject.IsSetPosixPermissions())
            {
                context.Writer.WritePropertyName("PosixPermissions");
                context.Writer.Write(requestObject.PosixPermissions);
            }

            if(requestObject.IsSetPreserveDeletedFiles())
            {
                context.Writer.WritePropertyName("PreserveDeletedFiles");
                context.Writer.Write(requestObject.PreserveDeletedFiles);
            }

            if(requestObject.IsSetPreserveDevices())
            {
                context.Writer.WritePropertyName("PreserveDevices");
                context.Writer.Write(requestObject.PreserveDevices);
            }

            if(requestObject.IsSetUid())
            {
                context.Writer.WritePropertyName("Uid");
                context.Writer.Write(requestObject.Uid);
            }

            if(requestObject.IsSetVerifyMode())
            {
                context.Writer.WritePropertyName("VerifyMode");
                context.Writer.Write(requestObject.VerifyMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OptionsMarshaller Instance = new OptionsMarshaller();

    }
}