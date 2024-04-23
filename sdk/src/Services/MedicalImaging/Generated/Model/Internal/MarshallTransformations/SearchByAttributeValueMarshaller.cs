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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.CreatedAt);
            }

            if(requestObject.IsSetDICOMAccessionNumber())
            {
                context.Writer.WritePropertyName("DICOMAccessionNumber");
                context.Writer.Write(requestObject.DICOMAccessionNumber);
            }

            if(requestObject.IsSetDICOMPatientId())
            {
                context.Writer.WritePropertyName("DICOMPatientId");
                context.Writer.Write(requestObject.DICOMPatientId);
            }

            if(requestObject.IsSetDICOMSeriesInstanceUID())
            {
                context.Writer.WritePropertyName("DICOMSeriesInstanceUID");
                context.Writer.Write(requestObject.DICOMSeriesInstanceUID);
            }

            if(requestObject.IsSetDICOMStudyDateAndTime())
            {
                context.Writer.WritePropertyName("DICOMStudyDateAndTime");
                context.Writer.WriteObjectStart();

                var marshaller = DICOMStudyDateAndTimeMarshaller.Instance;
                marshaller.Marshall(requestObject.DICOMStudyDateAndTime, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDICOMStudyId())
            {
                context.Writer.WritePropertyName("DICOMStudyId");
                context.Writer.Write(requestObject.DICOMStudyId);
            }

            if(requestObject.IsSetDICOMStudyInstanceUID())
            {
                context.Writer.WritePropertyName("DICOMStudyInstanceUID");
                context.Writer.Write(requestObject.DICOMStudyInstanceUID);
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("updatedAt");
                context.Writer.Write(requestObject.UpdatedAt);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchByAttributeValueMarshaller Instance = new SearchByAttributeValueMarshaller();

    }
}
#pragma warning restore CS0612,CS0618