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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SnowflakeConnectorProfileProperties Marshaller
    /// </summary>
    public class SnowflakeConnectorProfilePropertiesMarshaller : IRequestMarshaller<SnowflakeConnectorProfileProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SnowflakeConnectorProfileProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountName())
            {
                context.Writer.WritePropertyName("accountName");
                context.Writer.WriteStringValue(requestObject.AccountName);
            }

            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("bucketName");
                context.Writer.WriteStringValue(requestObject.BucketName);
            }

            if(requestObject.IsSetBucketPrefix())
            {
                context.Writer.WritePropertyName("bucketPrefix");
                context.Writer.WriteStringValue(requestObject.BucketPrefix);
            }

            if(requestObject.IsSetPrivateLinkServiceName())
            {
                context.Writer.WritePropertyName("privateLinkServiceName");
                context.Writer.WriteStringValue(requestObject.PrivateLinkServiceName);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetStage())
            {
                context.Writer.WritePropertyName("stage");
                context.Writer.WriteStringValue(requestObject.Stage);
            }

            if(requestObject.IsSetWarehouse())
            {
                context.Writer.WritePropertyName("warehouse");
                context.Writer.WriteStringValue(requestObject.Warehouse);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SnowflakeConnectorProfilePropertiesMarshaller Instance = new SnowflakeConnectorProfilePropertiesMarshaller();

    }
}