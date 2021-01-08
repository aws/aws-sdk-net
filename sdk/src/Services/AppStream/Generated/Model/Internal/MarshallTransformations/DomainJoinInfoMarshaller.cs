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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DomainJoinInfo Marshaller
    /// </summary>       
    public class DomainJoinInfoMarshaller : IRequestMarshaller<DomainJoinInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DomainJoinInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDirectoryName())
            {
                context.Writer.WritePropertyName("DirectoryName");
                context.Writer.Write(requestObject.DirectoryName);
            }

            if(requestObject.IsSetOrganizationalUnitDistinguishedName())
            {
                context.Writer.WritePropertyName("OrganizationalUnitDistinguishedName");
                context.Writer.Write(requestObject.OrganizationalUnitDistinguishedName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DomainJoinInfoMarshaller Instance = new DomainJoinInfoMarshaller();

    }
}