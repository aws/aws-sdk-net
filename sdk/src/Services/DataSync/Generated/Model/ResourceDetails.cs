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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Information provided by DataSync Discovery about the resources in your on-premises
    /// storage system.
    /// </summary>
    public partial class ResourceDetails
    {
        private List<NetAppONTAPCluster> _netAppONTAPClusters = new List<NetAppONTAPCluster>();
        private List<NetAppONTAPSVM> _netAppONTAPSVMs = new List<NetAppONTAPSVM>();
        private List<NetAppONTAPVolume> _netAppONTAPVolumes = new List<NetAppONTAPVolume>();

        /// <summary>
        /// Gets and sets the property NetAppONTAPClusters. 
        /// <para>
        /// The information that DataSync Discovery collects about the cluster in your on-premises
        /// storage system.
        /// </para>
        /// </summary>
        public List<NetAppONTAPCluster> NetAppONTAPClusters
        {
            get { return this._netAppONTAPClusters; }
            set { this._netAppONTAPClusters = value; }
        }

        // Check to see if NetAppONTAPClusters property is set
        internal bool IsSetNetAppONTAPClusters()
        {
            return this._netAppONTAPClusters != null && this._netAppONTAPClusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetAppONTAPSVMs. 
        /// <para>
        /// The information that DataSync Discovery collects about storage virtual machines (SVMs)
        /// in your on-premises storage system.
        /// </para>
        /// </summary>
        public List<NetAppONTAPSVM> NetAppONTAPSVMs
        {
            get { return this._netAppONTAPSVMs; }
            set { this._netAppONTAPSVMs = value; }
        }

        // Check to see if NetAppONTAPSVMs property is set
        internal bool IsSetNetAppONTAPSVMs()
        {
            return this._netAppONTAPSVMs != null && this._netAppONTAPSVMs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetAppONTAPVolumes. 
        /// <para>
        /// The information that DataSync Discovery collects about volumes in your on-premises
        /// storage system.
        /// </para>
        /// </summary>
        public List<NetAppONTAPVolume> NetAppONTAPVolumes
        {
            get { return this._netAppONTAPVolumes; }
            set { this._netAppONTAPVolumes = value; }
        }

        // Check to see if NetAppONTAPVolumes property is set
        internal bool IsSetNetAppONTAPVolumes()
        {
            return this._netAppONTAPVolumes != null && this._netAppONTAPVolumes.Count > 0; 
        }

    }
}