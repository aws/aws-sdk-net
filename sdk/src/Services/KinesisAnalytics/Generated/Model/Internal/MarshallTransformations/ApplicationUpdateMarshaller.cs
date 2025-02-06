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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplicationUpdate Marshaller
    /// </summary>
    public class ApplicationUpdateMarshaller : IRequestMarshaller<ApplicationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ApplicationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationCodeUpdate())
            {
                context.Writer.WritePropertyName("ApplicationCodeUpdate");
                context.Writer.WriteStringValue(requestObject.ApplicationCodeUpdate);
            }

            if(requestObject.IsSetCloudWatchLoggingOptionUpdates())
            {
                context.Writer.WritePropertyName("CloudWatchLoggingOptionUpdates");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCloudWatchLoggingOptionUpdatesListValue in requestObject.CloudWatchLoggingOptionUpdates)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CloudWatchLoggingOptionUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectCloudWatchLoggingOptionUpdatesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInputUpdates())
            {
                context.Writer.WritePropertyName("InputUpdates");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputUpdatesListValue in requestObject.InputUpdates)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputUpdatesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOutputUpdates())
            {
                context.Writer.WritePropertyName("OutputUpdates");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOutputUpdatesListValue in requestObject.OutputUpdates)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputUpdatesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetReferenceDataSourceUpdates())
            {
                context.Writer.WritePropertyName("ReferenceDataSourceUpdates");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReferenceDataSourceUpdatesListValue in requestObject.ReferenceDataSourceUpdates)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReferenceDataSourceUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectReferenceDataSourceUpdatesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ApplicationUpdateMarshaller Instance = new ApplicationUpdateMarshaller();

    }
}