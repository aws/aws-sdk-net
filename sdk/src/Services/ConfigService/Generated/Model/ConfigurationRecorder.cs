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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// An object that represents the recording of configuration changes of an AWS resource.
    /// </summary>
    public partial class ConfigurationRecorder
    {
        private string _name;
        private RecordingGroup _recordingGroup;
        private string _rolearn;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recorder. By default, AWS Config automatically assigns the name "default"
        /// when creating the configuration recorder. You cannot change the assigned name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RecordingGroup. 
        /// <para>
        /// Specifies the types of AWS resources for which AWS Config records configuration changes.
        /// </para>
        /// </summary>
        public RecordingGroup RecordingGroup
        {
            get { return this._recordingGroup; }
            set { this._recordingGroup = value; }
        }

        // Check to see if RecordingGroup property is set
        internal bool IsSetRecordingGroup()
        {
            return this._recordingGroup != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// Amazon Resource Name (ARN) of the IAM role used to describe the AWS resources associated
        /// with the account.
        /// </para>
        /// </summary>
        public string RoleARN
        {
            get { return this._rolearn; }
            set { this._rolearn = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._rolearn != null;
        }

    }
}