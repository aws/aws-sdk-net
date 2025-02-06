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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportJobRequest Marshaller
    /// </summary>
    public class ImportJobRequestMarshaller : IRequestMarshaller<ImportJobRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImportJobRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefineSegment())
            {
                context.Writer.WritePropertyName("DefineSegment");
                context.Writer.WriteBooleanValue(requestObject.DefineSegment.Value);
            }

            if(requestObject.IsSetExternalId())
            {
                context.Writer.WritePropertyName("ExternalId");
                context.Writer.WriteStringValue(requestObject.ExternalId);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.WriteStringValue(requestObject.Format);
            }

            if(requestObject.IsSetRegisterEndpoints())
            {
                context.Writer.WritePropertyName("RegisterEndpoints");
                context.Writer.WriteBooleanValue(requestObject.RegisterEndpoints.Value);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetS3Url())
            {
                context.Writer.WritePropertyName("S3Url");
                context.Writer.WriteStringValue(requestObject.S3Url);
            }

            if(requestObject.IsSetSegmentId())
            {
                context.Writer.WritePropertyName("SegmentId");
                context.Writer.WriteStringValue(requestObject.SegmentId);
            }

            if(requestObject.IsSetSegmentName())
            {
                context.Writer.WritePropertyName("SegmentName");
                context.Writer.WriteStringValue(requestObject.SegmentName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImportJobRequestMarshaller Instance = new ImportJobRequestMarshaller();

    }
}