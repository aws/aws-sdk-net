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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VerifiedPermissions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PolicyFilter Marshaller
    /// </summary>
    public class PolicyFilterMarshaller : IRequestMarshaller<PolicyFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PolicyFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPolicyTemplateId())
            {
                context.Writer.WritePropertyName("policyTemplateId");
                context.Writer.Write(requestObject.PolicyTemplateId);
            }

            if(requestObject.IsSetPolicyType())
            {
                context.Writer.WritePropertyName("policyType");
                context.Writer.Write(requestObject.PolicyType);
            }

            if(requestObject.IsSetPrincipal())
            {
                context.Writer.WritePropertyName("principal");
                context.Writer.WriteObjectStart();

                var marshaller = EntityReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.Principal, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResource())
            {
                context.Writer.WritePropertyName("resource");
                context.Writer.WriteObjectStart();

                var marshaller = EntityReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.Resource, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyFilterMarshaller Instance = new PolicyFilterMarshaller();

    }
}