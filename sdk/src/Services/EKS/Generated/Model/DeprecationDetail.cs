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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The summary information about deprecated resource usage for an insight check in the
    /// <c>UPGRADE_READINESS</c> category.
    /// </summary>
    public partial class DeprecationDetail
    {
        private List<ClientStat> _clientStats = AWSConfigs.InitializeCollections ? new List<ClientStat>() : null;
        private string _replacedWith;
        private string _startServingReplacementVersion;
        private string _stopServingVersion;
        private string _usage;

        /// <summary>
        /// Gets and sets the property ClientStats. 
        /// <para>
        /// Details about Kubernetes clients using the deprecated resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClientStat> ClientStats
        {
            get { return this._clientStats; }
            set { this._clientStats = value; }
        }

        // Check to see if ClientStats property is set
        internal bool IsSetClientStats()
        {
            return this._clientStats != null && (this._clientStats.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplacedWith. 
        /// <para>
        /// The newer version of the resource to migrate to if applicable. 
        /// </para>
        /// </summary>
        public string ReplacedWith
        {
            get { return this._replacedWith; }
            set { this._replacedWith = value; }
        }

        // Check to see if ReplacedWith property is set
        internal bool IsSetReplacedWith()
        {
            return this._replacedWith != null;
        }

        /// <summary>
        /// Gets and sets the property StartServingReplacementVersion. 
        /// <para>
        /// The version of the software where the newer resource version became available to migrate
        /// to if applicable.
        /// </para>
        /// </summary>
        public string StartServingReplacementVersion
        {
            get { return this._startServingReplacementVersion; }
            set { this._startServingReplacementVersion = value; }
        }

        // Check to see if StartServingReplacementVersion property is set
        internal bool IsSetStartServingReplacementVersion()
        {
            return this._startServingReplacementVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StopServingVersion. 
        /// <para>
        /// The version of the software where the deprecated resource version will stop being
        /// served.
        /// </para>
        /// </summary>
        public string StopServingVersion
        {
            get { return this._stopServingVersion; }
            set { this._stopServingVersion = value; }
        }

        // Check to see if StopServingVersion property is set
        internal bool IsSetStopServingVersion()
        {
            return this._stopServingVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// The deprecated version of the resource.
        /// </para>
        /// </summary>
        public string Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null;
        }

    }
}