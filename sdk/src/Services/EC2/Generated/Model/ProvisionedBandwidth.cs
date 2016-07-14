/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Reserved. If you need to sustain traffic greater than the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">documented
    /// limits</a>, contact us through the <a href="https://console.aws.amazon.com/support/home?">Support
    /// Center</a>.
    /// </summary>
    public partial class ProvisionedBandwidth
    {
        private string _provisioned;
        private DateTime? _provisionTime;
        private string _requested;
        private DateTime? _requestTime;
        private string _status;

        /// <summary>
        /// Gets and sets the property Provisioned. 
        /// <para>
        /// Reserved. If you need to sustain traffic greater than the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">documented
        /// limits</a>, contact us through the <a href="https://console.aws.amazon.com/support/home?">Support
        /// Center</a>.
        /// </para>
        /// </summary>
        public string Provisioned
        {
            get { return this._provisioned; }
            set { this._provisioned = value; }
        }

        // Check to see if Provisioned property is set
        internal bool IsSetProvisioned()
        {
            return this._provisioned != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionTime. 
        /// <para>
        /// Reserved. If you need to sustain traffic greater than the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">documented
        /// limits</a>, contact us through the <a href="https://console.aws.amazon.com/support/home?">Support
        /// Center</a>.
        /// </para>
        /// </summary>
        public DateTime ProvisionTime
        {
            get { return this._provisionTime.GetValueOrDefault(); }
            set { this._provisionTime = value; }
        }

        // Check to see if ProvisionTime property is set
        internal bool IsSetProvisionTime()
        {
            return this._provisionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Requested. 
        /// <para>
        /// Reserved. If you need to sustain traffic greater than the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">documented
        /// limits</a>, contact us through the <a href="https://console.aws.amazon.com/support/home?">Support
        /// Center</a>.
        /// </para>
        /// </summary>
        public string Requested
        {
            get { return this._requested; }
            set { this._requested = value; }
        }

        // Check to see if Requested property is set
        internal bool IsSetRequested()
        {
            return this._requested != null;
        }

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// Reserved. If you need to sustain traffic greater than the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">documented
        /// limits</a>, contact us through the <a href="https://console.aws.amazon.com/support/home?">Support
        /// Center</a>.
        /// </para>
        /// </summary>
        public DateTime RequestTime
        {
            get { return this._requestTime.GetValueOrDefault(); }
            set { this._requestTime = value; }
        }

        // Check to see if RequestTime property is set
        internal bool IsSetRequestTime()
        {
            return this._requestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Reserved. If you need to sustain traffic greater than the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">documented
        /// limits</a>, contact us through the <a href="https://console.aws.amazon.com/support/home?">Support
        /// Center</a>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}