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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubscribedPrincipalInput Marshaller
    /// </summary>
    public class SubscribedPrincipalInputMarshaller : IRequestMarshaller<SubscribedPrincipalInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SubscribedPrincipalInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("group");
                context.Writer.WriteObjectStart();

                var marshaller = SubscribedGroupInputMarshaller.Instance;
                marshaller.Marshall(requestObject.Group, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIam())
            {
                context.Writer.WritePropertyName("iam");
                context.Writer.WriteObjectStart();

                var marshaller = SubscribedIamPrincipalInputMarshaller.Instance;
                marshaller.Marshall(requestObject.Iam, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProject())
            {
                context.Writer.WritePropertyName("project");
                context.Writer.WriteObjectStart();

                var marshaller = SubscribedProjectInputMarshaller.Instance;
                marshaller.Marshall(requestObject.Project, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("user");
                context.Writer.WriteObjectStart();

                var marshaller = SubscribedUserInputMarshaller.Instance;
                marshaller.Marshall(requestObject.User, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SubscribedPrincipalInputMarshaller Instance = new SubscribedPrincipalInputMarshaller();

    }
}