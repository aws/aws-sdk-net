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
    /// Container for the parameters to the ImportCrl operation.
    /// Imports the certificate revocation list (CRL). A CRL is a list of certificates that
    /// have been revoked by the issuing certificate Authority (CA).In order to be properly
    /// imported, a CRL must be in PEM format. IAM Roles Anywhere validates against the CRL
    /// before issuing credentials. 
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>rolesanywhere:ImportCrl</c>. 
    /// </para>
    /// </summary>
    public partial class ImportCrlRequest : AmazonIAMRolesAnywhereRequest
    {
        private MemoryStream _crlData;
        private bool? _enabled;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trustAnchorArn;

        /// <summary>
        /// Gets and sets the property CrlData. 
        /// <para>
        /// The x509 v3 specified certificate revocation list (CRL).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300000)]
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the certificate revocation list (CRL) is enabled.
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to attach to the certificate revocation list (CRL).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property TrustAnchorArn. 
        /// <para>
        /// The ARN of the TrustAnchor the certificate revocation list (CRL) will provide revocation
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
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

    }
}