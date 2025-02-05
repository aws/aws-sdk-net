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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NFSFileShareDefaults Marshaller
    /// </summary>
    public class NFSFileShareDefaultsMarshaller : IRequestMarshaller<NFSFileShareDefaults, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NFSFileShareDefaults requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDirectoryMode())
            {
                context.Writer.WritePropertyName("DirectoryMode");
                context.Writer.WriteStringValue(requestObject.DirectoryMode);
            }

            if(requestObject.IsSetFileMode())
            {
                context.Writer.WritePropertyName("FileMode");
                context.Writer.WriteStringValue(requestObject.FileMode);
            }

            if(requestObject.IsSetGroupId())
            {
                context.Writer.WritePropertyName("GroupId");
                context.Writer.WriteNumberValue(requestObject.GroupId.Value);
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.WriteNumberValue(requestObject.OwnerId.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NFSFileShareDefaultsMarshaller Instance = new NFSFileShareDefaultsMarshaller();

    }
}