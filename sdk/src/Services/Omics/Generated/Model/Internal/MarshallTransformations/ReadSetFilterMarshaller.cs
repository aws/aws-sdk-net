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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReadSetFilter Marshaller
    /// </summary>
    public class ReadSetFilterMarshaller : IRequestMarshaller<ReadSetFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReadSetFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreatedAfter())
            {
                context.Writer.WritePropertyName("createdAfter");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.CreatedAfter));
            }

            if(requestObject.IsSetCreatedBefore())
            {
                context.Writer.WritePropertyName("createdBefore");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.CreatedBefore));
            }

            if(requestObject.IsSetCreationType())
            {
                context.Writer.WritePropertyName("creationType");
                context.Writer.WriteStringValue(requestObject.CreationType);
            }

            if(requestObject.IsSetGeneratedFrom())
            {
                context.Writer.WritePropertyName("generatedFrom");
                context.Writer.WriteStringValue(requestObject.GeneratedFrom);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetReferenceArn())
            {
                context.Writer.WritePropertyName("referenceArn");
                context.Writer.WriteStringValue(requestObject.ReferenceArn);
            }

            if(requestObject.IsSetSampleId())
            {
                context.Writer.WritePropertyName("sampleId");
                context.Writer.WriteStringValue(requestObject.SampleId);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetSubjectId())
            {
                context.Writer.WritePropertyName("subjectId");
                context.Writer.WriteStringValue(requestObject.SubjectId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReadSetFilterMarshaller Instance = new ReadSetFilterMarshaller();

    }
}