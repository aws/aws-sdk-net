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
    /// Information about the resource of the GuardDuty account.
    /// </summary>
    public partial class CoverageResource
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique ID of the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CoverageStatus. 
        /// <para>
        /// Represents the status of the EKS cluster coverage.
        /// </para>
        /// </summary>
        public CoverageStatus CoverageStatus { get; set; }

        /// <summary>
        /// Checks to see if the CoverageStatus property is set.
        /// </summary>
        internal bool IsSetCoverageStatus() => this.CoverageStatus != null;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the GuardDuty detector associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property Issue. 
        /// <para>
        /// Represents the reason why a coverage status was <c>UNHEALTHY</c> for the EKS cluster.
        /// </para>
        /// </summary>
        public string Issue { get; set; }

        /// <summary>
        /// Checks to see if the Issue property is set.
        /// </summary>
        internal bool IsSetIssue() => this.Issue != null;

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Information about the resource for which the coverage statistics are retrieved.
        /// </para>
        /// </summary>
        public CoverageResourceDetails ResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDetails property is set.
        /// </summary>
        internal bool IsSetResourceDetails() => this.ResourceDetails != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique ID of the resource.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the coverage details for the resource were last updated. This
        /// is in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
