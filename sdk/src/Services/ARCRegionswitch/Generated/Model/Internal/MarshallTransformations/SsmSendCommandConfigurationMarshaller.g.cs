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

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SsmSendCommandConfiguration Marshaller
    /// </summary>
    public partial class SsmSendCommandConfigurationMarshaller : IRequestMarshaller<SsmSendCommandConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SsmSendCommandConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetRegionDocuments())
            {
                context.Writer.WritePropertyName("regionDocuments");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRegionDocumentsKvp in requestObject.RegionDocuments)
                {
                    context.Writer.WritePropertyName(requestObjectRegionDocumentsKvp.Key);
                    var requestObjectRegionDocumentsValue = requestObjectRegionDocumentsKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = SsmDocumentConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectRegionDocumentsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetRetryIntervalMinutes())
            {
                context.Writer.WritePropertyName("retryIntervalMinutes");
                if (StringUtils.IsSpecialFloatValue(requestObject.RetryIntervalMinutes.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.RetryIntervalMinutes.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.RetryIntervalMinutes.Value);
                }
            }

            if (requestObject.IsSetTimeoutMinutes())
            {
                context.Writer.WritePropertyName("timeoutMinutes");
                context.Writer.WriteNumberValue(requestObject.TimeoutMinutes.Value);
            }

            if (requestObject.IsSetUngraceful())
            {
                context.Writer.WritePropertyName("ungraceful");
                context.Writer.WriteStartObject();

                var marshaller = SsmSendCommandUngracefulMarshaller.Instance;
                marshaller.Marshall(requestObject.Ungraceful, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SsmSendCommandConfigurationMarshaller Instance = new SsmSendCommandConfigurationMarshaller();
    }
}
