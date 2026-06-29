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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// The scheduler configuration for updating a cluster. Use this to specify the Slurm
    /// version to upgrade to.
    /// </summary>
    public partial class UpdateSchedulerRequest
    {
        private string _version;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Slurm version to upgrade the cluster to. You can only upgrade to a newer version.
        /// For more information about supported versions and upgrade paths, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/working-with_clusters_upgrade.html">Upgrading
        /// the Slurm version on a cluster</a> in the <i>PCS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>24.05 | 24.11 | 25.05 | 25.11</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}