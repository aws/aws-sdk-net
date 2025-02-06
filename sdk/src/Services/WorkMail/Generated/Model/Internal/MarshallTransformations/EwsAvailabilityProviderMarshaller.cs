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
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EwsAvailabilityProvider Marshaller
    /// </summary>
    public class EwsAvailabilityProviderMarshaller : IRequestMarshaller<EwsAvailabilityProvider, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EwsAvailabilityProvider requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEwsEndpoint())
            {
                context.Writer.WritePropertyName("EwsEndpoint");
                context.Writer.WriteStringValue(requestObject.EwsEndpoint);
            }

            if(requestObject.IsSetEwsPassword())
            {
                context.Writer.WritePropertyName("EwsPassword");
                context.Writer.WriteStringValue(requestObject.EwsPassword);
            }

            if(requestObject.IsSetEwsUsername())
            {
                context.Writer.WritePropertyName("EwsUsername");
                context.Writer.WriteStringValue(requestObject.EwsUsername);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EwsAvailabilityProviderMarshaller Instance = new EwsAvailabilityProviderMarshaller();

    }
}