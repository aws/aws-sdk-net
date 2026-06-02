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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes a summary of a certificate association.
    /// </summary>
    public partial class CertificateAssociationSummary
    {
        private string _acmCertificateArn;
        private DateTime? _associatedAt;
        private CertificateAssociationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AcmCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACM certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=75, Max=256)]
        public string AcmCertificateArn
        {
            get { return this._acmCertificateArn; }
            set { this._acmCertificateArn = value; }
        }

        // Check to see if AcmCertificateArn property is set
        internal bool IsSetAcmCertificateArn()
        {
            return this._acmCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedAt. 
        /// <para>
        /// The timestamp of when the certificate was associated.
        /// </para>
        /// </summary>
        public DateTime? AssociatedAt
        {
            get { return this._associatedAt; }
            set { this._associatedAt = value; }
        }

        // Check to see if AssociatedAt property is set
        internal bool IsSetAssociatedAt()
        {
            return this._associatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the certificate association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateAssociationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the certificate association was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}