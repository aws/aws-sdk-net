/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// This is the response object from the CreateCertificateAuthorityAuditReport operation.
    /// </summary>
    public partial class CreateCertificateAuthorityAuditReportResponse : AmazonWebServiceResponse
    {
        private string _auditReportId;
        private string _s3Key;

        /// <summary>
        /// Gets and sets the property AuditReportId. 
        /// <para>
        /// An alphanumeric string that contains a report identifier.
        /// </para>
        /// </summary>
        public string AuditReportId
        {
            get { return this._auditReportId; }
            set { this._auditReportId = value; }
        }

        // Check to see if AuditReportId property is set
        internal bool IsSetAuditReportId()
        {
            return this._auditReportId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The <b>key</b> that uniquely identifies the report file in your S3 bucket.
        /// </para>
        /// </summary>
        public string S3Key
        {
            get { return this._s3Key; }
            set { this._s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this._s3Key != null;
        }

    }
}