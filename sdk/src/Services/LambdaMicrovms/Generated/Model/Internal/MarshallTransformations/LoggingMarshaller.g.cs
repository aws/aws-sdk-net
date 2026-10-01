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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.LambdaMicrovms.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.LambdaMicrovms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Logging Marshaller
    /// </summary>
    public partial class LoggingMarshaller : IRequestMarshaller<Logging, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Logging requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCloudWatch())
            {
                context.Writer.WritePropertyName("cloudWatch");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLoggingMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatch, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDisabled())
            {
                context.Writer.WritePropertyName("disabled");
                context.Writer.WriteStartObject();

                var marshaller = LoggingDisabledMarshaller.Instance;
                marshaller.Marshall(requestObject.Disabled, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static LoggingMarshaller Instance = new LoggingMarshaller();
    }
}
