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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHsmClientCertificate operation.
    /// Creates an HSM client certificate that an Amazon Redshift cluster will use to connect
    /// to the client's HSM in order to store and retrieve the keys used to encrypt the cluster
    /// databases.
    /// 
    ///  
    /// <para>
    /// The command returns a public key, which you must store in the HSM. In addition to
    /// creating the HSM certificate, you must create an Amazon Redshift HSM configuration
    /// that provides a cluster the information needed to store and use encryption keys in
    /// the HSM. For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
    /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
    /// </para>
    /// </summary>
    public partial class CreateHsmClientCertificateRequest : AmazonRedshiftRequest
    {
        private string _hsmClientCertificateIdentifier;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property HsmClientCertificateIdentifier. 
        /// <para>
        /// The identifier to be assigned to the new HSM client certificate that the cluster will
        /// use to connect to the HSM to use the database encryption keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string HsmClientCertificateIdentifier
        {
            get { return this._hsmClientCertificateIdentifier; }
            set { this._hsmClientCertificateIdentifier = value; }
        }

        // Check to see if HsmClientCertificateIdentifier property is set
        internal bool IsSetHsmClientCertificateIdentifier()
        {
            return this._hsmClientCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag instances.
        /// </para>
        /// </summary>
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

    }
}