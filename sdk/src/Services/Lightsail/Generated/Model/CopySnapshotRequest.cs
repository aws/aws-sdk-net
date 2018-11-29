/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CopySnapshot operation.
    /// Copies an instance or disk snapshot from one AWS Region to another in Amazon Lightsail.
    /// </summary>
    public partial class CopySnapshotRequest : AmazonLightsailRequest
    {
        private RegionName _sourceRegion;
        private string _sourceSnapshotName;
        private string _targetSnapshotName;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The AWS Region where the source snapshot is located.
        /// </para>
        /// </summary>
        public RegionName SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotName. 
        /// <para>
        /// The name of the source instance or disk snapshot to be copied.
        /// </para>
        /// </summary>
        public string SourceSnapshotName
        {
            get { return this._sourceSnapshotName; }
            set { this._sourceSnapshotName = value; }
        }

        // Check to see if SourceSnapshotName property is set
        internal bool IsSetSourceSnapshotName()
        {
            return this._sourceSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetSnapshotName. 
        /// <para>
        /// The name of the new instance or disk snapshot to be created as a copy.
        /// </para>
        /// </summary>
        public string TargetSnapshotName
        {
            get { return this._targetSnapshotName; }
            set { this._targetSnapshotName = value; }
        }

        // Check to see if TargetSnapshotName property is set
        internal bool IsSetTargetSnapshotName()
        {
            return this._targetSnapshotName != null;
        }

    }
}