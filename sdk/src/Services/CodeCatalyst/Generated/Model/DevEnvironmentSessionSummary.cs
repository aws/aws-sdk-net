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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
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
namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about active sessions for a Dev Environment.
    /// </summary>
    public partial class DevEnvironmentSessionSummary
    {
        private string _devEnvironmentId;
        private string _id;
        private string _projectName;
        private string _spaceName;
        private DateTime? _startedTime;

        /// <summary>
        /// Gets and sets the property DevEnvironmentId. 
        /// <para>
        /// The system-generated unique ID of the Dev Environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DevEnvironmentId
        {
            get { return this._devEnvironmentId; }
            set { this._devEnvironmentId = value; }
        }

        // Check to see if DevEnvironmentId property is set
        internal bool IsSetDevEnvironmentId()
        {
            return this._devEnvironmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The system-generated unique ID of the Dev Environment session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=96)]
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

        /// <summary>
        /// Gets and sets the property StartedTime. 
        /// <para>
        /// The date and time the session started, in coordinated universal time (UTC) timestamp
        /// format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedTime
        {
            get { return this._startedTime; }
            set { this._startedTime = value; }
        }

        // Check to see if StartedTime property is set
        internal bool IsSetStartedTime()
        {
            return this._startedTime.HasValue; 
        }

    }
}