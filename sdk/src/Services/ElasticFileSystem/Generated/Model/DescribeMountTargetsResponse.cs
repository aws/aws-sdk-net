/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeMountTargetsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<MountTargetDescription> _mountTargets = new List<MountTargetDescription>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the request included the <code>Marker</code>, the response returns that value in
        /// this field.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MountTargets. 
        /// <para>
        /// Returns the file system's mount targets as an array of <code>MountTargetDescription</code>
        /// objects.
        /// </para>
        /// </summary>
        public List<MountTargetDescription> MountTargets
        {
            get { return this._mountTargets; }
            set { this._mountTargets = value; }
        }

        // Check to see if MountTargets property is set
        internal bool IsSetMountTargets()
        {
            return this._mountTargets != null && this._mountTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If a value is present, there are more mount targets to return. In a subsequent request,
        /// you can provide <code>Marker</code> in your request with this value to retrieve the
        /// next set of mount targets.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}