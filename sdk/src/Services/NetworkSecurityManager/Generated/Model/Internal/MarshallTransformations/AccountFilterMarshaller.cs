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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkSecurityManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkSecurityManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AccountFilter Marshaller
    /// </summary>
    public class AccountFilterMarshaller : IRequestMarshaller<AccountFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AccountFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExclude())
            {
                context.Writer.WritePropertyName("exclude");
                context.Writer.WriteStartObject();

                var marshaller = AccountSetMarshaller.Instance;
                marshaller.Marshall(requestObject.Exclude, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInclude())
            {
                context.Writer.WritePropertyName("include");
                context.Writer.WriteStartObject();

                var marshaller = AccountSetMarshaller.Instance;
                marshaller.Marshall(requestObject.Include, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIncludeAll())
            {
                context.Writer.WritePropertyName("includeAll");
                context.Writer.WriteStartObject();

                var marshaller = UnitMarshaller.Instance;
                marshaller.Marshall(requestObject.IncludeAll, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AccountFilterMarshaller Instance = new AccountFilterMarshaller();

    }
}