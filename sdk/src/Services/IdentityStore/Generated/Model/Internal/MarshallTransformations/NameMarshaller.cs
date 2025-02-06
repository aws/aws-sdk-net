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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityStore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityStore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Name Marshaller
    /// </summary>
    public class NameMarshaller : IRequestMarshaller<Name, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Name requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFamilyName())
            {
                context.Writer.WritePropertyName("FamilyName");
                context.Writer.WriteStringValue(requestObject.FamilyName);
            }

            if(requestObject.IsSetFormatted())
            {
                context.Writer.WritePropertyName("Formatted");
                context.Writer.WriteStringValue(requestObject.Formatted);
            }

            if(requestObject.IsSetGivenName())
            {
                context.Writer.WritePropertyName("GivenName");
                context.Writer.WriteStringValue(requestObject.GivenName);
            }

            if(requestObject.IsSetHonorificPrefix())
            {
                context.Writer.WritePropertyName("HonorificPrefix");
                context.Writer.WriteStringValue(requestObject.HonorificPrefix);
            }

            if(requestObject.IsSetHonorificSuffix())
            {
                context.Writer.WritePropertyName("HonorificSuffix");
                context.Writer.WriteStringValue(requestObject.HonorificSuffix);
            }

            if(requestObject.IsSetMiddleName())
            {
                context.Writer.WritePropertyName("MiddleName");
                context.Writer.WriteStringValue(requestObject.MiddleName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NameMarshaller Instance = new NameMarshaller();

    }
}