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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// This is the response object from the ValidateSolNetworkPackageContent operation.
    /// </summary>
    public partial class ValidateSolNetworkPackageContentResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _id;
        private ValidateSolNetworkPackageContentMetadata _metadata;
        private string _nsdId;
        private string _nsdName;
        private string _nsdVersion;
        private List<string> _vnfPkgIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Network package ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// Network package ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Network package metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidateSolNetworkPackageContentMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property NsdId. 
        /// <para>
        /// Network service descriptor ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdId
        {
            get { return this._nsdId; }
            set { this._nsdId = value; }
        }

        // Check to see if NsdId property is set
        internal bool IsSetNsdId()
        {
            return this._nsdId != null;
        }

        /// <summary>
        /// Gets and sets the property NsdName. 
        /// <para>
        /// Network service descriptor name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdName
        {
            get { return this._nsdName; }
            set { this._nsdName = value; }
        }

        // Check to see if NsdName property is set
        internal bool IsSetNsdName()
        {
            return this._nsdName != null;
        }

        /// <summary>
        /// Gets and sets the property NsdVersion. 
        /// <para>
        /// Network service descriptor version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdVersion
        {
            get { return this._nsdVersion; }
            set { this._nsdVersion = value; }
        }

        // Check to see if NsdVersion property is set
        internal bool IsSetNsdVersion()
        {
            return this._nsdVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VnfPkgIds. 
        /// <para>
        /// Function package IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VnfPkgIds
        {
            get { return this._vnfPkgIds; }
            set { this._vnfPkgIds = value; }
        }

        // Check to see if VnfPkgIds property is set
        internal bool IsSetVnfPkgIds()
        {
            return this._vnfPkgIds != null && this._vnfPkgIds.Count > 0; 
        }

    }
}