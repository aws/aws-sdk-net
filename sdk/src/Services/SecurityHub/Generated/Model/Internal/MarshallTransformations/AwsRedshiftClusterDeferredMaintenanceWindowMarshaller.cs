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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsRedshiftClusterDeferredMaintenanceWindow Marshaller
    /// </summary>
    public class AwsRedshiftClusterDeferredMaintenanceWindowMarshaller : IRequestMarshaller<AwsRedshiftClusterDeferredMaintenanceWindow, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRedshiftClusterDeferredMaintenanceWindow requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeferMaintenanceEndTime())
            {
                context.Writer.WritePropertyName("DeferMaintenanceEndTime");
                context.Writer.WriteStringValue(requestObject.DeferMaintenanceEndTime);
            }

            if(requestObject.IsSetDeferMaintenanceIdentifier())
            {
                context.Writer.WritePropertyName("DeferMaintenanceIdentifier");
                context.Writer.WriteStringValue(requestObject.DeferMaintenanceIdentifier);
            }

            if(requestObject.IsSetDeferMaintenanceStartTime())
            {
                context.Writer.WritePropertyName("DeferMaintenanceStartTime");
                context.Writer.WriteStringValue(requestObject.DeferMaintenanceStartTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsRedshiftClusterDeferredMaintenanceWindowMarshaller Instance = new AwsRedshiftClusterDeferredMaintenanceWindowMarshaller();

    }
}