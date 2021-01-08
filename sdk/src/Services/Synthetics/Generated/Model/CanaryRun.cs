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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains the details about one run of one canary.
    /// </summary>
    public partial class CanaryRun
    {
        private string _artifactS3Location;
        private string _id;
        private string _name;
        private CanaryRunStatus _status;
        private CanaryRunTimeline _timeline;

        /// <summary>
        /// Gets and sets the property ArtifactS3Location. 
        /// <para>
        /// The location where the canary stored artifacts from the run. Artifacts include the
        /// log file, screenshots, and HAR files.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ArtifactS3Location
        {
            get { return this._artifactS3Location; }
            set { this._artifactS3Location = value; }
        }

        // Check to see if ArtifactS3Location property is set
        internal bool IsSetArtifactS3Location()
        {
            return this._artifactS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique ID that identifies this canary run.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the canary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=21)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this run.
        /// </para>
        /// </summary>
        public CanaryRunStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Timeline. 
        /// <para>
        /// A structure that contains the start and end times of this run.
        /// </para>
        /// </summary>
        public CanaryRunTimeline Timeline
        {
            get { return this._timeline; }
            set { this._timeline = value; }
        }

        // Check to see if Timeline property is set
        internal bool IsSetTimeline()
        {
            return this._timeline != null;
        }

    }
}