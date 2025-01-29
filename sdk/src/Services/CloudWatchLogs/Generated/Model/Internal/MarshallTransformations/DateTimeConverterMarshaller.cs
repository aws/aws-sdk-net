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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DateTimeConverter Marshaller
    /// </summary>
    public class DateTimeConverterMarshaller : IRequestMarshaller<DateTimeConverter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DateTimeConverter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLocale())
            {
                context.Writer.WritePropertyName("locale");
                context.Writer.WriteStringValue(requestObject.Locale);
            }

            if(requestObject.IsSetMatchPatterns())
            {
                context.Writer.WritePropertyName("matchPatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMatchPatternsListValue in requestObject.MatchPatterns)
                {
                        context.Writer.WriteStringValue(requestObjectMatchPatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStringValue(requestObject.Source);
            }

            if(requestObject.IsSetSourceTimezone())
            {
                context.Writer.WritePropertyName("sourceTimezone");
                context.Writer.WriteStringValue(requestObject.SourceTimezone);
            }

            if(requestObject.IsSetTarget())
            {
                context.Writer.WritePropertyName("target");
                context.Writer.WriteStringValue(requestObject.Target);
            }

            if(requestObject.IsSetTargetFormat())
            {
                context.Writer.WritePropertyName("targetFormat");
                context.Writer.WriteStringValue(requestObject.TargetFormat);
            }

            if(requestObject.IsSetTargetTimezone())
            {
                context.Writer.WritePropertyName("targetTimezone");
                context.Writer.WriteStringValue(requestObject.TargetTimezone);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DateTimeConverterMarshaller Instance = new DateTimeConverterMarshaller();

    }
}