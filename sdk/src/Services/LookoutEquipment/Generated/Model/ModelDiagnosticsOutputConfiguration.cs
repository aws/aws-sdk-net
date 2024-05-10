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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Output configuration information for the pointwise model diagnostics for an Amazon
    /// Lookout for Equipment model.
    /// </summary>
    public partial class ModelDiagnosticsOutputConfiguration
    {
        private string _kmsKeyId;
        private ModelDiagnosticsS3OutputConfiguration _s3OutputConfiguration;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) key identifier to encrypt the
        /// pointwise model diagnostics files.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property S3OutputConfiguration. 
        /// <para>
        /// The Amazon S3 location for the pointwise model diagnostics. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelDiagnosticsS3OutputConfiguration S3OutputConfiguration
        {
            get { return this._s3OutputConfiguration; }
            set { this._s3OutputConfiguration = value; }
        }

        // Check to see if S3OutputConfiguration property is set
        internal bool IsSetS3OutputConfiguration()
        {
            return this._s3OutputConfiguration != null;
        }

    }
}