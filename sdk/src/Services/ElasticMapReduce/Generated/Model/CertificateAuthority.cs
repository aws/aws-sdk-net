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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Describes the certificate authority used to establish an mTLS connection to the Spark
    /// Connect server when connecting directly over VPC peering.
    /// </summary>
    public partial class CertificateAuthority
    {
        private string _certificateArn;
        private string _certificateData;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate authority in Amazon Web Services
        /// Private CA that issued the Spark Connect server certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateData. 
        /// <para>
        /// The PEM-encoded root CA certificate data. Provide this certificate to your client's
        /// trust store when connecting directly to the Spark Connect server over VPC peering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string CertificateData
        {
            get { return this._certificateData; }
            set { this._certificateData = value; }
        }

        // Check to see if CertificateData property is set
        internal bool IsSetCertificateData()
        {
            return this._certificateData != null;
        }

    }
}