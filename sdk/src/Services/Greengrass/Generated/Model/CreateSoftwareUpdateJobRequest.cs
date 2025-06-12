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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSoftwareUpdateJob operation.
    /// Creates a software update for a core or group of cores (specified as an IoT thing
    /// group.) Use this to update the OTA Agent as well as the Greengrass core software.
    /// It makes use of the IoT Jobs feature which provides additional commands to manage
    /// a Greengrass core software update job.
    /// </summary>
    public partial class CreateSoftwareUpdateJobRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _s3UrlSignerRole;
        private SoftwareToUpdate _softwareToUpdate;
        private UpdateAgentLogLevel _updateAgentLogLevel;
        private List<string> _updateTargets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private UpdateTargetsArchitecture _updateTargetsArchitecture;
        private UpdateTargetsOperatingSystem _updateTargetsOperatingSystem;

        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken
        {
            get { return this._amznClientToken; }
            set { this._amznClientToken = value; }
        }

        // Check to see if AmznClientToken property is set
        internal bool IsSetAmznClientToken()
        {
            return this._amznClientToken != null;
        }

        /// <summary>
        /// Gets and sets the property S3UrlSignerRole.
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3UrlSignerRole
        {
            get { return this._s3UrlSignerRole; }
            set { this._s3UrlSignerRole = value; }
        }

        // Check to see if S3UrlSignerRole property is set
        internal bool IsSetS3UrlSignerRole()
        {
            return this._s3UrlSignerRole != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareToUpdate.
        /// </summary>
        [AWSProperty(Required=true)]
        public SoftwareToUpdate SoftwareToUpdate
        {
            get { return this._softwareToUpdate; }
            set { this._softwareToUpdate = value; }
        }

        // Check to see if SoftwareToUpdate property is set
        internal bool IsSetSoftwareToUpdate()
        {
            return this._softwareToUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateAgentLogLevel.
        /// </summary>
        public UpdateAgentLogLevel UpdateAgentLogLevel
        {
            get { return this._updateAgentLogLevel; }
            set { this._updateAgentLogLevel = value; }
        }

        // Check to see if UpdateAgentLogLevel property is set
        internal bool IsSetUpdateAgentLogLevel()
        {
            return this._updateAgentLogLevel != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTargets.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> UpdateTargets
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
        /// Gets and sets the property UpdateTargetsArchitecture.
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateTargetsArchitecture UpdateTargetsArchitecture
        {
            get { return this._updateTargetsArchitecture; }
            set { this._updateTargetsArchitecture = value; }
        }

        // Check to see if UpdateTargetsArchitecture property is set
        internal bool IsSetUpdateTargetsArchitecture()
        {
            return this._updateTargetsArchitecture != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTargetsOperatingSystem.
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateTargetsOperatingSystem UpdateTargetsOperatingSystem
        {
            get { return this._updateTargetsOperatingSystem; }
            set { this._updateTargetsOperatingSystem = value; }
        }

        // Check to see if UpdateTargetsOperatingSystem property is set
        internal bool IsSetUpdateTargetsOperatingSystem()
        {
            return this._updateTargetsOperatingSystem != null;
        }

    }
}