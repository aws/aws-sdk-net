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

using Amazon.ServerlessApplicationRepository.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplicationPolicyStatement Marshaller
    /// </summary>
    public partial class ApplicationPolicyStatementMarshaller : IRequestMarshaller<ApplicationPolicyStatement, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ApplicationPolicyStatement requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("actions");
                context.Writer.WriteStartArray();
                foreach (var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteStringValue(requestObjectActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPrincipalOrgIDs())
            {
                context.Writer.WritePropertyName("principalOrgIDs");
                context.Writer.WriteStartArray();
                foreach (var requestObjectPrincipalOrgIDsListValue in requestObject.PrincipalOrgIDs)
                {
                    context.Writer.WriteStringValue(requestObjectPrincipalOrgIDsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPrincipals())
            {
                context.Writer.WritePropertyName("principals");
                context.Writer.WriteStartArray();
                foreach (var requestObjectPrincipalsListValue in requestObject.Principals)
                {
                    context.Writer.WriteStringValue(requestObjectPrincipalsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatementId())
            {
                context.Writer.WritePropertyName("statementId");
                context.Writer.WriteStringValue(requestObject.StatementId);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ApplicationPolicyStatementMarshaller Instance = new ApplicationPolicyStatementMarshaller();
    }
}
