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
    /// OutputGroupSettings Marshaller
    /// </summary>       
    public class OutputGroupSettingsMarshaller : IRequestMarshaller<OutputGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OutputGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCmafGroupSettings())
            {
                context.Writer.WritePropertyName("cmafGroupSettings");
                context.Writer.WriteObjectStart();

                var marshaller = CmafGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CmafGroupSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDashIsoGroupSettings())
            {
                context.Writer.WritePropertyName("dashIsoGroupSettings");
                context.Writer.WriteObjectStart();

                var marshaller = DashIsoGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DashIsoGroupSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFileGroupSettings())
            {
                context.Writer.WritePropertyName("fileGroupSettings");
                context.Writer.WriteObjectStart();

                var marshaller = FileGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FileGroupSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHlsGroupSettings())
            {
                context.Writer.WritePropertyName("hlsGroupSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsGroupSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMsSmoothGroupSettings())
            {
                context.Writer.WritePropertyName("msSmoothGroupSettings");
                context.Writer.WriteObjectStart();

                var marshaller = MsSmoothGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MsSmoothGroupSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OutputGroupSettingsMarshaller Instance = new OutputGroupSettingsMarshaller();

    }
}