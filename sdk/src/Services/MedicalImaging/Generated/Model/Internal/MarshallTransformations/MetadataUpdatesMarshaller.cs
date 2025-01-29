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
    /// MetadataUpdates Marshaller
    /// </summary>
    public class MetadataUpdatesMarshaller : IRequestMarshaller<MetadataUpdates, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetadataUpdates requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDICOMUpdates())
            {
                context.Writer.WritePropertyName("DICOMUpdates");
                context.Writer.WriteStartObject();

                var marshaller = DICOMUpdatesMarshaller.Instance;
                marshaller.Marshall(requestObject.DICOMUpdates, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRevertToVersionId())
            {
                context.Writer.WritePropertyName("revertToVersionId");
                context.Writer.WriteStringValue(requestObject.RevertToVersionId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetadataUpdatesMarshaller Instance = new MetadataUpdatesMarshaller();

    }
}