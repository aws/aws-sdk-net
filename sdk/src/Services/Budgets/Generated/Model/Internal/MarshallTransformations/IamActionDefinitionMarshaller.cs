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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IamActionDefinition Marshaller
    /// </summary>       
    public class IamActionDefinitionMarshaller : IRequestMarshaller<IamActionDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IamActionDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetGroups())
            {
                context.Writer.WritePropertyName("Groups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGroupsListValue in requestObject.Groups)
                {
                        context.Writer.Write(requestObjectGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPolicyArn())
            {
                context.Writer.WritePropertyName("PolicyArn");
                context.Writer.Write(requestObject.PolicyArn);
            }

            if(requestObject.IsSetRoles())
            {
                context.Writer.WritePropertyName("Roles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRolesListValue in requestObject.Roles)
                {
                        context.Writer.Write(requestObjectRolesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUsers())
            {
                context.Writer.WritePropertyName("Users");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUsersListValue in requestObject.Users)
                {
                        context.Writer.Write(requestObjectUsersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static IamActionDefinitionMarshaller Instance = new IamActionDefinitionMarshaller();

    }
}