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
    /// AwsEc2VpnConnectionVgwTelemetryDetails Marshaller
    /// </summary>
    public class AwsEc2VpnConnectionVgwTelemetryDetailsMarshaller : IRequestMarshaller<AwsEc2VpnConnectionVgwTelemetryDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2VpnConnectionVgwTelemetryDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcceptedRouteCount())
            {
                context.Writer.WritePropertyName("AcceptedRouteCount");
                context.Writer.WriteNumberValue(requestObject.AcceptedRouteCount.Value);
            }

            if(requestObject.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("CertificateArn");
                context.Writer.WriteStringValue(requestObject.CertificateArn);
            }

            if(requestObject.IsSetLastStatusChange())
            {
                context.Writer.WritePropertyName("LastStatusChange");
                context.Writer.WriteStringValue(requestObject.LastStatusChange);
            }

            if(requestObject.IsSetOutsideIpAddress())
            {
                context.Writer.WritePropertyName("OutsideIpAddress");
                context.Writer.WriteStringValue(requestObject.OutsideIpAddress);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetStatusMessage())
            {
                context.Writer.WritePropertyName("StatusMessage");
                context.Writer.WriteStringValue(requestObject.StatusMessage);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2VpnConnectionVgwTelemetryDetailsMarshaller Instance = new AwsEc2VpnConnectionVgwTelemetryDetailsMarshaller();

    }
}