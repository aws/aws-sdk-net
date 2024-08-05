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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGatewayInformation operation.
    /// Updates a gateway's metadata, which includes the gateway's name, time zone, and metadata
    /// cache size. To specify which gateway to update, use the Amazon Resource Name (ARN)
    /// of the gateway in your request.
    /// 
    ///  <note> 
    /// <para>
    /// For gateways activated after September 2, 2015, the gateway's ARN contains the gateway
    /// ID rather than the gateway name. However, changing the name of the gateway has no
    /// effect on the gateway's ARN.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateGatewayInformationRequest : AmazonStorageGatewayRequest
    {
        private string _cloudWatchLogGroupARN;
        private string _gatewayARN;
        private GatewayCapacity _gatewayCapacity;
        private string _gatewayName;
        private string _gatewayTimezone;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group that you want to
        /// use to monitor and log events in the gateway.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/WhatIsCloudWatchLogs.html">What
        /// is Amazon CloudWatch Logs?</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=562)]
        public string CloudWatchLogGroupARN
        {
            get { return this._cloudWatchLogGroupARN; }
            set { this._cloudWatchLogGroupARN = value; }
        }

        // Check to see if CloudWatchLogGroupARN property is set
        internal bool IsSetCloudWatchLogGroupARN()
        {
            return this._cloudWatchLogGroupARN != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayCapacity. 
        /// <para>
        /// Specifies the size of the gateway's metadata cache. This setting impacts gateway performance
        /// and hardware recommendations. For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/performance-multiple-file-shares.html">Performance
        /// guidance for gateways with multiple file shares</a> in the <i>Amazon S3 File Gateway
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public GatewayCapacity GatewayCapacity
        {
            get { return this._gatewayCapacity; }
            set { this._gatewayCapacity = value; }
        }

        // Check to see if GatewayCapacity property is set
        internal bool IsSetGatewayCapacity()
        {
            return this._gatewayCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayName.
        /// </summary>
        [AWSProperty(Min=2, Max=255)]
        public string GatewayName
        {
            get { return this._gatewayName; }
            set { this._gatewayName = value; }
        }

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this._gatewayName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayTimezone. 
        /// <para>
        /// A value that indicates the time zone of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=10)]
        public string GatewayTimezone
        {
            get { return this._gatewayTimezone; }
            set { this._gatewayTimezone = value; }
        }

        // Check to see if GatewayTimezone property is set
        internal bool IsSetGatewayTimezone()
        {
            return this._gatewayTimezone != null;
        }

    }
}