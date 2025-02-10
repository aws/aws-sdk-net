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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AuditManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ControlMappingSource Marshaller
    /// </summary>
    public class ControlMappingSourceMarshaller : IRequestMarshaller<ControlMappingSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ControlMappingSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSourceDescription())
            {
                context.Writer.WritePropertyName("sourceDescription");
                context.Writer.WriteStringValue(requestObject.SourceDescription);
            }

            if(requestObject.IsSetSourceFrequency())
            {
                context.Writer.WritePropertyName("sourceFrequency");
                context.Writer.WriteStringValue(requestObject.SourceFrequency);
            }

            if(requestObject.IsSetSourceId())
            {
                context.Writer.WritePropertyName("sourceId");
                context.Writer.WriteStringValue(requestObject.SourceId);
            }

            if(requestObject.IsSetSourceKeyword())
            {
                context.Writer.WritePropertyName("sourceKeyword");
                context.Writer.WriteStartObject();

                var marshaller = SourceKeywordMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceKeyword, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceName())
            {
                context.Writer.WritePropertyName("sourceName");
                context.Writer.WriteStringValue(requestObject.SourceName);
            }

            if(requestObject.IsSetSourceSetUpOption())
            {
                context.Writer.WritePropertyName("sourceSetUpOption");
                context.Writer.WriteStringValue(requestObject.SourceSetUpOption);
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("sourceType");
                context.Writer.WriteStringValue(requestObject.SourceType);
            }

            if(requestObject.IsSetTroubleshootingText())
            {
                context.Writer.WritePropertyName("troubleshootingText");
                context.Writer.WriteStringValue(requestObject.TroubleshootingText);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ControlMappingSourceMarshaller Instance = new ControlMappingSourceMarshaller();

    }
}