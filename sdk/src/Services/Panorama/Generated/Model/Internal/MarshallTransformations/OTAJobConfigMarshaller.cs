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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Panorama.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Panorama.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OTAJobConfig Marshaller
    /// </summary>
    public class OTAJobConfigMarshaller : IRequestMarshaller<OTAJobConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OTAJobConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllowMajorVersionUpdate())
            {
                context.Writer.WritePropertyName("AllowMajorVersionUpdate");
                context.Writer.Write(requestObject.AllowMajorVersionUpdate);
            }

            if(requestObject.IsSetImageVersion())
            {
                context.Writer.WritePropertyName("ImageVersion");
                context.Writer.Write(requestObject.ImageVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OTAJobConfigMarshaller Instance = new OTAJobConfigMarshaller();

    }
}