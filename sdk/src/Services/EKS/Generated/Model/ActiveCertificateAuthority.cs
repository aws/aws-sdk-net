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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Identifies the certificate authority that is currently signing certificates for the
    /// cluster.
    /// </summary>
    public partial class ActiveCertificateAuthority
    {
        private CertificateAuthorityActivatedBy _activatedBy;
        private string _id;

        /// <summary>
        /// Gets and sets the property ActivatedBy. 
        /// <para>
        /// The entity that activated the current signing certificate authority, either <c>CUSTOMER</c>
        /// or <c>EKS</c>.
        /// </para>
        /// </summary>
        public CertificateAuthorityActivatedBy ActivatedBy
        {
            get { return this._activatedBy; }
            set { this._activatedBy = value; }
        }

        // Check to see if ActivatedBy property is set
        internal bool IsSetActivatedBy()
        {
            return this._activatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the certificate authority that is currently signing certificates
        /// for the cluster.
        /// </para>
        /// </summary>
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

    }
}