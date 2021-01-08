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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageVod.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackageVod.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StreamSelection Marshaller
    /// </summary>       
    public class StreamSelectionMarshaller : IRequestMarshaller<StreamSelection, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StreamSelection requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMaxVideoBitsPerSecond())
            {
                context.Writer.WritePropertyName("maxVideoBitsPerSecond");
                context.Writer.Write(requestObject.MaxVideoBitsPerSecond);
            }

            if(requestObject.IsSetMinVideoBitsPerSecond())
            {
                context.Writer.WritePropertyName("minVideoBitsPerSecond");
                context.Writer.Write(requestObject.MinVideoBitsPerSecond);
            }

            if(requestObject.IsSetStreamOrder())
            {
                context.Writer.WritePropertyName("streamOrder");
                context.Writer.Write(requestObject.StreamOrder);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static StreamSelectionMarshaller Instance = new StreamSelectionMarshaller();

    }
}