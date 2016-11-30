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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstances operation.
    /// Creates one or more Amazon Lightsail virtual private servers, or <i>instances</i>.
    /// </summary>
    public partial class CreateInstancesRequest : AmazonLightsailRequest
    {
        private string _availabilityZone;
        private string _blueprintId;
        private string _bundleId;
        private string _customImageName;
        private List<string> _instanceNames = new List<string>();
        private string _keyPairName;
        private string _userData;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to create your instance. Use the following format:
        /// <code>us-east-1a</code> (case sensitive).
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintId. 
        /// <para>
        /// The ID for a virtual private server image (e.g., <code>app_wordpress_4_4</code> or
        /// <code>app_lamp_7_0</code>). Use the get blueprints operation to return a list of available
        /// images (or <i>blueprints</i>).
        /// </para>
        /// </summary>
        public string BlueprintId
        {
            get { return this._blueprintId; }
            set { this._blueprintId = value; }
        }

        // Check to see if BlueprintId property is set
        internal bool IsSetBlueprintId()
        {
            return this._blueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle of specification information for your virtual private server (or <i>instance</i>),
        /// including the pricing plan (e.g., <code>micro_1_0</code>).
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomImageName. 
        /// <para>
        /// The name for your custom image.
        /// </para>
        /// </summary>
        public string CustomImageName
        {
            get { return this._customImageName; }
            set { this._customImageName = value; }
        }

        // Check to see if CustomImageName property is set
        internal bool IsSetCustomImageName()
        {
            return this._customImageName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceNames. 
        /// <para>
        /// The names to use for your new Lightsail instances. Separate multiple values using
        /// quotation marks and commas, for example: <code>["MyFirstInstance","MySecondInstance"]</code>
        /// 
        /// </para>
        /// </summary>
        public List<string> InstanceNames
        {
            get { return this._instanceNames; }
            set { this._instanceNames = value; }
        }

        // Check to see if InstanceNames property is set
        internal bool IsSetInstanceNames()
        {
            return this._instanceNames != null && this._instanceNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyPairName. 
        /// <para>
        /// The name of your key pair.
        /// </para>
        /// </summary>
        public string KeyPairName
        {
            get { return this._keyPairName; }
            set { this._keyPairName = value; }
        }

        // Check to see if KeyPairName property is set
        internal bool IsSetKeyPairName()
        {
            return this._keyPairName != null;
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// A launch script you can create that configures a server with additional user data.
        /// For example, you might want to run <code>apt-get –y update</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on the machine image you choose, the command to get software on your instance
        /// varies. Amazon Linux and CentOS use <code>yum</code>, Debian and Ubuntu use <code>apt-get</code>,
        /// and FreeBSD uses <code>pkg</code>. For a complete list, see the <a href="http://lightsail.aws.amazon.com/ls/docs/getting-started/articles/pre-installed-apps">Dev
        /// Guide</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string UserData
        {
            get { return this._userData; }
            set { this._userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this._userData != null;
        }

    }
}