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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MetadataTableEncryptionConfiguration
    {
        private string kmsKeyArn;
        private TableSseAlgorithm sseAlgorithm;

        /// <summary>
        /// Gets and sets the property KmsKeyArn.
        /// </summary>
        public string KmsKeyArn
        {
            get { return this.kmsKeyArn; }
            set { this.kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return !String.IsNullOrEmpty(this.kmsKeyArn);
        }

        /// <summary>
        /// Gets and sets the property SseAlgorithm.
        /// </summary>
        public TableSseAlgorithm SseAlgorithm
        {
            get { return this.sseAlgorithm; }
            set { this.sseAlgorithm = value; }
        }

        // Check to see if SseAlgorithm property is set
        internal bool IsSetSseAlgorithm()
        {
            return this.sseAlgorithm != null;
        }

    }
}