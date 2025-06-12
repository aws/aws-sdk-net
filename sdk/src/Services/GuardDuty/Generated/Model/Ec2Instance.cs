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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Details about the potentially impacted Amazon EC2 instance resource.
    /// </summary>
    public partial class Ec2Instance
    {
        private string _availabilityZone;
        private List<string> _ec2NetworkInterfaceUids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IamInstanceProfile _iamInstanceProfile;
        private string _imageDescription;
        private string _instanceState;
        private string _instanceType;
        private string _outpostArn;
        private string _platform;
        private List<ProductCode> _productCodes = AWSConfigs.InitializeCollections ? new List<ProductCode>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone of the Amazon EC2 instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html#concepts-availability-zones">Availability
        /// zones</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property Ec2NetworkInterfaceUids. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ec2NetworkInterfaceUids
        {
            get { return this._ec2NetworkInterfaceUids; }
            set { this._ec2NetworkInterfaceUids = value; }
        }

        // Check to see if Ec2NetworkInterfaceUids property is set
        internal bool IsSetEc2NetworkInterfaceUids()
        {
            return this._ec2NetworkInterfaceUids != null && (this._ec2NetworkInterfaceUids.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ImageDescription. 
        /// <para>
        /// The image description of the Amazon EC2 instance.
        /// </para>
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
        /// Gets and sets the property InstanceState. 
        /// <para>
        /// The state of the Amazon EC2 instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Amazon
        /// EC2 instance state changes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Type of the Amazon EC2 instance.
        /// </para>
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Outpost. This shows applicable
        /// Amazon Web Services Outposts instances.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the Amazon EC2 instance.
        /// </para>
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
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product code of the Amazon EC2 instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && (this._productCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}