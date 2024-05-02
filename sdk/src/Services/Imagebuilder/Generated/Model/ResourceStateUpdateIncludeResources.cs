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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Specifies if the lifecycle policy should apply actions to selected resources.
    /// </summary>
    public partial class ResourceStateUpdateIncludeResources
    {
        private bool? _amis;
        private bool? _containers;
        private bool? _snapshots;

        /// <summary>
        /// Gets and sets the property Amis. 
        /// <para>
        /// Specifies whether the lifecycle action should apply to distributed AMIs
        /// </para>
        /// </summary>
        public bool? Amis
        {
            get { return this._amis; }
            set { this._amis = value; }
        }

        // Check to see if Amis property is set
        internal bool IsSetAmis()
        {
            return this._amis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// Specifies whether the lifecycle action should apply to distributed containers.
        /// </para>
        /// </summary>
        public bool? Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Snapshots. 
        /// <para>
        /// Specifies whether the lifecycle action should apply to snapshots associated with distributed
        /// AMIs.
        /// </para>
        /// </summary>
        public bool? Snapshots
        {
            get { return this._snapshots; }
            set { this._snapshots = value; }
        }

        // Check to see if Snapshots property is set
        internal bool IsSetSnapshots()
        {
            return this._snapshots.HasValue; 
        }

    }
}