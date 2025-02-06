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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KmsKeyConfiguration Marshaller
    /// </summary>
    public class KmsKeyConfigurationMarshaller : IRequestMarshaller<KmsKeyConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KmsKeyConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGrants())
            {
                context.Writer.WritePropertyName("grants");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGrantsListValue in requestObject.Grants)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KmsGrantConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectGrantsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKeyPolicies())
            {
                context.Writer.WritePropertyName("keyPolicies");
                context.Writer.WriteStartObject();
                foreach (var requestObjectKeyPoliciesKvp in requestObject.KeyPolicies)
                {
                    context.Writer.WritePropertyName(requestObjectKeyPoliciesKvp.Key);
                    var requestObjectKeyPoliciesValue = requestObjectKeyPoliciesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectKeyPoliciesValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KmsKeyConfigurationMarshaller Instance = new KmsKeyConfigurationMarshaller();

    }
}