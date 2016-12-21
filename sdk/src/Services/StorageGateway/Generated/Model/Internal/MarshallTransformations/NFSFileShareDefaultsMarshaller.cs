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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetDirectoryMode())
            {
                context.Writer.WritePropertyName("DirectoryMode");
                context.Writer.Write(requestObject.DirectoryMode);
            }

            if(requestObject.IsSetFileMode())
            {
                context.Writer.WritePropertyName("FileMode");
                context.Writer.Write(requestObject.FileMode);
            }

            if(requestObject.IsSetGroupId())
            {
                context.Writer.WritePropertyName("GroupId");
                context.Writer.Write(requestObject.GroupId);
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.Write(requestObject.OwnerId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static NFSFileShareDefaultsMarshaller Instance = new NFSFileShareDefaultsMarshaller();

    }
}