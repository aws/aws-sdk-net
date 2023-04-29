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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Comprehend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDataSecurityConfig Marshaller
    /// </summary>
    public class UpdateDataSecurityConfigMarshaller : IRequestMarshaller<UpdateDataSecurityConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateDataSecurityConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetModelKmsKeyId())
            {
                context.Writer.WritePropertyName("ModelKmsKeyId");
                context.Writer.Write(requestObject.ModelKmsKeyId);
            }

            if(requestObject.IsSetVolumeKmsKeyId())
            {
                context.Writer.WritePropertyName("VolumeKmsKeyId");
                context.Writer.Write(requestObject.VolumeKmsKeyId);
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteObjectStart();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateDataSecurityConfigMarshaller Instance = new UpdateDataSecurityConfigMarshaller();

    }
}