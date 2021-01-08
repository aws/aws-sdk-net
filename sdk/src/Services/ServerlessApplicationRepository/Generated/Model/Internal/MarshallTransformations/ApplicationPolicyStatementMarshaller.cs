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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerlessApplicationRepository.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplicationPolicyStatement Marshaller
    /// </summary>       
    public class ApplicationPolicyStatementMarshaller : IRequestMarshaller<ApplicationPolicyStatement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ApplicationPolicyStatement requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("actions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                        context.Writer.Write(requestObjectActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPrincipalOrgIDs())
            {
                context.Writer.WritePropertyName("principalOrgIDs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrincipalOrgIDsListValue in requestObject.PrincipalOrgIDs)
                {
                        context.Writer.Write(requestObjectPrincipalOrgIDsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPrincipals())
            {
                context.Writer.WritePropertyName("principals");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrincipalsListValue in requestObject.Principals)
                {
                        context.Writer.Write(requestObjectPrincipalsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatementId())
            {
                context.Writer.WritePropertyName("statementId");
                context.Writer.Write(requestObject.StatementId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ApplicationPolicyStatementMarshaller Instance = new ApplicationPolicyStatementMarshaller();

    }
}