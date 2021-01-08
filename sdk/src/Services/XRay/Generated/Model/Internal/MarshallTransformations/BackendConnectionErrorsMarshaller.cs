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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BackendConnectionErrors Marshaller
    /// </summary>       
    public class BackendConnectionErrorsMarshaller : IRequestMarshaller<BackendConnectionErrors, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BackendConnectionErrors requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConnectionRefusedCount())
            {
                context.Writer.WritePropertyName("ConnectionRefusedCount");
                context.Writer.Write(requestObject.ConnectionRefusedCount);
            }

            if(requestObject.IsSetHTTPCode4XXCount())
            {
                context.Writer.WritePropertyName("HTTPCode4XXCount");
                context.Writer.Write(requestObject.HTTPCode4XXCount);
            }

            if(requestObject.IsSetHTTPCode5XXCount())
            {
                context.Writer.WritePropertyName("HTTPCode5XXCount");
                context.Writer.Write(requestObject.HTTPCode5XXCount);
            }

            if(requestObject.IsSetOtherCount())
            {
                context.Writer.WritePropertyName("OtherCount");
                context.Writer.Write(requestObject.OtherCount);
            }

            if(requestObject.IsSetTimeoutCount())
            {
                context.Writer.WritePropertyName("TimeoutCount");
                context.Writer.Write(requestObject.TimeoutCount);
            }

            if(requestObject.IsSetUnknownHostCount())
            {
                context.Writer.WritePropertyName("UnknownHostCount");
                context.Writer.Write(requestObject.UnknownHostCount);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BackendConnectionErrorsMarshaller Instance = new BackendConnectionErrorsMarshaller();

    }
}