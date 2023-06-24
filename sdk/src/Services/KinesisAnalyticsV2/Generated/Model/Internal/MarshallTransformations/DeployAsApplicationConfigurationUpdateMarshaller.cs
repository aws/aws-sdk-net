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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeployAsApplicationConfigurationUpdate Marshaller
    /// </summary>
    public class DeployAsApplicationConfigurationUpdateMarshaller : IRequestMarshaller<DeployAsApplicationConfigurationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeployAsApplicationConfigurationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetS3ContentLocationUpdate())
            {
                context.Writer.WritePropertyName("S3ContentLocationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = S3ContentBaseLocationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.S3ContentLocationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeployAsApplicationConfigurationUpdateMarshaller Instance = new DeployAsApplicationConfigurationUpdateMarshaller();

    }
}