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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Lens upgrade summary return object.
    /// </summary>
    public partial class LensUpgradeSummary
    {
        private string _currentLensVersion;
        private string _latestLensVersion;
        private string _lensAlias;
        private string _workloadId;
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property CurrentLensVersion. 
        /// <para>
        /// The current version of the lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string CurrentLensVersion
        {
            get { return this._currentLensVersion; }
            set { this._currentLensVersion = value; }
        }

        // Check to see if CurrentLensVersion property is set
        internal bool IsSetCurrentLensVersion()
        {
            return this._currentLensVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LatestLensVersion. 
        /// <para>
        /// The latest version of the lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LatestLensVersion
        {
            get { return this._latestLensVersion; }
            set { this._latestLensVersion = value; }
        }

        // Check to see if LatestLensVersion property is set
        internal bool IsSetLatestLensVersion()
        {
            return this._latestLensVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string LensAlias
        {
            get { return this._lensAlias; }
            set { this._lensAlias = value; }
        }

        // Check to see if LensAlias property is set
        internal bool IsSetLensAlias()
        {
            return this._lensAlias != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string WorkloadName
        {
            get { return this._workloadName; }
            set { this._workloadName = value; }
        }

        // Check to see if WorkloadName property is set
        internal bool IsSetWorkloadName()
        {
            return this._workloadName != null;
        }

    }
}