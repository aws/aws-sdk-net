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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisVideo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletionConfig Marshaller
    /// </summary>
    public class DeletionConfigMarshaller : IRequestMarshaller<DeletionConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeletionConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeleteAfterUpload())
            {
                context.Writer.WritePropertyName("DeleteAfterUpload");
                context.Writer.WriteBooleanValue(requestObject.DeleteAfterUpload.Value);
            }

            if(requestObject.IsSetEdgeRetentionInHours())
            {
                context.Writer.WritePropertyName("EdgeRetentionInHours");
                context.Writer.WriteNumberValue(requestObject.EdgeRetentionInHours.Value);
            }

            if(requestObject.IsSetLocalSizeConfig())
            {
                context.Writer.WritePropertyName("LocalSizeConfig");
                context.Writer.WriteStartObject();

                var marshaller = LocalSizeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LocalSizeConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeletionConfigMarshaller Instance = new DeletionConfigMarshaller();

    }
}