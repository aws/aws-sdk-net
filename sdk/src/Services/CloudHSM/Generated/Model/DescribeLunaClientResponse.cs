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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
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
namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// This is the response object from the DescribeLunaClient operation.
    /// </summary>
    public partial class DescribeLunaClientResponse : AmazonWebServiceResponse
    {
        private string _certificate;
        private string _certificateFingerprint;
        private string _clientArn;
        private string _label;
        private string _lastModifiedTimestamp;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The certificate installed on the HSMs used by this client.
        /// </para>
        /// </summary>
        [AWSProperty(Min=600, Max=2400)]
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateFingerprint. 
        /// <para>
        /// The certificate fingerprint.
        /// </para>
        /// </summary>
        public string CertificateFingerprint
        {
            get { return this._certificateFingerprint; }
            set { this._certificateFingerprint = value; }
        }

        // Check to see if CertificateFingerprint property is set
        internal bool IsSetCertificateFingerprint()
        {
            return this._certificateFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property ClientArn. 
        /// <para>
        /// The ARN of the client.
        /// </para>
        /// </summary>
        public string ClientArn
        {
            get { return this._clientArn; }
            set { this._clientArn = value; }
        }

        // Check to see if ClientArn property is set
        internal bool IsSetClientArn()
        {
            return this._clientArn != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label of the client.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The date and time the client was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp != null;
        }

    }
}