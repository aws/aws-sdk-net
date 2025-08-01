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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MedicalImaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MedicalImaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchByAttributeValue Marshaller
    /// </summary>
    public class SearchByAttributeValueMarshaller : IRequestMarshaller<SearchByAttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SearchByAttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("createdAt");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.CreatedAt.Value)));
            }

            if(requestObject.IsSetDICOMAccessionNumber())
            {
                context.Writer.WritePropertyName("DICOMAccessionNumber");
                context.Writer.WriteStringValue(requestObject.DICOMAccessionNumber);
            }

            if(requestObject.IsSetDICOMPatientId())
            {
                context.Writer.WritePropertyName("DICOMPatientId");
                context.Writer.WriteStringValue(requestObject.DICOMPatientId);
            }

            if(requestObject.IsSetDICOMSeriesInstanceUID())
            {
                context.Writer.WritePropertyName("DICOMSeriesInstanceUID");
                context.Writer.WriteStringValue(requestObject.DICOMSeriesInstanceUID);
            }

            if(requestObject.IsSetDICOMStudyDateAndTime())
            {
                context.Writer.WritePropertyName("DICOMStudyDateAndTime");
                context.Writer.WriteStartObject();

                var marshaller = DICOMStudyDateAndTimeMarshaller.Instance;
                marshaller.Marshall(requestObject.DICOMStudyDateAndTime, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDICOMStudyId())
            {
                context.Writer.WritePropertyName("DICOMStudyId");
                context.Writer.WriteStringValue(requestObject.DICOMStudyId);
            }

            if(requestObject.IsSetDICOMStudyInstanceUID())
            {
                context.Writer.WritePropertyName("DICOMStudyInstanceUID");
                context.Writer.WriteStringValue(requestObject.DICOMStudyInstanceUID);
            }

            if(requestObject.IsSetIsPrimary())
            {
                context.Writer.WritePropertyName("isPrimary");
                context.Writer.WriteBooleanValue(requestObject.IsPrimary.Value);
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("updatedAt");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.UpdatedAt.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchByAttributeValueMarshaller Instance = new SearchByAttributeValueMarshaller();

    }
}