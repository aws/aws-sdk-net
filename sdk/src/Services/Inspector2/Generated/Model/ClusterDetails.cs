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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details about the task or pod in the cluster.
    /// </summary>
    public partial class ClusterDetails
    {
        private ClusterMetadata _clusterMetadata;
        private DateTime? _lastInUse;
        private long? _runningUnitCount;
        private long? _stoppedUnitCount;

        /// <summary>
        /// Gets and sets the property ClusterMetadata.
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterMetadata ClusterMetadata
        {
            get { return this._clusterMetadata; }
            set { this._clusterMetadata = value; }
        }

        // Check to see if ClusterMetadata property is set
        internal bool IsSetClusterMetadata()
        {
            return this._clusterMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property LastInUse. 
        /// <para>
        /// The last timestamp when Amazon Inspector recorded the image in use in the task or
        /// pod in the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastInUse
        {
            get { return this._lastInUse; }
            set { this._lastInUse = value; }
        }

        // Check to see if LastInUse property is set
        internal bool IsSetLastInUse()
        {
            return this._lastInUse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningUnitCount. 
        /// <para>
        /// The number of tasks or pods where an image was running on the cluster.
        /// </para>
        /// </summary>
        public long? RunningUnitCount
        {
            get { return this._runningUnitCount; }
            set { this._runningUnitCount = value; }
        }

        // Check to see if RunningUnitCount property is set
        internal bool IsSetRunningUnitCount()
        {
            return this._runningUnitCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StoppedUnitCount. 
        /// <para>
        /// The number of tasks or pods where an image was stopped on the cluster in the last
        /// 24 hours.
        /// </para>
        /// </summary>
        public long? StoppedUnitCount
        {
            get { return this._stoppedUnitCount; }
            set { this._stoppedUnitCount = value; }
        }

        // Check to see if StoppedUnitCount property is set
        internal bool IsSetStoppedUnitCount()
        {
            return this._stoppedUnitCount.HasValue; 
        }

    }
}