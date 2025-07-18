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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Contains information about a dedicated IP address that is associated with your Amazon
    /// SES account.
    /// 
    ///  
    /// <para>
    /// To learn more about requesting dedicated IP addresses, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/dedicated-ip-case.html">Requesting
    /// and Relinquishing Dedicated IP Addresses</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DedicatedIp
    {
        private string _ip;
        private string _poolName;
        private int? _warmupPercentage;
        private WarmupStatus _warmupStatus;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// An IPv4 address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the dedicated IP pool that the IP address is associated with.
        /// </para>
        /// </summary>
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

        /// <summary>
        /// Gets and sets the property WarmupPercentage. 
        /// <para>
        /// Indicates the progress of your dedicated IP warm-up:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>0-100</c> – For standard dedicated IP addresses, this shows the warm-up completion
        /// percentage. A value of 100 means the IP address is fully warmed up and ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>-1</c> – Appears for IP addresses in managed dedicated pools where Amazon SES
        /// automatically handles the warm-up process, making the percentage not applicable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? WarmupPercentage
        {
            get { return this._warmupPercentage; }
            set { this._warmupPercentage = value; }
        }

        // Check to see if WarmupPercentage property is set
        internal bool IsSetWarmupPercentage()
        {
            return this._warmupPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarmupStatus. 
        /// <para>
        /// The warm-up status of a dedicated IP address. The status can have one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> – The IP address isn't ready to use because the dedicated IP warm-up
        /// process is ongoing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DONE</c> – The dedicated IP warm-up process is complete, and the IP address is
        /// ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_APPLICABLE</c> – The warm-up status doesn't apply to this IP address. This
        /// status is used for IP addresses in managed dedicated IP pools, where Amazon SES automatically
        /// handles the warm-up process.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WarmupStatus WarmupStatus
        {
            get { return this._warmupStatus; }
            set { this._warmupStatus = value; }
        }

        // Check to see if WarmupStatus property is set
        internal bool IsSetWarmupStatus()
        {
            return this._warmupStatus != null;
        }

    }
}