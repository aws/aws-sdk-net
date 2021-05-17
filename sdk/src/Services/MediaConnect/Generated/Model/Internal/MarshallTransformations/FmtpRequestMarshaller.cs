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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FmtpRequest Marshaller
    /// </summary>       
    public class FmtpRequestMarshaller : IRequestMarshaller<FmtpRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FmtpRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChannelOrder())
            {
                context.Writer.WritePropertyName("channelOrder");
                context.Writer.Write(requestObject.ChannelOrder);
            }

            if(requestObject.IsSetColorimetry())
            {
                context.Writer.WritePropertyName("colorimetry");
                context.Writer.Write(requestObject.Colorimetry);
            }

            if(requestObject.IsSetExactFramerate())
            {
                context.Writer.WritePropertyName("exactFramerate");
                context.Writer.Write(requestObject.ExactFramerate);
            }

            if(requestObject.IsSetPar())
            {
                context.Writer.WritePropertyName("par");
                context.Writer.Write(requestObject.Par);
            }

            if(requestObject.IsSetRange())
            {
                context.Writer.WritePropertyName("range");
                context.Writer.Write(requestObject.Range);
            }

            if(requestObject.IsSetScanMode())
            {
                context.Writer.WritePropertyName("scanMode");
                context.Writer.Write(requestObject.ScanMode);
            }

            if(requestObject.IsSetTcs())
            {
                context.Writer.WritePropertyName("tcs");
                context.Writer.Write(requestObject.Tcs);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FmtpRequestMarshaller Instance = new FmtpRequestMarshaller();

    }
}