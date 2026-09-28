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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes the information about a production branch for an Amplify app.
    /// </summary>
    public partial class ProductionBranch
    {
        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The branch name for the production branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string BranchName { get; set; }

        /// <summary>
        /// Checks to see if the BranchName property is set.
        /// </summary>
        internal bool IsSetBranchName() => this.BranchName != null;

        /// <summary>
        /// Gets and sets the property LastDeployTime. 
        /// <para>
        /// The last deploy time of the production branch. 
        /// </para>
        /// </summary>
        public DateTime? LastDeployTime { get; set; }

        /// <summary>
        /// Checks to see if the LastDeployTime property is set.
        /// </summary>
        internal bool IsSetLastDeployTime() => this.LastDeployTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the production branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 7)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ThumbnailUrl. 
        /// <para>
        /// The thumbnail URL for the production branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Checks to see if the ThumbnailUrl property is set.
        /// </summary>
        internal bool IsSetThumbnailUrl() => this.ThumbnailUrl != null;
    }
}
