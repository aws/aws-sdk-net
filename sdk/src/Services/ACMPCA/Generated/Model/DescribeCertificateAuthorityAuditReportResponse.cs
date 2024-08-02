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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// This is the response object from the DescribeCertificateAuthorityAuditReport operation.
    /// </summary>
    public partial class DescribeCertificateAuthorityAuditReportResponse : AmazonWebServiceResponse
    {
        private AuditReportStatus _auditReportStatus;
        private DateTime? _createdAt;
        private string _s3BucketName;
        private string _s3Key;

        /// <summary>
        /// Gets and sets the property AuditReportStatus. 
        /// <para>
        /// Specifies whether report creation is in progress, has succeeded, or has failed.
        /// </para>
        /// </summary>
        public AuditReportStatus AuditReportStatus
        {
            get { return this._auditReportStatus; }
            set { this._auditReportStatus = value; }
        }

        // Check to see if AuditReportStatus property is set
        internal bool IsSetAuditReportStatus()
        {
            return this._auditReportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time at which the report was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// Name of the S3 bucket that contains the report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// S3 <b>key</b> that uniquely identifies the report file in your S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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