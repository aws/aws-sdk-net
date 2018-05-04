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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// The information about the EC2 instance associated with the activity that prompted
    /// GuardDuty to generate a finding.
    /// </summary>
    public partial class InstanceDetails
    {
        private string _availabilityZone;
        private IamInstanceProfile _iamInstanceProfile;
        private string _imageDescription;
        private string _imageId;
        private string _instanceId;
        private string _instanceState;
        private string _instanceType;
        private string _launchTime;
        private List<NetworkInterface> _networkInterfaces = new List<NetworkInterface>();
        private string _platform;
        private List<ProductCode> _productCodes = new List<ProductCode>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AvailabilityZone. The availability zone of the EC2 instance.
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
        /// Gets and sets the property IamInstanceProfile.
        /// </summary>
        public IamInstanceProfile IamInstanceProfile
        {
            get { return this._iamInstanceProfile; }
            set { this._iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this._iamInstanceProfile != null;
        }

        /// <summary>
        /// Gets and sets the property ImageDescription. The image description of the EC2 instance.
        /// </summary>
        public string ImageDescription
        {
            get { return this._imageDescription; }
            set { this._imageDescription = value; }
        }

        // Check to see if ImageDescription property is set
        internal bool IsSetImageDescription()
        {
            return this._imageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. The image ID of the EC2 instance.
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. The ID of the EC2 instance.
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceState. The state of the EC2 instance.
        /// </summary>
        public string InstanceState
        {
            get { return this._instanceState; }
            set { this._instanceState = value; }
        }

        // Check to see if InstanceState property is set
        internal bool IsSetInstanceState()
        {
            return this._instanceState != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. The type of the EC2 instance.
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. The launch time of the EC2 instance.
        /// </summary>
        public string LaunchTime
        {
            get { return this._launchTime; }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. The network interface information of
        /// the EC2 instance.
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && this._networkInterfaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Platform. The platform of the EC2 instance.
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCodes. The product code of the EC2 instance.
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && this._productCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. The tags of the EC2 instance.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}