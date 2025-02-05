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
    /// AwsEc2VpnConnectionOptionsTunnelOptionsDetails Marshaller
    /// </summary>
    public class AwsEc2VpnConnectionOptionsTunnelOptionsDetailsMarshaller : IRequestMarshaller<AwsEc2VpnConnectionOptionsTunnelOptionsDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2VpnConnectionOptionsTunnelOptionsDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDpdTimeoutSeconds())
            {
                context.Writer.WritePropertyName("DpdTimeoutSeconds");
                context.Writer.WriteNumberValue(requestObject.DpdTimeoutSeconds.Value);
            }

            if(requestObject.IsSetIkeVersions())
            {
                context.Writer.WritePropertyName("IkeVersions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIkeVersionsListValue in requestObject.IkeVersions)
                {
                        context.Writer.WriteStringValue(requestObjectIkeVersionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOutsideIpAddress())
            {
                context.Writer.WritePropertyName("OutsideIpAddress");
                context.Writer.WriteStringValue(requestObject.OutsideIpAddress);
            }

            if(requestObject.IsSetPhase1DhGroupNumbers())
            {
                context.Writer.WritePropertyName("Phase1DhGroupNumbers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhase1DhGroupNumbersListValue in requestObject.Phase1DhGroupNumbers)
                {
                        context.Writer.WriteNumberValue(requestObjectPhase1DhGroupNumbersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPhase1EncryptionAlgorithms())
            {
                context.Writer.WritePropertyName("Phase1EncryptionAlgorithms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhase1EncryptionAlgorithmsListValue in requestObject.Phase1EncryptionAlgorithms)
                {
                        context.Writer.WriteStringValue(requestObjectPhase1EncryptionAlgorithmsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPhase1IntegrityAlgorithms())
            {
                context.Writer.WritePropertyName("Phase1IntegrityAlgorithms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhase1IntegrityAlgorithmsListValue in requestObject.Phase1IntegrityAlgorithms)
                {
                        context.Writer.WriteStringValue(requestObjectPhase1IntegrityAlgorithmsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPhase1LifetimeSeconds())
            {
                context.Writer.WritePropertyName("Phase1LifetimeSeconds");
                context.Writer.WriteNumberValue(requestObject.Phase1LifetimeSeconds.Value);
            }

            if(requestObject.IsSetPhase2DhGroupNumbers())
            {
                context.Writer.WritePropertyName("Phase2DhGroupNumbers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhase2DhGroupNumbersListValue in requestObject.Phase2DhGroupNumbers)
                {
                        context.Writer.WriteNumberValue(requestObjectPhase2DhGroupNumbersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPhase2EncryptionAlgorithms())
            {
                context.Writer.WritePropertyName("Phase2EncryptionAlgorithms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhase2EncryptionAlgorithmsListValue in requestObject.Phase2EncryptionAlgorithms)
                {
                        context.Writer.WriteStringValue(requestObjectPhase2EncryptionAlgorithmsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPhase2IntegrityAlgorithms())
            {
                context.Writer.WritePropertyName("Phase2IntegrityAlgorithms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhase2IntegrityAlgorithmsListValue in requestObject.Phase2IntegrityAlgorithms)
                {
                        context.Writer.WriteStringValue(requestObjectPhase2IntegrityAlgorithmsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPhase2LifetimeSeconds())
            {
                context.Writer.WritePropertyName("Phase2LifetimeSeconds");
                context.Writer.WriteNumberValue(requestObject.Phase2LifetimeSeconds.Value);
            }

            if(requestObject.IsSetPreSharedKey())
            {
                context.Writer.WritePropertyName("PreSharedKey");
                context.Writer.WriteStringValue(requestObject.PreSharedKey);
            }

            if(requestObject.IsSetRekeyFuzzPercentage())
            {
                context.Writer.WritePropertyName("RekeyFuzzPercentage");
                context.Writer.WriteNumberValue(requestObject.RekeyFuzzPercentage.Value);
            }

            if(requestObject.IsSetRekeyMarginTimeSeconds())
            {
                context.Writer.WritePropertyName("RekeyMarginTimeSeconds");
                context.Writer.WriteNumberValue(requestObject.RekeyMarginTimeSeconds.Value);
            }

            if(requestObject.IsSetReplayWindowSize())
            {
                context.Writer.WritePropertyName("ReplayWindowSize");
                context.Writer.WriteNumberValue(requestObject.ReplayWindowSize.Value);
            }

            if(requestObject.IsSetTunnelInsideCidr())
            {
                context.Writer.WritePropertyName("TunnelInsideCidr");
                context.Writer.WriteStringValue(requestObject.TunnelInsideCidr);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2VpnConnectionOptionsTunnelOptionsDetailsMarshaller Instance = new AwsEc2VpnConnectionOptionsTunnelOptionsDetailsMarshaller();

    }
}