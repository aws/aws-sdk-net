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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// A container for account-level settings in AWS Device Farm.
    /// </summary>
    public partial class AccountSettings
    {
        private string _awsAccountNumber;
        private int? _defaultJobTimeoutMinutes;
        private int? _maxJobTimeoutMinutes;
        private Dictionary<string, int> _maxSlots = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private bool? _skipAppResign;
        private TrialMinutes _trialMinutes;
        private Dictionary<string, int> _unmeteredDevices = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private Dictionary<string, int> _unmeteredRemoteAccessDevices = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountNumber. 
        /// <para>
        /// The AWS account number specified in the <c>AccountSettings</c> container.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
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
        /// The default number of minutes (at the account level) a test run executes before it
        /// times out. The default value is 150 minutes.
        /// </para>
        /// </summary>
        public int? DefaultJobTimeoutMinutes
        {
            get { return this._defaultJobTimeoutMinutes; }
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
        /// The maximum number of minutes a test run executes before it times out.
        /// </para>
        /// </summary>
        public int? MaxJobTimeoutMinutes
        {
            get { return this._maxJobTimeoutMinutes; }
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
        /// is expressed as an <c>offering-id:number</c> pair, where the <c>offering-id</c> represents
        /// one of the IDs returned by the <c>ListOfferings</c> command.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> MaxSlots
        {
            get { return this._maxSlots; }
            set { this._maxSlots = value; }
        }

        // Check to see if MaxSlots property is set
        internal bool IsSetMaxSlots()
        {
            return this._maxSlots != null && (this._maxSlots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SkipAppResign. 
        /// <para>
        /// When set to <c>true</c>, for private devices, Device Farm does not sign your app again.
        /// For public devices, Device Farm always signs your apps again.
        /// </para>
        ///  
        /// <para>
        /// For more information about how Device Farm re-signs your apps, see <a href="http://aws.amazon.com/device-farm/faqs/">Do
        /// you modify my app?</a> in the <i>AWS Device Farm FAQs</i>.
        /// </para>
        /// </summary>
        public bool? SkipAppResign
        {
            get { return this._skipAppResign; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> UnmeteredDevices
        {
            get { return this._unmeteredDevices; }
            set { this._unmeteredDevices = value; }
        }

        // Check to see if UnmeteredDevices property is set
        internal bool IsSetUnmeteredDevices()
        {
            return this._unmeteredDevices != null && (this._unmeteredDevices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnmeteredRemoteAccessDevices. 
        /// <para>
        /// Returns the unmetered remote access devices you have purchased or want to purchase.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> UnmeteredRemoteAccessDevices
        {
            get { return this._unmeteredRemoteAccessDevices; }
            set { this._unmeteredRemoteAccessDevices = value; }
        }

        // Check to see if UnmeteredRemoteAccessDevices property is set
        internal bool IsSetUnmeteredRemoteAccessDevices()
        {
            return this._unmeteredRemoteAccessDevices != null && (this._unmeteredRemoteAccessDevices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}