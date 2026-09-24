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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.DataZone.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PolicyGrantPrincipal Marshaller
    /// </summary>
    public partial class PolicyGrantPrincipalMarshaller : IRequestMarshaller<PolicyGrantPrincipal, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(PolicyGrantPrincipal requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDomainUnit())
            {
                context.Writer.WritePropertyName("domainUnit");
                context.Writer.WriteStartObject();

                var marshaller = DomainUnitPolicyGrantPrincipalMarshaller.Instance;
                marshaller.Marshall(requestObject.DomainUnit, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("group");
                context.Writer.WriteStartObject();

                var marshaller = GroupPolicyGrantPrincipalMarshaller.Instance;
                marshaller.Marshall(requestObject.Group, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetProject())
            {
                context.Writer.WritePropertyName("project");
                context.Writer.WriteStartObject();

                var marshaller = ProjectPolicyGrantPrincipalMarshaller.Instance;
                marshaller.Marshall(requestObject.Project, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("user");
                context.Writer.WriteStartObject();

                var marshaller = UserPolicyGrantPrincipalMarshaller.Instance;
                marshaller.Marshall(requestObject.User, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static PolicyGrantPrincipalMarshaller Instance = new PolicyGrantPrincipalMarshaller();
    }
}
