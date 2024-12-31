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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The hyper pod properties of a Amazon Web Services Glue properties patch.
    /// </summary>
    public partial class HyperPodPropertiesOutput
    {
        private string _clusterArn;
        private string _clusterName;
        private HyperPodOrchestrator _orchestrator;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The cluster ARN of the hyper pod properties.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The cluster name the hyper pod properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Orchestrator. 
        /// <para>
        /// The orchestrator of the hyper pod properties.
        /// </para>
        /// </summary>
        public HyperPodOrchestrator Orchestrator
        {
            get { return this._orchestrator; }
            set { this._orchestrator = value; }
        }

        // Check to see if Orchestrator property is set
        internal bool IsSetOrchestrator()
        {
            return this._orchestrator != null;
        }

    }
}