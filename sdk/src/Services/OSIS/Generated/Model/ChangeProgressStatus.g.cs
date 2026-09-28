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

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// The progress details of a pipeline configuration change.
    /// </summary>
    public partial class ChangeProgressStatus
    {
        /// <summary>
        /// Gets and sets the property ChangeProgressStages. 
        /// <para>
        /// Information about the stages that the pipeline is going through to perform the configuration
        /// change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChangeProgressStage> ChangeProgressStages { get; set; } = AWSConfigs.InitializeCollections ? new List<ChangeProgressStage>() : null;

        /// <summary>
        /// Checks to see if the ChangeProgressStages property is set.
        /// </summary>
        internal bool IsSetChangeProgressStages() => this.ChangeProgressStages != null && (this.ChangeProgressStages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the configuration change is made on the pipeline.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The overall status of the pipeline configuration change.
        /// </para>
        /// </summary>
        public ChangeProgressStatuses Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalNumberOfStages. 
        /// <para>
        /// The total number of stages required for the pipeline configuration change.
        /// </para>
        /// </summary>
        public int? TotalNumberOfStages { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfStages property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfStages() => this.TotalNumberOfStages.HasValue;
    }
}
