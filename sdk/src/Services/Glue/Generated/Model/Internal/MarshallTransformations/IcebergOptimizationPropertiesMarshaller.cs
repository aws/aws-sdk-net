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
    /// IcebergOptimizationProperties Marshaller
    /// </summary>
    public class IcebergOptimizationPropertiesMarshaller : IRequestMarshaller<IcebergOptimizationProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IcebergOptimizationProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCompaction())
            {
                context.Writer.WritePropertyName("Compaction");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCompactionKvp in requestObject.Compaction)
                {
                    context.Writer.WritePropertyName(requestObjectCompactionKvp.Key);
                    var requestObjectCompactionValue = requestObjectCompactionKvp.Value;

                        context.Writer.WriteStringValue(requestObjectCompactionValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOrphanFileDeletion())
            {
                context.Writer.WritePropertyName("OrphanFileDeletion");
                context.Writer.WriteStartObject();
                foreach (var requestObjectOrphanFileDeletionKvp in requestObject.OrphanFileDeletion)
                {
                    context.Writer.WritePropertyName(requestObjectOrphanFileDeletionKvp.Key);
                    var requestObjectOrphanFileDeletionValue = requestObjectOrphanFileDeletionKvp.Value;

                        context.Writer.WriteStringValue(requestObjectOrphanFileDeletionValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetention())
            {
                context.Writer.WritePropertyName("Retention");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRetentionKvp in requestObject.Retention)
                {
                    context.Writer.WritePropertyName(requestObjectRetentionKvp.Key);
                    var requestObjectRetentionValue = requestObjectRetentionKvp.Value;

                        context.Writer.WriteStringValue(requestObjectRetentionValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IcebergOptimizationPropertiesMarshaller Instance = new IcebergOptimizationPropertiesMarshaller();

    }
}