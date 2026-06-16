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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourcePoolSummary Marshaller
    /// </summary>
    public class ResourcePoolSummaryMarshaller : IRequestMarshaller<ResourcePoolSummary, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourcePoolSummary requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAvailableComputeCapacity())
            {
                context.Writer.WritePropertyName("availableComputeCapacity");
                context.Writer.WriteNumberValue(requestObject.AvailableComputeCapacity.Value);
            }

            if(requestObject.IsSetAvailableStorageCapacityInTBs())
            {
                context.Writer.WritePropertyName("availableStorageCapacityInTBs");
                if(StringUtils.IsSpecialDoubleValue(requestObject.AvailableStorageCapacityInTBs.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.AvailableStorageCapacityInTBs.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.AvailableStorageCapacityInTBs.Value);
                }
            }

            if(requestObject.IsSetIsDisabled())
            {
                context.Writer.WritePropertyName("isDisabled");
                context.Writer.WriteBooleanValue(requestObject.IsDisabled.Value);
            }

            if(requestObject.IsSetPoolSize())
            {
                context.Writer.WritePropertyName("poolSize");
                context.Writer.WriteNumberValue(requestObject.PoolSize.Value);
            }

            if(requestObject.IsSetPoolStorageSizeInTBs())
            {
                context.Writer.WritePropertyName("poolStorageSizeInTBs");
                context.Writer.WriteNumberValue(requestObject.PoolStorageSizeInTBs.Value);
            }

            if(requestObject.IsSetTotalComputeCapacity())
            {
                context.Writer.WritePropertyName("totalComputeCapacity");
                context.Writer.WriteNumberValue(requestObject.TotalComputeCapacity.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourcePoolSummaryMarshaller Instance = new ResourcePoolSummaryMarshaller();

    }
}