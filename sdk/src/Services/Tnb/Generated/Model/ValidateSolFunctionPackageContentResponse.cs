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
    /// This is the response object from the ValidateSolFunctionPackageContent operation.
    /// </summary>
    public partial class ValidateSolFunctionPackageContentResponse : AmazonWebServiceResponse
    {
        private string _id;
        private ValidateSolFunctionPackageContentMetadata _metadata;
        private string _vnfdId;
        private string _vnfdVersion;
        private string _vnfProductName;
        private string _vnfProvider;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Function package ID.
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
        /// Function package metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidateSolFunctionPackageContentMetadata Metadata
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
        /// Gets and sets the property VnfdId. 
        /// <para>
        /// Function package descriptor ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfdId
        {
            get { return this._vnfdId; }
            set { this._vnfdId = value; }
        }

        // Check to see if VnfdId property is set
        internal bool IsSetVnfdId()
        {
            return this._vnfdId != null;
        }

        /// <summary>
        /// Gets and sets the property VnfdVersion. 
        /// <para>
        /// Function package descriptor version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfdVersion
        {
            get { return this._vnfdVersion; }
            set { this._vnfdVersion = value; }
        }

        // Check to see if VnfdVersion property is set
        internal bool IsSetVnfdVersion()
        {
            return this._vnfdVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VnfProductName. 
        /// <para>
        /// Network function product name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfProductName
        {
            get { return this._vnfProductName; }
            set { this._vnfProductName = value; }
        }

        // Check to see if VnfProductName property is set
        internal bool IsSetVnfProductName()
        {
            return this._vnfProductName != null;
        }

        /// <summary>
        /// Gets and sets the property VnfProvider. 
        /// <para>
        /// Network function provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfProvider
        {
            get { return this._vnfProvider; }
            set { this._vnfProvider = value; }
        }

        // Check to see if VnfProvider property is set
        internal bool IsSetVnfProvider()
        {
            return this._vnfProvider != null;
        }

    }
}