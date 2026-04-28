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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the StartImportFileEnrichment operation.
    /// Starts an import file enrichment job to process and enrich network migration import
    /// files with additional metadata and IP assignment strategies.
    /// </summary>
    public partial class StartImportFileEnrichmentRequest : AmazonMgnRequest
    {
        private string _clientToken;
        private IpAssignmentStrategy _ipAssignmentStrategy;
        private EnrichmentSourceS3Configuration _s3BucketSource;
        private EnrichmentTargetS3Configuration _s3BucketTarget;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IpAssignmentStrategy. 
        /// <para>
        /// The IP assignment strategy to use when enriching the import file. Can be STATIC or
        /// DYNAMIC.
        /// </para>
        /// </summary>
        public IpAssignmentStrategy IpAssignmentStrategy
        {
            get { return this._ipAssignmentStrategy; }
            set { this._ipAssignmentStrategy = value; }
        }

        // Check to see if IpAssignmentStrategy property is set
        internal bool IsSetIpAssignmentStrategy()
        {
            return this._ipAssignmentStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketSource. 
        /// <para>
        /// The S3 configuration specifying the source location of the import file to be enriched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrichmentSourceS3Configuration S3BucketSource
        {
            get { return this._s3BucketSource; }
            set { this._s3BucketSource = value; }
        }

        // Check to see if S3BucketSource property is set
        internal bool IsSetS3BucketSource()
        {
            return this._s3BucketSource != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketTarget. 
        /// <para>
        /// The S3 configuration specifying the target location where the enriched import file
        /// will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrichmentTargetS3Configuration S3BucketTarget
        {
            get { return this._s3BucketTarget; }
            set { this._s3BucketTarget = value; }
        }

        // Check to see if S3BucketTarget property is set
        internal bool IsSetS3BucketTarget()
        {
            return this._s3BucketTarget != null;
        }

    }
}