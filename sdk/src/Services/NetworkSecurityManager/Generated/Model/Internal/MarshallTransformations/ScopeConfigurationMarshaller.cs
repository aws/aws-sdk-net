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
    /// ScopeConfiguration Marshaller
    /// </summary>
    public class ScopeConfigurationMarshaller : IRequestMarshaller<ScopeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScopeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountFilter())
            {
                context.Writer.WritePropertyName("accountFilter");
                context.Writer.WriteStartObject();

                var marshaller = AccountFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AccountFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceScopes())
            {
                context.Writer.WritePropertyName("resourceScopes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectResourceScopesKvp in requestObject.ResourceScopes)
                {
                    context.Writer.WritePropertyName(requestObjectResourceScopesKvp.Key);
                    var requestObjectResourceScopesValue = requestObjectResourceScopesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ResourceScopeMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceScopesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScopeConfigurationMarshaller Instance = new ScopeConfigurationMarshaller();

    }
}