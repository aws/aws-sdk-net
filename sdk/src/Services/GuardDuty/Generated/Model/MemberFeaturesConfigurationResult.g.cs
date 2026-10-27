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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the features for the member account.
    /// </summary>
    public partial class MemberFeaturesConfigurationResult
    {
        /// <summary>
        /// Gets and sets the property AdditionalConfiguration. 
        /// <para>
        /// Indicates the additional configuration of the feature that is configured for the member
        /// account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemberAdditionalConfigurationResult> AdditionalConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<MemberAdditionalConfigurationResult>() : null;

        /// <summary>
        /// Checks to see if the AdditionalConfiguration property is set.
        /// </summary>
        internal bool IsSetAdditionalConfiguration() => this.AdditionalConfiguration != null && (this.AdditionalConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// Indicates what manages the feature. A value of <c>GUARDDUTY_POLICY</c> means a GuardDuty
        /// policy manages the feature.
        /// </para>
        /// </summary>
        public ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Indicates the name of the feature that is enabled for the detector.
        /// </para>
        /// </summary>
        public OrgFeature Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the feature that is enabled for the detector.
        /// </para>
        /// </summary>
        public FeatureStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the feature object was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
