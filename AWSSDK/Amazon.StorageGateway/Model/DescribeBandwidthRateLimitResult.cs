/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> GatewayARN </li>
    /// <li> DescribeBandwidthRateLimitOutput$AverageDownloadRateLimitInBitsPerSec </li>
    /// <li> DescribeBandwidthRateLimitOutput$AverageDownloadRateLimitInBitsPerSec </li>
    /// 
    /// </ul>
    /// </summary>
    public class DescribeBandwidthRateLimitResult  
    {
        
        private string gatewayARN;
        private long? averageUploadRateLimitInBitsPerSec;
        private long? averageDownloadRateLimitInBitsPerSec;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        /// <summary>
        /// Sets the GatewayARN property
        /// </summary>
        /// <param name="gatewayARN">The value to set for the GatewayARN property </param>
        /// <returns>this instance</returns>
        public DescribeBandwidthRateLimitResult WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;       
        }

        /// <summary>
        /// The average upload bandwidth rate limit in bits per second. This field does not appear in the response if the upload rate limit is not set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>51200 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long AverageUploadRateLimitInBitsPerSec
        {
            get { return this.averageUploadRateLimitInBitsPerSec ?? default(long); }
            set { this.averageUploadRateLimitInBitsPerSec = value; }
        }

        /// <summary>
        /// Sets the AverageUploadRateLimitInBitsPerSec property
        /// </summary>
        /// <param name="averageUploadRateLimitInBitsPerSec">The value to set for the AverageUploadRateLimitInBitsPerSec property </param>
        /// <returns>this instance</returns>
        public DescribeBandwidthRateLimitResult WithAverageUploadRateLimitInBitsPerSec(long averageUploadRateLimitInBitsPerSec)
        {
            this.averageUploadRateLimitInBitsPerSec = averageUploadRateLimitInBitsPerSec;
            return this;
        }
            

        // Check to see if AverageUploadRateLimitInBitsPerSec property is set
        internal bool IsSetAverageUploadRateLimitInBitsPerSec()
        {
            return this.averageUploadRateLimitInBitsPerSec.HasValue;       
        }

        /// <summary>
        /// The average download bandwidth rate limit in bits per second. This field does not appear in the response if the download rate limit is not
        /// set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>102400 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long AverageDownloadRateLimitInBitsPerSec
        {
            get { return this.averageDownloadRateLimitInBitsPerSec ?? default(long); }
            set { this.averageDownloadRateLimitInBitsPerSec = value; }
        }

        /// <summary>
        /// Sets the AverageDownloadRateLimitInBitsPerSec property
        /// </summary>
        /// <param name="averageDownloadRateLimitInBitsPerSec">The value to set for the AverageDownloadRateLimitInBitsPerSec property </param>
        /// <returns>this instance</returns>
        public DescribeBandwidthRateLimitResult WithAverageDownloadRateLimitInBitsPerSec(long averageDownloadRateLimitInBitsPerSec)
        {
            this.averageDownloadRateLimitInBitsPerSec = averageDownloadRateLimitInBitsPerSec;
            return this;
        }
            

        // Check to see if AverageDownloadRateLimitInBitsPerSec property is set
        internal bool IsSetAverageDownloadRateLimitInBitsPerSec()
        {
            return this.averageDownloadRateLimitInBitsPerSec.HasValue;       
        }
    }
}
