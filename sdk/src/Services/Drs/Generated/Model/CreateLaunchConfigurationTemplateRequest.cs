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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLaunchConfigurationTemplate operation.
    /// Creates a new Launch Configuration Template.
    /// </summary>
    public partial class CreateLaunchConfigurationTemplateRequest : AmazonDrsRequest
    {
        private bool? _copyPrivateIp;
        private bool? _copyTags;
        private LaunchDisposition _launchDisposition;
        private Licensing _licensing;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private TargetInstanceTypeRightSizingMethod _targetInstanceTypeRightSizingMethod;

        /// <summary>
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Copy private IP.
        /// </para>
        /// </summary>
        public bool CopyPrivateIp
        {
            get { return this._copyPrivateIp.GetValueOrDefault(); }
            set { this._copyPrivateIp = value; }
        }

        // Check to see if CopyPrivateIp property is set
        internal bool IsSetCopyPrivateIp()
        {
            return this._copyPrivateIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Copy tags.
        /// </para>
        /// </summary>
        public bool CopyTags
        {
            get { return this._copyTags.GetValueOrDefault(); }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// Launch disposition.
        /// </para>
        /// </summary>
        public LaunchDisposition LaunchDisposition
        {
            get { return this._launchDisposition; }
            set { this._launchDisposition = value; }
        }

        // Check to see if LaunchDisposition property is set
        internal bool IsSetLaunchDisposition()
        {
            return this._launchDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property Licensing. 
        /// <para>
        /// Licensing.
        /// </para>
        /// </summary>
        public Licensing Licensing
        {
            get { return this._licensing; }
            set { this._licensing = value; }
        }

        // Check to see if Licensing property is set
        internal bool IsSetLicensing()
        {
            return this._licensing != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Request to associate tags during creation of a Launch Configuration Template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetInstanceTypeRightSizingMethod. 
        /// <para>
        /// Target instance type right-sizing method.
        /// </para>
        /// </summary>
        public TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod
        {
            get { return this._targetInstanceTypeRightSizingMethod; }
            set { this._targetInstanceTypeRightSizingMethod = value; }
        }

        // Check to see if TargetInstanceTypeRightSizingMethod property is set
        internal bool IsSetTargetInstanceTypeRightSizingMethod()
        {
            return this._targetInstanceTypeRightSizingMethod != null;
        }

    }
}