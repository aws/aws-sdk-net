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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container distribution settings for encryption, licensing, and sharing in a specific
    /// Region.
    /// </summary>
    public partial class ContainerDistributionConfiguration
    {
        private List<string> _containerTags = new List<string>();
        private string _description;
        private TargetContainerRepository _targetRepository;

        /// <summary>
        /// Gets and sets the property ContainerTags. 
        /// <para>
        /// Tags that are attached to the container distribution configuration.
        /// </para>
        /// </summary>
        public List<string> ContainerTags
        {
            get { return this._containerTags; }
            set { this._containerTags = value; }
        }

        // Check to see if ContainerTags property is set
        internal bool IsSetContainerTags()
        {
            return this._containerTags != null && this._containerTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the container distribution configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property TargetRepository. 
        /// <para>
        /// The destination repository for the container distribution configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetContainerRepository TargetRepository
        {
            get { return this._targetRepository; }
            set { this._targetRepository = value; }
        }

        // Check to see if TargetRepository property is set
        internal bool IsSetTargetRepository()
        {
            return this._targetRepository != null;
        }

    }
}