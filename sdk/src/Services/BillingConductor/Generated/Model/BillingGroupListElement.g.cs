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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A representation of a billing group.
    /// </summary>
    public partial class BillingGroupListElement
    {
        /// <summary>
        /// Gets and sets the property AccountGrouping. 
        /// <para>
        /// Specifies if the billing group has automatic account association (<c>AutoAssociate</c>)
        /// enabled.
        /// </para>
        /// </summary>
        public ListBillingGroupAccountGrouping AccountGrouping { get; set; }

        /// <summary>
        /// Checks to see if the AccountGrouping property is set.
        /// </summary>
        internal bool IsSetAccountGrouping() => this.AccountGrouping != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Number (ARN) that can be used to uniquely identify the billing
        /// group.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BillingGroupType. 
        /// <para>
        ///  The type of billing group. 
        /// </para>
        /// </summary>
        public BillingGroupType BillingGroupType { get; set; }

        /// <summary>
        /// Checks to see if the BillingGroupType property is set.
        /// </summary>
        internal bool IsSetBillingGroupType() => this.BillingGroupType != null;

        /// <summary>
        /// Gets and sets the property ComputationPreference.
        /// </summary>
        public ComputationPreference ComputationPreference { get; set; }

        /// <summary>
        /// Checks to see if the ComputationPreference property is set.
        /// </summary>
        internal bool IsSetComputationPreference() => this.ComputationPreference != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the billing group was created.
        /// </para>
        /// </summary>
        public long? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the billing group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The most recent time when the billing group was modified.
        /// </para>
        /// </summary>
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the billing group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrimaryAccountId. 
        /// <para>
        /// The account ID that serves as the main account in a billing group.
        /// </para>
        /// </summary>
        public string PrimaryAccountId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryAccountId property is set.
        /// </summary>
        internal bool IsSetPrimaryAccountId() => this.PrimaryAccountId != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The number of accounts in the particular billing group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The billing group status. Only one of the valid values can be used.
        /// </para>
        /// </summary>
        public BillingGroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason why the billing group is in its current status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
