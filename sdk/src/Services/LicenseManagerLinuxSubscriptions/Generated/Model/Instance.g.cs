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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// The account ID which owns the instance.
        /// </para>
        /// </summary>
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The AMI ID used to launch the instance.
        /// </para>
        /// </summary>
        public string AmiId { get; set; }

        /// <summary>
        /// Checks to see if the AmiId property is set.
        /// </summary>
        internal bool IsSetAmiId() => this.AmiId != null;

        /// <summary>
        /// Gets and sets the property DualSubscription. 
        /// <para>
        /// Indicates that you have two different license subscriptions for the same software
        /// on your instance.
        /// </para>
        /// </summary>
        public string DualSubscription { get; set; }

        /// <summary>
        /// Checks to see if the DualSubscription property is set.
        /// </summary>
        internal bool IsSetDualSubscription() => this.DualSubscription != null;

        /// <summary>
        /// Gets and sets the property InstanceID. 
        /// <para>
        /// The instance ID of the resource.
        /// </para>
        /// </summary>
        public string InstanceID { get; set; }

        /// <summary>
        /// Checks to see if the InstanceID property is set.
        /// </summary>
        internal bool IsSetInstanceID() => this.InstanceID != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the resource.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time in which the last discovery updated the instance details.
        /// </para>
        /// </summary>
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system software version that runs on your instance.
        /// </para>
        /// </summary>
        public string OsVersion { get; set; }

        /// <summary>
        /// Checks to see if the OsVersion property is set.
        /// </summary>
        internal bool IsSetOsVersion() => this.OsVersion != null;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code for the instance. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/linux-subscriptions-usage-operation.html">Usage
        /// operation values</a> in the <i>License Manager User Guide</i> .
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductCode { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProductCode property is set.
        /// </summary>
        internal bool IsSetProductCode() => this.ProductCode != null && (this.ProductCode.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region the instance is running in.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RegisteredWithSubscriptionProvider. 
        /// <para>
        /// Indicates that your instance uses a BYOL license subscription from a third-party Linux
        /// subscription provider that you've registered with License Manager.
        /// </para>
        /// </summary>
        public string RegisteredWithSubscriptionProvider { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredWithSubscriptionProvider property is set.
        /// </summary>
        internal bool IsSetRegisteredWithSubscriptionProvider() => this.RegisteredWithSubscriptionProvider != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the instance.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        /// The name of the license subscription that the instance uses.
        /// </para>
        /// </summary>
        public string SubscriptionName { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionName property is set.
        /// </summary>
        internal bool IsSetSubscriptionName() => this.SubscriptionName != null;

        /// <summary>
        /// Gets and sets the property SubscriptionProviderCreateTime. 
        /// <para>
        /// The timestamp when you registered the third-party Linux subscription provider for
        /// the subscription that the instance uses.
        /// </para>
        /// </summary>
        public string SubscriptionProviderCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionProviderCreateTime property is set.
        /// </summary>
        internal bool IsSetSubscriptionProviderCreateTime() => this.SubscriptionProviderCreateTime != null;

        /// <summary>
        /// Gets and sets the property SubscriptionProviderUpdateTime. 
        /// <para>
        /// The timestamp from the last time that the instance synced with the registered third-party
        /// Linux subscription provider.
        /// </para>
        /// </summary>
        public string SubscriptionProviderUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionProviderUpdateTime property is set.
        /// </summary>
        internal bool IsSetSubscriptionProviderUpdateTime() => this.SubscriptionProviderUpdateTime != null;

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The usage operation of the instance. For more information, see For more information,
        /// see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/linux-subscriptions-usage-operation.html">Usage
        /// operation values</a> in the <i>License Manager User Guide</i>.
        /// </para>
        /// </summary>
        public string UsageOperation { get; set; }

        /// <summary>
        /// Checks to see if the UsageOperation property is set.
        /// </summary>
        internal bool IsSetUsageOperation() => this.UsageOperation != null;
    }
}
