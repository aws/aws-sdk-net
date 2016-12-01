/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EndpointUser Marshaller
    /// </summary>       
    public class EndpointUserMarshaller : IRequestMarshaller<EndpointUser, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EndpointUser requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetUserAttributes())
            {
                context.Writer.WritePropertyName("UserAttributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectUserAttributesKvp in requestObject.UserAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectUserAttributesKvp.Key);
                    var requestObjectUserAttributesValue = requestObjectUserAttributesKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectUserAttributesValueListValue in requestObjectUserAttributesValue)
                    {
                            context.Writer.Write(requestObjectUserAttributesValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUserId())
            {
                context.Writer.WritePropertyName("UserId");
                context.Writer.Write(requestObject.UserId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EndpointUserMarshaller Instance = new EndpointUserMarshaller();

    }
}