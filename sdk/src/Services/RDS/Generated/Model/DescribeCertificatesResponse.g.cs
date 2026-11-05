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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the DescribeCertificates operation.
    /// </summary>
    public partial class DescribeCertificatesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// The list of <c>Certificate</c> objects for the Amazon Web Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Certificate> Certificates { get; set; } = AWSConfigs.InitializeCollections ? new List<Certificate>() : null;

        /// <summary>
        /// Checks to see if the Certificates property is set.
        /// </summary>
        internal bool IsSetCertificates() => this.Certificates != null && (this.Certificates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultCertificateForNewLaunches. 
        /// <para>
        /// The default root CA for new databases created by your Amazon Web Services account.
        /// This is either the root CA override set on your Amazon Web Services account or the
        /// system default CA for the Region if no override exists. To override the default CA,
        /// use the <c>ModifyCertificates</c> operation.
        /// </para>
        /// </summary>
        public string DefaultCertificateForNewLaunches { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCertificateForNewLaunches property is set.
        /// </summary>
        internal bool IsSetDefaultCertificateForNewLaunches() => this.DefaultCertificateForNewLaunches != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeCertificates</c> request.
        /// If this parameter is specified, the response includes only records beyond the marker,
        /// up to the value specified by <c>MaxRecords</c> .
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;
    }
}
