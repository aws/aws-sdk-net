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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Defines a track that determines which Amazon Redshift version to apply after a new
    /// version is released. If the value for <c>ServerlessTrack</c> is <c>current</c>, the
    /// workgroup is updated to the most recently certified release. If the value is <c>trailing</c>,
    /// the workgroup is updated to the previously certified release.
    /// </summary>
    public partial class ServerlessTrack
    {
        private string _trackName;
        private List<UpdateTarget> _updateTargets = AWSConfigs.InitializeCollections ? new List<UpdateTarget>() : null;
        private string _workgroupVersion;

        /// <summary>
        /// Gets and sets the property TrackName. 
        /// <para>
        /// The name of the track. Valid values are <c>current</c> and <c>trailing</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TrackName
        {
            get { return this._trackName; }
            set { this._trackName = value; }
        }

        // Check to see if TrackName property is set
        internal bool IsSetTrackName()
        {
            return this._trackName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTargets. 
        /// <para>
        /// An array of <c>UpdateTarget</c> objects to update with the track.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpdateTarget> UpdateTargets
        {
            get { return this._updateTargets; }
            set { this._updateTargets = value; }
        }

        // Check to see if UpdateTargets property is set
        internal bool IsSetUpdateTargets()
        {
            return this._updateTargets != null && (this._updateTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkgroupVersion. 
        /// <para>
        /// The workgroup version number for the workgroup release.
        /// </para>
        /// </summary>
        public string WorkgroupVersion
        {
            get { return this._workgroupVersion; }
            set { this._workgroupVersion = value; }
        }

        // Check to see if WorkgroupVersion property is set
        internal bool IsSetWorkgroupVersion()
        {
            return this._workgroupVersion != null;
        }

    }
}