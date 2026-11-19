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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an Amazon Inspector vulnerability finding for an AMI.
    /// </summary>
    public partial class ImageFinding
    {
        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// The date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// when Amazon Inspector first observed the finding.
        /// </para>
        /// </summary>
        public DateTime? FirstObservedAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstObservedAt property is set.
        /// </summary>
        internal bool IsSetFirstObservedAt() => this.FirstObservedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FixAvailable. 
        /// <para>
        /// Specifies whether a fix is available for the finding. This value is <c>true</c> when
        /// Amazon Inspector reports a full or partial fix for the finding.
        /// </para>
        /// </summary>
        public bool? FixAvailable { get; set; }

        /// <summary>
        /// Checks to see if the FixAvailable property is set.
        /// </summary>
        internal bool IsSetFixAvailable() => this.FixAvailable.HasValue;

        /// <summary>
        /// Gets and sets the property Paths. 
        /// <para>
        /// The file paths in the AMI that are affected by the finding. Amazon EC2 returns up
        /// to 10 file paths for each finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Paths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Paths property is set.
        /// </summary>
        internal bool IsSetPaths() => this.Paths != null && (this.Paths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The Amazon Inspector score for the finding.
        /// </para>
        /// </summary>
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property SeverityLabel. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        ///  
        /// <para>
        /// The valid values are the following Amazon Inspector severity levels, which correspond
        /// to CVSS score ranges:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>informational</c> - CVSS score of 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>low</c> - CVSS score of 0.1 to 3.9.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>medium</c> - CVSS score of 4.0 to 6.9.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>high</c> - CVSS score of 7.0 to 8.9.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>critical</c> - CVSS score of 9.0 to 10.0.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/user/findings-understanding-severity.html#findings-understanding-package-score">Software
        /// package vulnerability severity</a> in the <i>Amazon Inspector User Guide</i>.
        /// </para>
        /// </summary>
        public SeverityLabel SeverityLabel { get; set; }

        /// <summary>
        /// Checks to see if the SeverityLabel property is set.
        /// </summary>
        internal bool IsSetSeverityLabel() => this.SeverityLabel != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the Amazon EBS snapshot of the AMI in which the finding was detected.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the finding.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in the ISO 8601 format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ),
        /// when Amazon Inspector last updated the finding.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
