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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReferenceFilter Marshaller
    /// </summary>
    public class ReferenceFilterMarshaller : IRequestMarshaller<ReferenceFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReferenceFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCreatedAfter())
            {
                context.Writer.WritePropertyName("createdAfter");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601(requestObject.CreatedAfter));
            }

            if(requestObject.IsSetCreatedBefore())
            {
                context.Writer.WritePropertyName("createdBefore");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601(requestObject.CreatedBefore));
            }

            if(requestObject.IsSetMd5())
            {
                context.Writer.WritePropertyName("md5");
                context.Writer.Write(requestObject.Md5);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReferenceFilterMarshaller Instance = new ReferenceFilterMarshaller();

    }
}