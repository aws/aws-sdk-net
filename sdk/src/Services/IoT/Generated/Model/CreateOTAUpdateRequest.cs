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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOTAUpdate operation.
    /// Creates an AWS IoT OTAUpdate on a target group of things or groups.
    /// </summary>
    public partial class CreateOTAUpdateRequest : AmazonIoTRequest
    {
        private Dictionary<string, string> _additionalParameters = new Dictionary<string, string>();
        private string _description;
        private List<OTAUpdateFile> _files = new List<OTAUpdateFile>();
        private string _otaUpdateId;
        private string _roleArn;
        private List<string> _targets = new List<string>();
        private TargetSelection _targetSelection;

        /// <summary>
        /// Gets and sets the property AdditionalParameters. 
        /// <para>
        /// A list of additional OTA update parameters which are name-value pairs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalParameters
        {
            get { return this._additionalParameters; }
            set { this._additionalParameters = value; }
        }

        // Check to see if AdditionalParameters property is set
        internal bool IsSetAdditionalParameters()
        {
            return this._additionalParameters != null && this._additionalParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the OTA update.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Files. 
        /// <para>
        /// The files to be streamed by the OTA update.
        /// </para>
        /// </summary>
        public List<OTAUpdateFile> Files
        {
            get { return this._files; }
            set { this._files = value; }
        }

        // Check to see if Files property is set
        internal bool IsSetFiles()
        {
            return this._files != null && this._files.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OtaUpdateId. 
        /// <para>
        /// The ID of the OTA update to be created.
        /// </para>
        /// </summary>
        public string OtaUpdateId
        {
            get { return this._otaUpdateId; }
            set { this._otaUpdateId = value; }
        }

        // Check to see if OtaUpdateId property is set
        internal bool IsSetOtaUpdateId()
        {
            return this._otaUpdateId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that allows access to the AWS IoT Jobs service.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targeted devices to receive OTA updates.
        /// </para>
        /// </summary>
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetSelection. 
        /// <para>
        /// Specifies whether the update will continue to run (CONTINUOUS), or will be complete
        /// after all the things specified as targets have completed the update (SNAPSHOT). If
        /// continuous, the update may also be run on a thing when a change is detected in a target.
        /// For example, an update will run on a thing when the thing is added to a target group,
        /// even after the update was completed by all things originally in the group. Valid values:
        /// CONTINUOUS | SNAPSHOT.
        /// </para>
        /// </summary>
        public TargetSelection TargetSelection
        {
            get { return this._targetSelection; }
            set { this._targetSelection = value; }
        }

        // Check to see if TargetSelection property is set
        internal bool IsSetTargetSelection()
        {
            return this._targetSelection != null;
        }

    }
}