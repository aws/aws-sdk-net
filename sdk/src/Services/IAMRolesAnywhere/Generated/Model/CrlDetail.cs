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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// The state of the certificate revocation list (CRL) after a read or write operation.
    /// </summary>
    public partial class CrlDetail
    {
        private DateTime? _createdAt;
        private string _crlArn;
        private MemoryStream _crlData;
        private string _crlId;
        private bool? _enabled;
        private string _name;
        private string _trustAnchorArn;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the certificate revocation list (CRL) was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrlArn. 
        /// <para>
        /// The ARN of the certificate revocation list (CRL).
        /// </para>
        /// </summary>
        public string CrlArn
        {
            get { return this._crlArn; }
            set { this._crlArn = value; }
        }

        // Check to see if CrlArn property is set
        internal bool IsSetCrlArn()
        {
            return this._crlArn != null;
        }

        /// <summary>
        /// Gets and sets the property CrlData. 
        /// <para>
        /// The state of the certificate revocation list (CRL) after a read or write operation.
        /// </para>
        /// </summary>
        public MemoryStream CrlData
        {
            get { return this._crlData; }
            set { this._crlData = value; }
        }

        // Check to see if CrlData property is set
        internal bool IsSetCrlData()
        {
            return this._crlData != null;
        }

        /// <summary>
        /// Gets and sets the property CrlId. 
        /// <para>
        /// The unique identifier of the certificate revocation list (CRL).
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string CrlId
        {
            get { return this._crlId; }
            set { this._crlId = value; }
        }

        // Check to see if CrlId property is set
        internal bool IsSetCrlId()
        {
            return this._crlId != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the certificate revocation list (CRL) is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the certificate revocation list (CRL).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TrustAnchorArn. 
        /// <para>
        /// The ARN of the TrustAnchor the certificate revocation list (CRL) will provide revocation
        /// for. 
        /// </para>
        /// </summary>
        public string TrustAnchorArn
        {
            get { return this._trustAnchorArn; }
            set { this._trustAnchorArn = value; }
        }

        // Check to see if TrustAnchorArn property is set
        internal bool IsSetTrustAnchorArn()
        {
            return this._trustAnchorArn != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the certificate revocation list (CRL) was last updated.
        /// 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}