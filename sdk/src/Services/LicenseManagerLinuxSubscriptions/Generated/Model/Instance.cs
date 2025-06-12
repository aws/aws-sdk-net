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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// Details discovered information about a running instance using Linux subscriptions.
    /// </summary>
    public partial class Instance
    {
        private string _accountID;
        private string _amiId;
        private string _dualSubscription;
        private string _instanceID;
        private string _instanceType;
        private string _lastUpdatedTime;
        private string _osVersion;
        private List<string> _productCode = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _region;
        private string _registeredWithSubscriptionProvider;
        private string _status;
        private string _subscriptionName;
        private string _subscriptionProviderCreateTime;
        private string _subscriptionProviderUpdateTime;
        private string _usageOperation;

        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// The account ID which owns the instance.
        /// </para>
        /// </summary>
        public string AccountID
        {
            get { return this._accountID; }
            set { this._accountID = value; }
        }

        // Check to see if AccountID property is set
        internal bool IsSetAccountID()
        {
            return this._accountID != null;
        }

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The AMI ID used to launch the instance.
        /// </para>
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property DualSubscription. 
        /// <para>
        /// Indicates that you have two different license subscriptions for the same software
        /// on your instance.
        /// </para>
        /// </summary>
        public string DualSubscription
        {
            get { return this._dualSubscription; }
            set { this._dualSubscription = value; }
        }

        // Check to see if DualSubscription property is set
        internal bool IsSetDualSubscription()
        {
            return this._dualSubscription != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceID. 
        /// <para>
        /// The instance ID of the resource.
        /// </para>
        /// </summary>
        public string InstanceID
        {
            get { return this._instanceID; }
            set { this._instanceID = value; }
        }

        // Check to see if InstanceID property is set
        internal bool IsSetInstanceID()
        {
            return this._instanceID != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the resource.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time in which the last discovery updated the instance details.
        /// </para>
        /// </summary>
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system software version that runs on your instance.
        /// </para>
        /// </summary>
        public string OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }

        // Check to see if OsVersion property is set
        internal bool IsSetOsVersion()
        {
            return this._osVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code for the instance. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/linux-subscriptions-usage-operation.html">Usage
        /// operation values</a> in the <i>License Manager User Guide</i> .
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null && (this._productCode.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region the instance is running in.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredWithSubscriptionProvider. 
        /// <para>
        /// Indicates that your instance uses a BYOL license subscription from a third-party Linux
        /// subscription provider that you've registered with License Manager.
        /// </para>
        /// </summary>
        public string RegisteredWithSubscriptionProvider
        {
            get { return this._registeredWithSubscriptionProvider; }
            set { this._registeredWithSubscriptionProvider = value; }
        }

        // Check to see if RegisteredWithSubscriptionProvider property is set
        internal bool IsSetRegisteredWithSubscriptionProvider()
        {
            return this._registeredWithSubscriptionProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the instance.
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

        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        /// The name of the license subscription that the instance uses.
        /// </para>
        /// </summary>
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this._subscriptionName != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionProviderCreateTime. 
        /// <para>
        /// The timestamp when you registered the third-party Linux subscription provider for
        /// the subscription that the instance uses.
        /// </para>
        /// </summary>
        public string SubscriptionProviderCreateTime
        {
            get { return this._subscriptionProviderCreateTime; }
            set { this._subscriptionProviderCreateTime = value; }
        }

        // Check to see if SubscriptionProviderCreateTime property is set
        internal bool IsSetSubscriptionProviderCreateTime()
        {
            return this._subscriptionProviderCreateTime != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionProviderUpdateTime. 
        /// <para>
        /// The timestamp from the last time that the instance synced with the registered third-party
        /// Linux subscription provider.
        /// </para>
        /// </summary>
        public string SubscriptionProviderUpdateTime
        {
            get { return this._subscriptionProviderUpdateTime; }
            set { this._subscriptionProviderUpdateTime = value; }
        }

        // Check to see if SubscriptionProviderUpdateTime property is set
        internal bool IsSetSubscriptionProviderUpdateTime()
        {
            return this._subscriptionProviderUpdateTime != null;
        }

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The usage operation of the instance. For more information, see For more information,
        /// see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/linux-subscriptions-usage-operation.html">Usage
        /// operation values</a> in the <i>License Manager User Guide</i>.
        /// </para>
        /// </summary>
        public string UsageOperation
        {
            get { return this._usageOperation; }
            set { this._usageOperation = value; }
        }

        // Check to see if UsageOperation property is set
        internal bool IsSetUsageOperation()
        {
            return this._usageOperation != null;
        }

    }
}