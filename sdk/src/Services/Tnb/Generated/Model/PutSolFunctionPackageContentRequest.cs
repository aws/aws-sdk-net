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
    /// Container for the parameters to the PutSolFunctionPackageContent operation.
    /// Uploads the contents of a function package.
    /// 
    ///  
    /// <para>
    /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
    /// a network function (an ETSI standard telecommunication application) and function package
    /// descriptor that uses the TOSCA standard to describe how the network functions should
    /// run on your network.
    /// </para>
    /// </summary>
    public partial class PutSolFunctionPackageContentRequest : AmazonTnbRequest
    {
        private PackageContentType _contentType;
        private MemoryStream _file;
        private string _vnfPkgId;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Function package content type.
        /// </para>
        /// </summary>
        public PackageContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// Function package file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream File
        {
            get { return this._file; }
            set { this._file = value; }
        }

        // Check to see if File property is set
        internal bool IsSetFile()
        {
            return this._file != null;
        }

        /// <summary>
        /// Gets and sets the property VnfPkgId. 
        /// <para>
        /// Function package ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfPkgId
        {
            get { return this._vnfPkgId; }
            set { this._vnfPkgId = value; }
        }

        // Check to see if VnfPkgId property is set
        internal bool IsSetVnfPkgId()
        {
            return this._vnfPkgId != null;
        }

    }
}