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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Information about the progress of a pre-upgrade dry run analysis.
    /// </summary>
    public partial class DryRunProgressStatus
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The timestamp when the dry run was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property DryRunId. 
        /// <para>
        /// The unique identifier of the dry run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DryRunId { get; set; }

        /// <summary>
        /// Checks to see if the DryRunId property is set.
        /// </summary>
        internal bool IsSetDryRunId() => this.DryRunId != null;

        /// <summary>
        /// Gets and sets the property DryRunStatus. 
        /// <para>
        /// The current status of the dry run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DryRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the DryRunStatus property is set.
        /// </summary>
        internal bool IsSetDryRunStatus() => this.DryRunStatus != null;

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The timestamp when the dry run was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDate property is set.
        /// </summary>
        internal bool IsSetUpdateDate() => this.UpdateDate != null;

        /// <summary>
        /// Gets and sets the property ValidationFailures. 
        /// <para>
        /// Any validation failures that occurred as a result of the dry run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ValidationFailure> ValidationFailures { get; set; } = AWSConfigs.InitializeCollections ? new List<ValidationFailure>() : null;

        /// <summary>
        /// Checks to see if the ValidationFailures property is set.
        /// </summary>
        internal bool IsSetValidationFailures() => this.ValidationFailures != null && (this.ValidationFailures.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
