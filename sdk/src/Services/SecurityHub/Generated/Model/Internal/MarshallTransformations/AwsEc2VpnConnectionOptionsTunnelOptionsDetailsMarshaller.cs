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
            if(requestObject.IsSetDpdTimeoutSeconds())
            {
                context.Writer.WritePropertyName("DpdTimeoutSeconds");
                context.Writer.Write(requestObject.DpdTimeoutSeconds);
            }

            if(requestObject.IsSetIkeVersions())
            {
                context.Writer.WritePropertyName("IkeVersions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIkeVersionsListValue in requestObject.IkeVersions)
                {
                        context.Writer.Write(requestObjectIkeVersionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOutsideIpAddress())
            {
                context.Writer.WritePropertyName("OutsideIpAddress");
                context.Writer.Write(requestObject.OutsideIpAddress);
            }

            if(requestObject.IsSetPhase1DhGroupNumbers())
            {
                context.Writer.WritePropertyName("Phase1DhGroupNumbers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPhase1DhGroupNumbersListValue in requestObject.Phase1DhGroupNumbers)
                {
                        context.Writer.Write(requestObjectPhase1DhGroupNumbersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPhase1EncryptionAlgorithms())
            {
                context.Writer.WritePropertyName("Phase1EncryptionAlgorithms");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPhase1EncryptionAlgorithmsListValue in requestObject.Phase1EncryptionAlgorithms)
                {
                        context.Writer.Write(requestObjectPhase1EncryptionAlgorithmsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPhase1IntegrityAlgorithms())
            {
                context.Writer.WritePropertyName("Phase1IntegrityAlgorithms");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPhase1IntegrityAlgorithmsListValue in requestObject.Phase1IntegrityAlgorithms)
                {
                        context.Writer.Write(requestObjectPhase1IntegrityAlgorithmsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPhase1LifetimeSeconds())
            {
                context.Writer.WritePropertyName("Phase1LifetimeSeconds");
                context.Writer.Write(requestObject.Phase1LifetimeSeconds);
            }

            if(requestObject.IsSetPhase2DhGroupNumbers())
            {
                context.Writer.WritePropertyName("Phase2DhGroupNumbers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPhase2DhGroupNumbersListValue in requestObject.Phase2DhGroupNumbers)
                {
                        context.Writer.Write(requestObjectPhase2DhGroupNumbersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPhase2EncryptionAlgorithms())
            {
                context.Writer.WritePropertyName("Phase2EncryptionAlgorithms");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPhase2EncryptionAlgorithmsListValue in requestObject.Phase2EncryptionAlgorithms)
                {
                        context.Writer.Write(requestObjectPhase2EncryptionAlgorithmsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPhase2IntegrityAlgorithms())
            {
                context.Writer.WritePropertyName("Phase2IntegrityAlgorithms");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPhase2IntegrityAlgorithmsListValue in requestObject.Phase2IntegrityAlgorithms)
                {
                        context.Writer.Write(requestObjectPhase2IntegrityAlgorithmsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPhase2LifetimeSeconds())
            {
                context.Writer.WritePropertyName("Phase2LifetimeSeconds");
                context.Writer.Write(requestObject.Phase2LifetimeSeconds);
            }

            if(requestObject.IsSetPreSharedKey())
            {
                context.Writer.WritePropertyName("PreSharedKey");
                context.Writer.Write(requestObject.PreSharedKey);
            }

            if(requestObject.IsSetRekeyFuzzPercentage())
            {
                context.Writer.WritePropertyName("RekeyFuzzPercentage");
                context.Writer.Write(requestObject.RekeyFuzzPercentage);
            }

            if(requestObject.IsSetRekeyMarginTimeSeconds())
            {
                context.Writer.WritePropertyName("RekeyMarginTimeSeconds");
                context.Writer.Write(requestObject.RekeyMarginTimeSeconds);
            }

            if(requestObject.IsSetReplayWindowSize())
            {
                context.Writer.WritePropertyName("ReplayWindowSize");
                context.Writer.Write(requestObject.ReplayWindowSize);
            }

            if(requestObject.IsSetTunnelInsideCidr())
            {
                context.Writer.WritePropertyName("TunnelInsideCidr");
                context.Writer.Write(requestObject.TunnelInsideCidr);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2VpnConnectionOptionsTunnelOptionsDetailsMarshaller Instance = new AwsEc2VpnConnectionOptionsTunnelOptionsDetailsMarshaller();

    }
}