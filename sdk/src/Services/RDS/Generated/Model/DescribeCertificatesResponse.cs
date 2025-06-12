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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Data returned by the <b>DescribeCertificates</b> action.
    /// </summary>
    public partial class DescribeCertificatesResponse : AmazonWebServiceResponse
    {
        private List<Certificate> _certificates = AWSConfigs.InitializeCollections ? new List<Certificate>() : null;
        private string _defaultCertificateForNewLaunches;
        private string _marker;

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// The list of <c>Certificate</c> objects for the Amazon Web Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Certificate> Certificates
        {
            get { return this._certificates; }
            set { this._certificates = value; }
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this._certificates != null && (this._certificates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultCertificateForNewLaunches. 
        /// <para>
        /// The default root CA for new databases created by your Amazon Web Services account.
        /// This is either the root CA override set on your Amazon Web Services account or the
        /// system default CA for the Region if no override exists. To override the default CA,
        /// use the <c>ModifyCertificates</c> operation.
        /// </para>
        /// </summary>
        public string DefaultCertificateForNewLaunches
        {
            get { return this._defaultCertificateForNewLaunches; }
            set { this._defaultCertificateForNewLaunches = value; }
        }

        // Check to see if DefaultCertificateForNewLaunches property is set
        internal bool IsSetDefaultCertificateForNewLaunches()
        {
            return this._defaultCertificateForNewLaunches != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeCertificates</c> request.
        /// If this parameter is specified, the response includes only records beyond the marker,
        /// up to the value specified by <c>MaxRecords</c> .
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}