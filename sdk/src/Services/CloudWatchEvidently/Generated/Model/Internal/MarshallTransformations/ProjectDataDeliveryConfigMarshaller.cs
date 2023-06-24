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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvidently.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchEvidently.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProjectDataDeliveryConfig Marshaller
    /// </summary>
    public class ProjectDataDeliveryConfigMarshaller : IRequestMarshaller<ProjectDataDeliveryConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProjectDataDeliveryConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCloudWatchLogs())
            {
                context.Writer.WritePropertyName("cloudWatchLogs");
                context.Writer.WriteObjectStart();

                var marshaller = CloudWatchLogsDestinationConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLogs, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3Destination())
            {
                context.Writer.WritePropertyName("s3Destination");
                context.Writer.WriteObjectStart();

                var marshaller = S3DestinationConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Destination, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProjectDataDeliveryConfigMarshaller Instance = new ProjectDataDeliveryConfigMarshaller();

    }
}