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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomain operation.
    /// Creates a <code>Domain</code> used by SageMaker Studio. A domain consists of an associated
    /// directory, a list of authorized users, and a variety of security, application, policy,
    /// and Amazon Virtual Private Cloud (VPC) configurations. An AWS account is limited to
    /// one domain per region. Users within a domain can share notebook files and other artifacts
    /// with each other.
    /// 
    ///  
    /// <para>
    /// When a domain is created, an Amazon Elastic File System (EFS) volume is also created
    /// for use by all of the users within the domain. Each user receives a private home directory
    /// within the EFS for notebooks, Git repositories, and data files.
    /// </para>
    ///  
    /// <para>
    /// All traffic between the domain and the EFS volume is communicated through the specified
    /// subnet IDs. All other traffic goes over the Internet through an Amazon SageMaker system
    /// VPC. The EFS traffic uses the NFS/TCP protocol over port 2049.
    /// </para>
    ///  <important> 
    /// <para>
    /// NFS traffic over TCP on port 2049 needs to be allowed in both inbound and outbound
    /// rules in order to launch a SageMaker Studio app successfully.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateDomainRequest : AmazonSageMakerRequest
    {
        private AuthMode _authMode;
        private UserSettings _defaultUserSettings;
        private string _domainName;
        private string _homeEfsFileSystemKmsKeyId;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AuthMode. 
        /// <para>
        /// The mode of authentication that members use to access the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthMode AuthMode
        {
            get { return this._authMode; }
            set { this._authMode = value; }
        }

        // Check to see if AuthMode property is set
        internal bool IsSetAuthMode()
        {
            return this._authMode != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultUserSettings. 
        /// <para>
        /// The default user settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserSettings DefaultUserSettings
        {
            get { return this._defaultUserSettings; }
            set { this._defaultUserSettings = value; }
        }

        // Check to see if DefaultUserSettings property is set
        internal bool IsSetDefaultUserSettings()
        {
            return this._defaultUserSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A name for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemKmsKeyId. 
        /// <para>
        /// The AWS Key Management Service (KMS) encryption key ID. Encryption with a customer
        /// master key (CMK) is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string HomeEfsFileSystemKmsKeyId
        {
            get { return this._homeEfsFileSystemKmsKeyId; }
            set { this._homeEfsFileSystemKmsKeyId = value; }
        }

        // Check to see if HomeEfsFileSystemKmsKeyId property is set
        internal bool IsSetHomeEfsFileSystemKmsKeyId()
        {
            return this._homeEfsFileSystemKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The VPC subnets to use for communication with the EFS volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associated with the Domain. Each tag consists of a key and an optional value.
        /// Tag keys must be unique per resource. Tags are searchable using the <a>Search</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon Virtual Private Cloud (VPC) to use for communication with the
        /// EFS volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}