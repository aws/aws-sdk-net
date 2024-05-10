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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FsxProtocol Marshaller
    /// </summary>
    public class FsxProtocolMarshaller : IRequestMarshaller<FsxProtocol, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FsxProtocol requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetNFS())
            {
                context.Writer.WritePropertyName("NFS");
                context.Writer.WriteObjectStart();

                var marshaller = FsxProtocolNfsMarshaller.Instance;
                marshaller.Marshall(requestObject.NFS, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSMB())
            {
                context.Writer.WritePropertyName("SMB");
                context.Writer.WriteObjectStart();

                var marshaller = FsxProtocolSmbMarshaller.Instance;
                marshaller.Marshall(requestObject.SMB, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FsxProtocolMarshaller Instance = new FsxProtocolMarshaller();

    }
}