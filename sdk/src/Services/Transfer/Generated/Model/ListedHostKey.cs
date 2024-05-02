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
    /// Returns properties of the host key that's specified.
    /// </summary>
    public partial class ListedHostKey
    {
        private string _arn;
        private DateTime? _dateImported;
        private string _description;
        private string _fingerprint;
        private string _hostKeyId;
        private string _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the host key.
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
        /// The current description for the host key. You can change it by calling the <c>UpdateHostKey</c>
        /// operation and providing a new description.
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
        /// Gets and sets the property Fingerprint. 
        /// <para>
        /// The public key fingerprint, which is a short sequence of bytes used to identify the
        /// longer public key.
        /// </para>
        /// </summary>
        public string Fingerprint
        {
            get { return this._fingerprint; }
            set { this._fingerprint = value; }
        }

        // Check to see if Fingerprint property is set
        internal bool IsSetFingerprint()
        {
            return this._fingerprint != null;
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