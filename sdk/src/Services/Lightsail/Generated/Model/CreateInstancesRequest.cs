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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstances operation.
    /// Creates one or more Amazon Lightsail instances.
    /// 
    ///  
    /// <para>
    /// The <c>create instances</c> operation supports tag-based access control via request
    /// tags. For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateInstancesRequest : AmazonLightsailRequest
    {
        private List<AddOnRequest> _addOns = AWSConfigs.InitializeCollections ? new List<AddOnRequest>() : null;
        private string _availabilityZone;
        private string _blueprintId;
        private string _bundleId;
        private string _customImageName;
        private List<string> _instanceNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IpAddressType _ipAddressType;
        private string _keyPairName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _userData;

        /// <summary>
        /// Gets and sets the property AddOns. 
        /// <para>
        /// An array of objects representing the add-ons to enable for the new instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddOnRequest> AddOns
        {
            get { return this._addOns; }
            set { this._addOns = value; }
        }

        // Check to see if AddOns property is set
        internal bool IsSetAddOns()
        {
            return this._addOns != null && (this._addOns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to create your instance. Use the following format:
        /// <c>us-east-2a</c> (case sensitive). You can get a list of Availability Zones by using
        /// the <a href="http://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetRegions.html">get
        /// regions</a> operation. Be sure to add the <c>include Availability Zones</c> parameter
        /// to your request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID for a virtual private server image (<c>app_wordpress_x_x</c> or <c>app_lamp_x_x</c>).
        /// Use the <c>get blueprints</c> operation to return a list of available images (or <i>blueprints</i>).
        /// </para>
        ///  <note> 
        /// <para>
        /// Use active blueprints when creating new instances. Inactive blueprints are listed
        /// to support customers with existing instances and are not necessarily available to
        /// create new instances. Blueprints are marked inactive when they become outdated due
        /// to operating system updates or new application releases.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// including the pricing plan (<c>medium_x_x</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// (Discontinued) The name for your custom image.
        /// </para>
        ///  <note> 
        /// <para>
        /// In releases prior to June 12, 2017, this parameter was ignored by the API. It is now
        /// discontinued.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("In releases prior to June 12, 2017, this parameter was ignored by the API. It is now deprecated.")]
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
        /// quotation marks and commas, for example: <c>["MyFirstInstance","MySecondInstance"]</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InstanceNames
        {
            get { return this._instanceNames; }
            set { this._instanceNames = value; }
        }

        // Check to see if InstanceNames property is set
        internal bool IsSetInstanceNames()
        {
            return this._instanceNames != null && (this._instanceNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the instance.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, <c>ipv6</c> for IPv6 only, and
        /// <c>dualstack</c> for IPv4 and IPv6.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>dualstack</c>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// A launch script you can create that configures a server with additional user data.
        /// For example, you might want to run <c>apt-get -y update</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on the machine image you choose, the command to get software on your instance
        /// varies. Amazon Linux and CentOS use <c>yum</c>, Debian and Ubuntu use <c>apt-get</c>,
        /// and FreeBSD uses <c>pkg</c>. For a complete list, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/compare-options-choose-lightsail-instance-image">Amazon
        /// Lightsail Developer Guide</a>.
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