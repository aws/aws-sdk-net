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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// The details for a server host key.
    /// </summary>
    public partial class DescribedHostKey
    {
        private string _arn;
        private DateTime? _dateImported;
        private string _description;
        private string _hostKeyFingerprint;
        private string _hostKeyId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for the host key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DateImported. 
        /// <para>
        /// The date on which the host key was added to the server.
        /// </para>
        /// </summary>
        public DateTime? DateImported
        {
            get { return this._dateImported; }
            set { this._dateImported = value; }
        }

        // Check to see if DateImported property is set
        internal bool IsSetDateImported()
        {
            return this._dateImported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The text description for this host key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property HostKeyFingerprint. 
        /// <para>
        /// The public key fingerprint, which is a short sequence of bytes used to identify the
        /// longer public key.
        /// </para>
        /// </summary>
        public string HostKeyFingerprint
        {
            get { return this._hostKeyFingerprint; }
            set { this._hostKeyFingerprint = value; }
        }

        // Check to see if HostKeyFingerprint property is set
        internal bool IsSetHostKeyFingerprint()
        {
            return this._hostKeyFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property HostKeyId. 
        /// <para>
        /// A unique identifier for the host key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=25)]
        public string HostKeyId
        {
            get { return this._hostKeyId; }
            set { this._hostKeyId = value; }
        }

        // Check to see if HostKeyId property is set
        internal bool IsSetHostKeyId()
        {
            return this._hostKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for host keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The encryption algorithm that is used for the host key. The <c>Type</c> parameter
        /// is specified by using one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ssh-rsa</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ssh-ed25519</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ecdsa-sha2-nistp256</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ecdsa-sha2-nistp384</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ecdsa-sha2-nistp521</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}