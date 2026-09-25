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
    /// Container for the parameters to the UpdateBillingGroup operation. This updates an
    /// existing billing group.
    /// </summary>
    public partial class UpdateBillingGroupRequest : AmazonBillingConductorRequest
    {
        /// <summary>
        /// Gets and sets the property AccountGrouping. 
        /// <para>
        /// Specifies if the billing group has automatic account association (<c>AutoAssociate</c>)
        /// enabled.
        /// </para>
        /// </summary>
        public UpdateBillingGroupAccountGrouping AccountGrouping { get; set; }

        /// <summary>
        /// Checks to see if the AccountGrouping property is set.
        /// </summary>
        internal bool IsSetAccountGrouping() => this.AccountGrouping != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the billing group being updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ComputationPreference. 
        /// <para>
        ///  The preferences and settings that will be used to compute the Amazon Web Services
        /// charges for a billing group. 
        /// </para>
        /// </summary>
        public ComputationPreference ComputationPreference { get; set; }

        /// <summary>
        /// Checks to see if the ComputationPreference property is set.
        /// </summary>
        internal bool IsSetComputationPreference() => this.ComputationPreference != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the billing group. The names must be unique to each billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the billing group. Only one of the valid values can be used. 
        /// </para>
        /// </summary>
        public BillingGroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
