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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Details on a data volume from another container in the same task definition.
    /// </summary>
    public partial class VolumeFrom
    {
        private bool? _readOnly;
        private string _sourceContainer;

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// If this value is <c>true</c>, the container has read-only access to the volume. If
        /// this value is <c>false</c>, then the container can write to the volume. The default
        /// value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReadOnly
        {
            get { return this._readOnly; }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceContainer. 
        /// <para>
        /// The name of another container within the same task definition to mount volumes from.
        /// </para>
        /// </summary>
        public string SourceContainer
        {
            get { return this._sourceContainer; }
            set { this._sourceContainer = value; }
        }

        // Check to see if SourceContainer property is set
        internal bool IsSetSourceContainer()
        {
            return this._sourceContainer != null;
        }

    }
}