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
    /// CmafAdditionalManifest Marshaller
    /// </summary>       
    public class CmafAdditionalManifestMarshaller : IRequestMarshaller<CmafAdditionalManifest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CmafAdditionalManifest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetManifestNameModifier())
            {
                context.Writer.WritePropertyName("manifestNameModifier");
                context.Writer.Write(requestObject.ManifestNameModifier);
            }

            if(requestObject.IsSetSelectedOutputs())
            {
                context.Writer.WritePropertyName("selectedOutputs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSelectedOutputsListValue in requestObject.SelectedOutputs)
                {
                        context.Writer.Write(requestObjectSelectedOutputsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CmafAdditionalManifestMarshaller Instance = new CmafAdditionalManifestMarshaller();

    }
}