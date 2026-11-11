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
    /// FsxUpdateProtocolSmb Marshaller
    /// </summary>
    public partial class FsxUpdateProtocolSmbMarshaller : IRequestMarshaller<FsxUpdateProtocolSmb, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FsxUpdateProtocolSmb requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCmkSecretConfig())
            {
                context.Writer.WriteTextString("CmkSecretConfig");
                context.Writer.WriteStartMap(null);

                var marshaller = CmkSecretConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CmkSecretConfig, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetCustomSecretConfig())
            {
                context.Writer.WriteTextString("CustomSecretConfig");
                context.Writer.WriteStartMap(null);

                var marshaller = CustomSecretConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomSecretConfig, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetDomain())
            {
                context.Writer.WriteTextString("Domain");
                context.Writer.WriteTextString(requestObject.Domain);
            }

            if (requestObject.IsSetMountOptions())
            {
                context.Writer.WriteTextString("MountOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = SmbMountOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.MountOptions, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetPassword())
            {
                context.Writer.WriteTextString("Password");
                context.Writer.WriteTextString(requestObject.Password);
            }

            if (requestObject.IsSetUser())
            {
                context.Writer.WriteTextString("User");
                context.Writer.WriteTextString(requestObject.User);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FsxUpdateProtocolSmbMarshaller Instance = new FsxUpdateProtocolSmbMarshaller();
    }
}
