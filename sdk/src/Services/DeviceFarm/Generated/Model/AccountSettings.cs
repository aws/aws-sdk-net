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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// A container for account-level settings within AWS Device Farm.
    /// </summary>
    public partial class AccountSettings
    {
        private string _awsAccountNumber;
        private int? _defaultJobTimeoutMinutes;
        private int? _maxJobTimeoutMinutes;
        private Dictionary<string, int> _maxSlots = new Dictionary<string, int>();
        private bool? _skipAppResign;
        private TrialMinutes _trialMinutes;
        private Dictionary<string, int> _unmeteredDevices = new Dictionary<string, int>();
        private Dictionary<string, int> _unmeteredRemoteAccessDevices = new Dictionary<string, int>();

        /// <summary>
        /// Gets and sets the property AwsAccountNumber. 
        /// <para>
        /// The AWS account number specified in the <code>AccountSettings</code> container.
        /// </para>
        /// </summary>
        public string AwsAccountNumber
        {
            get { return this._awsAccountNumber; }
            set { this._awsAccountNumber = value; }
        }

        // Check to see if AwsAccountNumber property is set
        internal bool IsSetAwsAccountNumber()
        {
            return this._awsAccountNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultJobTimeoutMinutes. 
        /// <para>
        /// The default number of minutes (at the account level) a test run will execute before
        /// it times out. Default value is 60 minutes.
        /// </para>
        /// </summary>
        public int DefaultJobTimeoutMinutes
        {
            get { return this._defaultJobTimeoutMinutes.GetValueOrDefault(); }
            set { this._defaultJobTimeoutMinutes = value; }
        }

        // Check to see if DefaultJobTimeoutMinutes property is set
        internal bool IsSetDefaultJobTimeoutMinutes()
        {
            return this._defaultJobTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxJobTimeoutMinutes. 
        /// <para>
        /// The maximum number of minutes a test run will execute before it times out.
        /// </para>
        /// </summary>
        public int MaxJobTimeoutMinutes
        {
            get { return this._maxJobTimeoutMinutes.GetValueOrDefault(); }
            set { this._maxJobTimeoutMinutes = value; }
        }

        // Check to see if MaxJobTimeoutMinutes property is set
        internal bool IsSetMaxJobTimeoutMinutes()
        {
            return this._maxJobTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSlots. 
        /// <para>
        /// The maximum number of device slots that the AWS account can purchase. Each maximum
        /// is expressed as an <code>offering-id:number</code> pair, where the <code>offering-id</code>
        /// represents one of the IDs returned by the <code>ListOfferings</code> command.
        /// </para>
        /// </summary>
        public Dictionary<string, int> MaxSlots
        {
            get { return this._maxSlots; }
            set { this._maxSlots = value; }
        }

        // Check to see if MaxSlots property is set
        internal bool IsSetMaxSlots()
        {
            return this._maxSlots != null && this._maxSlots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SkipAppResign. 
        /// <para>
        /// When set to <code>true</code>, for private devices, Device Farm will not sign your
        /// app again. For public devices, Device Farm always signs your apps again and this parameter
        /// has no effect.
        /// </para>
        ///  
        /// <para>
        /// For more information about how Device Farm re-signs your app(s), see <a href="https://aws.amazon.com/device-farm/faq/">Do
        /// you modify my app?</a> in the <i>AWS Device Farm FAQs</i>.
        /// </para>
        /// </summary>
        public bool SkipAppResign
        {
            get { return this._skipAppResign.GetValueOrDefault(); }
            set { this._skipAppResign = value; }
        }

        // Check to see if SkipAppResign property is set
        internal bool IsSetSkipAppResign()
        {
            return this._skipAppResign.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrialMinutes. 
        /// <para>
        /// Information about an AWS account's usage of free trial device minutes.
        /// </para>
        /// </summary>
        public TrialMinutes TrialMinutes
        {
            get { return this._trialMinutes; }
            set { this._trialMinutes = value; }
        }

        // Check to see if TrialMinutes property is set
        internal bool IsSetTrialMinutes()
        {
            return this._trialMinutes != null;
        }

        /// <summary>
        /// Gets and sets the property UnmeteredDevices. 
        /// <para>
        /// Returns the unmetered devices you have purchased or want to purchase.
        /// </para>
        /// </summary>
        public Dictionary<string, int> UnmeteredDevices
        {
            get { return this._unmeteredDevices; }
            set { this._unmeteredDevices = value; }
        }

        // Check to see if UnmeteredDevices property is set
        internal bool IsSetUnmeteredDevices()
        {
            return this._unmeteredDevices != null && this._unmeteredDevices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnmeteredRemoteAccessDevices. 
        /// <para>
        /// Returns the unmetered remote access devices you have purchased or want to purchase.
        /// </para>
        /// </summary>
        public Dictionary<string, int> UnmeteredRemoteAccessDevices
        {
            get { return this._unmeteredRemoteAccessDevices; }
            set { this._unmeteredRemoteAccessDevices = value; }
        }

        // Check to see if UnmeteredRemoteAccessDevices property is set
        internal bool IsSetUnmeteredRemoteAccessDevices()
        {
            return this._unmeteredRemoteAccessDevices != null && this._unmeteredRemoteAccessDevices.Count > 0; 
        }

    }
}