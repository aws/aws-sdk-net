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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// The summary information about deprecated resource usage for an insight check in the
    /// <c>UPGRADE_READINESS</c> category.
    /// </summary>
    public partial class DeprecationDetail
    {
        /// <summary>
        /// Gets and sets the property ClientStats. 
        /// <para>
        /// Details about Kubernetes clients using the deprecated resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClientStat> ClientStats { get; set; } = AWSConfigs.InitializeCollections ? new List<ClientStat>() : null;

        /// <summary>
        /// Checks to see if the ClientStats property is set.
        /// </summary>
        internal bool IsSetClientStats() => this.ClientStats != null && (this.ClientStats.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplacedWith. 
        /// <para>
        /// The newer version of the resource to migrate to if applicable. 
        /// </para>
        /// </summary>
        public string ReplacedWith { get; set; }

        /// <summary>
        /// Checks to see if the ReplacedWith property is set.
        /// </summary>
        internal bool IsSetReplacedWith() => this.ReplacedWith != null;

        /// <summary>
        /// Gets and sets the property StartServingReplacementVersion. 
        /// <para>
        /// The version of the software where the newer resource version became available to migrate
        /// to if applicable.
        /// </para>
        /// </summary>
        public string StartServingReplacementVersion { get; set; }

        /// <summary>
        /// Checks to see if the StartServingReplacementVersion property is set.
        /// </summary>
        internal bool IsSetStartServingReplacementVersion() => this.StartServingReplacementVersion != null;

        /// <summary>
        /// Gets and sets the property StopServingVersion. 
        /// <para>
        /// The version of the software where the deprecated resource version will stop being
        /// served.
        /// </para>
        /// </summary>
        public string StopServingVersion { get; set; }

        /// <summary>
        /// Checks to see if the StopServingVersion property is set.
        /// </summary>
        internal bool IsSetStopServingVersion() => this.StopServingVersion != null;

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// The deprecated version of the resource.
        /// </para>
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// Checks to see if the Usage property is set.
        /// </summary>
        internal bool IsSetUsage() => this.Usage != null;
    }
}
