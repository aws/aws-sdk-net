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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Files.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.S3Files.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreationPermissions Marshaller
    /// </summary>
    public class CreationPermissionsMarshaller : IRequestMarshaller<CreationPermissions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreationPermissions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOwnerGid())
            {
                context.Writer.WritePropertyName("ownerGid");
                context.Writer.WriteNumberValue(requestObject.OwnerGid.Value);
            }

            if(requestObject.IsSetOwnerUid())
            {
                context.Writer.WritePropertyName("ownerUid");
                context.Writer.WriteNumberValue(requestObject.OwnerUid.Value);
            }

            if(requestObject.IsSetPermissions())
            {
                context.Writer.WritePropertyName("permissions");
                context.Writer.WriteStringValue(requestObject.Permissions);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreationPermissionsMarshaller Instance = new CreationPermissionsMarshaller();

    }
}