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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for how instances are placed and allocated within UltraServers. This
    /// is only applicable for UltraServer capacity.
    /// </summary>
    public partial class InstancePlacementConfig
    {
        private bool? _enableMultipleJobs;
        private List<PlacementSpecification> _placementSpecifications = AWSConfigs.InitializeCollections ? new List<PlacementSpecification>() : null;

        /// <summary>
        /// Gets and sets the property EnableMultipleJobs. 
        /// <para>
        /// If set to true, allows multiple jobs to share the same UltraServer instances. If set
        /// to false, ensures this job's instances are placed on an UltraServer exclusively, with
        /// no other jobs sharing the same UltraServer. Default is false.
        /// </para>
        /// </summary>
        public bool? EnableMultipleJobs
        {
            get { return this._enableMultipleJobs; }
            set { this._enableMultipleJobs = value; }
        }

        // Check to see if EnableMultipleJobs property is set
        internal bool IsSetEnableMultipleJobs()
        {
            return this._enableMultipleJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlacementSpecifications. 
        /// <para>
        /// A list of specifications for how instances should be placed on specific UltraServers.
        /// Maximum of 10 items is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<PlacementSpecification> PlacementSpecifications
        {
            get { return this._placementSpecifications; }
            set { this._placementSpecifications = value; }
        }

        // Check to see if PlacementSpecifications property is set
        internal bool IsSetPlacementSpecifications()
        {
            return this._placementSpecifications != null && (this._placementSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}