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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImpersonationRule Marshaller
    /// </summary>
    public class ImpersonationRuleMarshaller : IRequestMarshaller<ImpersonationRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImpersonationRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEffect())
            {
                context.Writer.WritePropertyName("Effect");
                context.Writer.Write(requestObject.Effect);
            }

            if(requestObject.IsSetImpersonationRuleId())
            {
                context.Writer.WritePropertyName("ImpersonationRuleId");
                context.Writer.Write(requestObject.ImpersonationRuleId);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetNotTargetUsers())
            {
                context.Writer.WritePropertyName("NotTargetUsers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNotTargetUsersListValue in requestObject.NotTargetUsers)
                {
                        context.Writer.Write(requestObjectNotTargetUsersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetUsers())
            {
                context.Writer.WritePropertyName("TargetUsers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetUsersListValue in requestObject.TargetUsers)
                {
                        context.Writer.Write(requestObjectTargetUsersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImpersonationRuleMarshaller Instance = new ImpersonationRuleMarshaller();

    }
}