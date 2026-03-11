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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UserPhoneConfig Marshaller
    /// </summary>
    public class UserPhoneConfigMarshaller : IRequestMarshaller<UserPhoneConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UserPhoneConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAfterContactWorkTimeLimit())
            {
                context.Writer.WritePropertyName("AfterContactWorkTimeLimit");
                context.Writer.WriteNumberValue(requestObject.AfterContactWorkTimeLimit.Value);
            }

            if(requestObject.IsSetAutoAccept())
            {
                context.Writer.WritePropertyName("AutoAccept");
                context.Writer.WriteBooleanValue(requestObject.AutoAccept.Value);
            }

            if(requestObject.IsSetDeskPhoneNumber())
            {
                context.Writer.WritePropertyName("DeskPhoneNumber");
                context.Writer.WriteStringValue(requestObject.DeskPhoneNumber);
            }

            if(requestObject.IsSetPersistentConnection())
            {
                context.Writer.WritePropertyName("PersistentConnection");
                context.Writer.WriteBooleanValue(requestObject.PersistentConnection.Value);
            }

            if(requestObject.IsSetPhoneType())
            {
                context.Writer.WritePropertyName("PhoneType");
                context.Writer.WriteStringValue(requestObject.PhoneType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UserPhoneConfigMarshaller Instance = new UserPhoneConfigMarshaller();

    }
}