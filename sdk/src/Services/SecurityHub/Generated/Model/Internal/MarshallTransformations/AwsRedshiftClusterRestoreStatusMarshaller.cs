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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsRedshiftClusterRestoreStatus Marshaller
    /// </summary>       
    public class AwsRedshiftClusterRestoreStatusMarshaller : IRequestMarshaller<AwsRedshiftClusterRestoreStatus, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRedshiftClusterRestoreStatus requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCurrentRestoreRateInMegaBytesPerSecond())
            {
                context.Writer.WritePropertyName("CurrentRestoreRateInMegaBytesPerSecond");
                context.Writer.Write(requestObject.CurrentRestoreRateInMegaBytesPerSecond);
            }

            if(requestObject.IsSetElapsedTimeInSeconds())
            {
                context.Writer.WritePropertyName("ElapsedTimeInSeconds");
                context.Writer.Write(requestObject.ElapsedTimeInSeconds);
            }

            if(requestObject.IsSetEstimatedTimeToCompletionInSeconds())
            {
                context.Writer.WritePropertyName("EstimatedTimeToCompletionInSeconds");
                context.Writer.Write(requestObject.EstimatedTimeToCompletionInSeconds);
            }

            if(requestObject.IsSetProgressInMegaBytes())
            {
                context.Writer.WritePropertyName("ProgressInMegaBytes");
                context.Writer.Write(requestObject.ProgressInMegaBytes);
            }

            if(requestObject.IsSetSnapshotSizeInMegaBytes())
            {
                context.Writer.WritePropertyName("SnapshotSizeInMegaBytes");
                context.Writer.Write(requestObject.SnapshotSizeInMegaBytes);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsRedshiftClusterRestoreStatusMarshaller Instance = new AwsRedshiftClusterRestoreStatusMarshaller();

    }
}