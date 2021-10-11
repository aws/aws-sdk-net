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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NielsenWatermarksSettings Marshaller
    /// </summary>       
    public class NielsenWatermarksSettingsMarshaller : IRequestMarshaller<NielsenWatermarksSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NielsenWatermarksSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetNielsenCbetSettings())
            {
                context.Writer.WritePropertyName("nielsenCbetSettings");
                context.Writer.WriteObjectStart();

                var marshaller = NielsenCBETMarshaller.Instance;
                marshaller.Marshall(requestObject.NielsenCbetSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNielsenDistributionType())
            {
                context.Writer.WritePropertyName("nielsenDistributionType");
                context.Writer.Write(requestObject.NielsenDistributionType);
            }

            if(requestObject.IsSetNielsenNaesIiNwSettings())
            {
                context.Writer.WritePropertyName("nielsenNaesIiNwSettings");
                context.Writer.WriteObjectStart();

                var marshaller = NielsenNaesIiNwMarshaller.Instance;
                marshaller.Marshall(requestObject.NielsenNaesIiNwSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static NielsenWatermarksSettingsMarshaller Instance = new NielsenWatermarksSettingsMarshaller();

    }
}