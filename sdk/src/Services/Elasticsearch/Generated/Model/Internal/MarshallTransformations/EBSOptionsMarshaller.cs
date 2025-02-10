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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Elasticsearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EBSOptions Marshaller
    /// </summary>
    public class EBSOptionsMarshaller : IRequestMarshaller<EBSOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EBSOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEBSEnabled())
            {
                context.Writer.WritePropertyName("EBSEnabled");
                context.Writer.WriteBooleanValue(requestObject.EBSEnabled.Value);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("Iops");
                context.Writer.WriteNumberValue(requestObject.Iops.Value);
            }

            if(requestObject.IsSetThroughput())
            {
                context.Writer.WritePropertyName("Throughput");
                context.Writer.WriteNumberValue(requestObject.Throughput.Value);
            }

            if(requestObject.IsSetVolumeSize())
            {
                context.Writer.WritePropertyName("VolumeSize");
                context.Writer.WriteNumberValue(requestObject.VolumeSize.Value);
            }

            if(requestObject.IsSetVolumeType())
            {
                context.Writer.WritePropertyName("VolumeType");
                context.Writer.WriteStringValue(requestObject.VolumeType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EBSOptionsMarshaller Instance = new EBSOptionsMarshaller();

    }
}