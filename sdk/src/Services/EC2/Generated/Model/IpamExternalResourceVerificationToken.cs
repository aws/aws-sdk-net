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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// A verification token is an Amazon Web Services-generated random value that you can
    /// use to prove ownership of an external resource. For example, you can use a verification
    /// token to validate that you control a public IP address range when you bring an IP
    /// address range to Amazon Web Services (BYOIP).
    /// </summary>
    public partial class IpamExternalResourceVerificationToken
    {
        private string _ipamArn;
        private string _ipamExternalResourceVerificationTokenArn;
        private string _ipamExternalResourceVerificationTokenId;
        private string _ipamId;
        private string _ipamRegion;
        private DateTime? _notAfter;
        private IpamExternalResourceVerificationTokenState _state;
        private TokenState _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tokenName;
        private string _tokenValue;

        /// <summary>
        /// Gets and sets the property IpamArn. 
        /// <para>
        /// ARN of the IPAM that created the token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamArn
        {
            get { return this._ipamArn; }
            set { this._ipamArn = value; }
        }

        // Check to see if IpamArn property is set
        internal bool IsSetIpamArn()
        {
            return this._ipamArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamExternalResourceVerificationTokenArn. 
        /// <para>
        /// Token ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamExternalResourceVerificationTokenArn
        {
            get { return this._ipamExternalResourceVerificationTokenArn; }
            set { this._ipamExternalResourceVerificationTokenArn = value; }
        }

        // Check to see if IpamExternalResourceVerificationTokenArn property is set
        internal bool IsSetIpamExternalResourceVerificationTokenArn()
        {
            return this._ipamExternalResourceVerificationTokenArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamExternalResourceVerificationTokenId. 
        /// <para>
        /// The ID of the token.
        /// </para>
        /// </summary>
        public string IpamExternalResourceVerificationTokenId
        {
            get { return this._ipamExternalResourceVerificationTokenId; }
            set { this._ipamExternalResourceVerificationTokenId = value; }
        }

        // Check to see if IpamExternalResourceVerificationTokenId property is set
        internal bool IsSetIpamExternalResourceVerificationTokenId()
        {
            return this._ipamExternalResourceVerificationTokenId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM that created the token.
        /// </para>
        /// </summary>
        public string IpamId
        {
            get { return this._ipamId; }
            set { this._ipamId = value; }
        }

        // Check to see if IpamId property is set
        internal bool IsSetIpamId()
        {
            return this._ipamId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// Region of the IPAM that created the token.
        /// </para>
        /// </summary>
        public string IpamRegion
        {
            get { return this._ipamRegion; }
            set { this._ipamRegion = value; }
        }

        // Check to see if IpamRegion property is set
        internal bool IsSetIpamRegion()
        {
            return this._ipamRegion != null;
        }

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// Token expiration.
        /// </para>
        /// </summary>
        public DateTime? NotAfter
        {
            get { return this._notAfter; }
            set { this._notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this._notAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Token state.
        /// </para>
        /// </summary>
        public IpamExternalResourceVerificationTokenState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Token status.
        /// </para>
        /// </summary>
        public TokenState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Token tags.
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
        /// Gets and sets the property TokenName. 
        /// <para>
        /// Token name.
        /// </para>
        /// </summary>
        public string TokenName
        {
            get { return this._tokenName; }
            set { this._tokenName = value; }
        }

        // Check to see if TokenName property is set
        internal bool IsSetTokenName()
        {
            return this._tokenName != null;
        }

        /// <summary>
        /// Gets and sets the property TokenValue. 
        /// <para>
        /// Token value.
        /// </para>
        /// </summary>
        public string TokenValue
        {
            get { return this._tokenValue; }
            set { this._tokenValue = value; }
        }

        // Check to see if TokenValue property is set
        internal bool IsSetTokenValue()
        {
            return this._tokenValue != null;
        }

    }
}