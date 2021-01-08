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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SpekeKeyProviderCmaf Marshaller
    /// </summary>       
    public class SpekeKeyProviderCmafMarshaller : IRequestMarshaller<SpekeKeyProviderCmaf, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SpekeKeyProviderCmaf requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("certificateArn");
                context.Writer.Write(requestObject.CertificateArn);
            }

            if(requestObject.IsSetDashSignaledSystemIds())
            {
                context.Writer.WritePropertyName("dashSignaledSystemIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDashSignaledSystemIdsListValue in requestObject.DashSignaledSystemIds)
                {
                        context.Writer.Write(requestObjectDashSignaledSystemIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetHlsSignaledSystemIds())
            {
                context.Writer.WritePropertyName("hlsSignaledSystemIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHlsSignaledSystemIdsListValue in requestObject.HlsSignaledSystemIds)
                {
                        context.Writer.Write(requestObjectHlsSignaledSystemIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.Write(requestObject.ResourceId);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("url");
                context.Writer.Write(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SpekeKeyProviderCmafMarshaller Instance = new SpekeKeyProviderCmafMarshaller();

    }
}