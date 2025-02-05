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
    /// KmsGrantConfiguration Marshaller
    /// </summary>
    public class KmsGrantConfigurationMarshaller : IRequestMarshaller<KmsGrantConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KmsGrantConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConstraints())
            {
                context.Writer.WritePropertyName("constraints");
                context.Writer.WriteStartObject();

                var marshaller = KmsGrantConstraintsMarshaller.Instance;
                marshaller.Marshall(requestObject.Constraints, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGranteePrincipal())
            {
                context.Writer.WritePropertyName("granteePrincipal");
                context.Writer.WriteStringValue(requestObject.GranteePrincipal);
            }

            if(requestObject.IsSetIssuingAccount())
            {
                context.Writer.WritePropertyName("issuingAccount");
                context.Writer.WriteStringValue(requestObject.IssuingAccount);
            }

            if(requestObject.IsSetOperations())
            {
                context.Writer.WritePropertyName("operations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOperationsListValue in requestObject.Operations)
                {
                        context.Writer.WriteStringValue(requestObjectOperationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRetiringPrincipal())
            {
                context.Writer.WritePropertyName("retiringPrincipal");
                context.Writer.WriteStringValue(requestObject.RetiringPrincipal);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KmsGrantConfigurationMarshaller Instance = new KmsGrantConfigurationMarshaller();

    }
}