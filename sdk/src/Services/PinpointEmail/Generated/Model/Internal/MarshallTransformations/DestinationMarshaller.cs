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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Destination Marshaller
    /// </summary>       
    public class DestinationMarshaller : IRequestMarshaller<Destination, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Destination requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBccAddresses())
            {
                context.Writer.WritePropertyName("BccAddresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBccAddressesListValue in requestObject.BccAddresses)
                {
                        context.Writer.Write(requestObjectBccAddressesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCcAddresses())
            {
                context.Writer.WritePropertyName("CcAddresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCcAddressesListValue in requestObject.CcAddresses)
                {
                        context.Writer.Write(requestObjectCcAddressesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetToAddresses())
            {
                context.Writer.WritePropertyName("ToAddresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectToAddressesListValue in requestObject.ToAddresses)
                {
                        context.Writer.Write(requestObjectToAddressesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DestinationMarshaller Instance = new DestinationMarshaller();

    }
}