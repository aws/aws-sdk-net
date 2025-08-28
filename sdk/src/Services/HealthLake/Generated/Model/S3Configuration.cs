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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The configuration of the S3 bucket for either an import or export job. This includes
    /// assigning access permissions.
    /// </summary>
    public partial class S3Configuration
    {
        private string _kmsKeyId;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Key Management Service (KMS) key ID used to access the S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=400)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The <c>S3Uri</c> is the user-specified S3 location of the FHIR data to be imported
        /// into AWS HealthLake.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}