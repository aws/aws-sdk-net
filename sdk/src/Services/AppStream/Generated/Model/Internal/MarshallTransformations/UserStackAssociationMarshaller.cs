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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UserStackAssociation Marshaller
    /// </summary>       
    public class UserStackAssociationMarshaller : IRequestMarshaller<UserStackAssociation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UserStackAssociation requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAuthenticationType())
            {
                context.Writer.WritePropertyName("AuthenticationType");
                context.Writer.Write(requestObject.AuthenticationType);
            }

            if(requestObject.IsSetSendEmailNotification())
            {
                context.Writer.WritePropertyName("SendEmailNotification");
                context.Writer.Write(requestObject.SendEmailNotification);
            }

            if(requestObject.IsSetStackName())
            {
                context.Writer.WritePropertyName("StackName");
                context.Writer.Write(requestObject.StackName);
            }

            if(requestObject.IsSetUserName())
            {
                context.Writer.WritePropertyName("UserName");
                context.Writer.Write(requestObject.UserName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static UserStackAssociationMarshaller Instance = new UserStackAssociationMarshaller();

    }
}