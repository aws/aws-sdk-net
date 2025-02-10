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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Identity Marshaller
    /// </summary>
    public class IdentityMarshaller : IRequestMarshaller<Identity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Identity requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("group");
                context.Writer.WriteStartObject();

                var marshaller = GroupIdentityMarshaller.Instance;
                marshaller.Marshall(requestObject.Group, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamRole())
            {
                context.Writer.WritePropertyName("iamRole");
                context.Writer.WriteStartObject();

                var marshaller = IAMRoleIdentityMarshaller.Instance;
                marshaller.Marshall(requestObject.IamRole, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamUser())
            {
                context.Writer.WritePropertyName("iamUser");
                context.Writer.WriteStartObject();

                var marshaller = IAMUserIdentityMarshaller.Instance;
                marshaller.Marshall(requestObject.IamUser, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("user");
                context.Writer.WriteStartObject();

                var marshaller = UserIdentityMarshaller.Instance;
                marshaller.Marshall(requestObject.User, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IdentityMarshaller Instance = new IdentityMarshaller();

    }
}