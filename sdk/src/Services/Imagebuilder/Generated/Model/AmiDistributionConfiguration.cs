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
    /// Define and configure the output AMIs of the pipeline.
    /// </summary>
    public partial class AmiDistributionConfiguration
    {
        private Dictionary<string, string> _amiTags = new Dictionary<string, string>();
        private string _description;
        private string _kmsKeyId;
        private LaunchPermissionConfiguration _launchPermission;
        private string _name;
        private List<string> _targetAccountIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AmiTags. 
        /// <para>
        /// The tags to apply to AMIs distributed to this Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> AmiTags
        {
            get { return this._amiTags; }
            set { this._amiTags = value; }
        }

        // Check to see if AmiTags property is set
        internal bool IsSetAmiTags()
        {
            return this._amiTags != null && this._amiTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AMI distribution configuration. Minimum and maximum length
        /// are in characters.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier used to encrypt the distributed image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchPermission. 
        /// <para>
        /// Launch permissions can be used to configure which Amazon Web Services accounts can
        /// use the AMI to launch instances.
        /// </para>
        /// </summary>
        public LaunchPermissionConfiguration LaunchPermission
        {
            get { return this._launchPermission; }
            set { this._launchPermission = value; }
        }

        // Check to see if LaunchPermission property is set
        internal bool IsSetLaunchPermission()
        {
            return this._launchPermission != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the output AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property TargetAccountIds. 
        /// <para>
        /// The ID of an account to which you want to distribute an image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1536)]
        public List<string> TargetAccountIds
        {
            get { return this._targetAccountIds; }
            set { this._targetAccountIds = value; }
        }

        // Check to see if TargetAccountIds property is set
        internal bool IsSetTargetAccountIds()
        {
            return this._targetAccountIds != null && this._targetAccountIds.Count > 0; 
        }

    }
}