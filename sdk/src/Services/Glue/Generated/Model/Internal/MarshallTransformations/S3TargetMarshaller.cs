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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3Target Marshaller
    /// </summary>
    public class S3TargetMarshaller : IRequestMarshaller<S3Target, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3Target requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectionName())
            {
                context.Writer.WritePropertyName("ConnectionName");
                context.Writer.WriteStringValue(requestObject.ConnectionName);
            }

            if(requestObject.IsSetDlqEventQueueArn())
            {
                context.Writer.WritePropertyName("DlqEventQueueArn");
                context.Writer.WriteStringValue(requestObject.DlqEventQueueArn);
            }

            if(requestObject.IsSetEventQueueArn())
            {
                context.Writer.WritePropertyName("EventQueueArn");
                context.Writer.WriteStringValue(requestObject.EventQueueArn);
            }

            if(requestObject.IsSetExclusions())
            {
                context.Writer.WritePropertyName("Exclusions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExclusionsListValue in requestObject.Exclusions)
                {
                        context.Writer.WriteStringValue(requestObjectExclusionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("Path");
                context.Writer.WriteStringValue(requestObject.Path);
            }

            if(requestObject.IsSetSampleSize())
            {
                context.Writer.WritePropertyName("SampleSize");
                context.Writer.WriteNumberValue(requestObject.SampleSize.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3TargetMarshaller Instance = new S3TargetMarshaller();

    }
}