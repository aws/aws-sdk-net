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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A subcategory of failures within a top-level failure category.
    /// </summary>
    public partial class FailureSubCategoryCluster
    {
        private int? _affectedSessionCount;
        private int? _clusterId;
        private string _description;
        private string _name;
        private List<RootCauseCluster> _rootCauses = AWSConfigs.InitializeCollections ? new List<RootCauseCluster>() : null;

        /// <summary>
        /// Gets and sets the property AffectedSessionCount. 
        /// <para>
        /// The number of sessions affected by this failure subcategory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? AffectedSessionCount
        {
            get { return this._affectedSessionCount; }
            set { this._affectedSessionCount = value; }
        }

        // Check to see if AffectedSessionCount property is set
        internal bool IsSetAffectedSessionCount()
        {
            return this._affectedSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The unique identifier of the failure subcategory cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the failure subcategory pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the failure subcategory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RootCauses. 
        /// <para>
        /// The list of root cause clusters identified within this subcategory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<RootCauseCluster> RootCauses
        {
            get { return this._rootCauses; }
            set { this._rootCauses = value; }
        }

        // Check to see if RootCauses property is set
        internal bool IsSetRootCauses()
        {
            return this._rootCauses != null && (this._rootCauses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}