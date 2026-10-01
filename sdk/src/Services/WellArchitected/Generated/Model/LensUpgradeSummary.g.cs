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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Lens upgrade summary return object.
    /// </summary>
    public partial class LensUpgradeSummary
    {
        /// <summary>
        /// Gets and sets the property CurrentLensVersion. 
        /// <para>
        /// The current version of the lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string CurrentLensVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentLensVersion property is set.
        /// </summary>
        internal bool IsSetCurrentLensVersion() => this.CurrentLensVersion != null;

        /// <summary>
        /// Gets and sets the property LatestLensVersion. 
        /// <para>
        /// The latest version of the lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string LatestLensVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestLensVersion property is set.
        /// </summary>
        internal bool IsSetLatestLensVersion() => this.LatestLensVersion != null;

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LensAlias { get; set; }

        /// <summary>
        /// Checks to see if the LensAlias property is set.
        /// </summary>
        internal bool IsSetLensAlias() => this.LensAlias != null;

        /// <summary>
        /// Gets and sets the property LensArn. 
        /// <para>
        /// The ARN for the lens.
        /// </para>
        /// </summary>
        public string LensArn { get; set; }

        /// <summary>
        /// Checks to see if the LensArn property is set.
        /// </summary>
        internal bool IsSetLensArn() => this.LensArn != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  <c>ResourceArn</c> of the lens being upgraded
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 250)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceName.
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
