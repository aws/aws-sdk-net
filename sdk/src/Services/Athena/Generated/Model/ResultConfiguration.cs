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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The location in Amazon S3 where query results are stored and the encryption option,
    /// if any, used for query results.
    /// </summary>
    public partial class ResultConfiguration
    {
        private EncryptionConfiguration _encryptionConfiguration;
        private string _outputLocation;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// If query results are encrypted in Amazon S3, indicates the encryption option used
        /// (for example, <code>SSE-KMS</code> or <code>CSE-KMS</code>) and key information.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The location in Amazon S3 where your query results are stored, such as <code>s3://path/to/query/bucket/</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/athena/latest/ug/querying.html">Queries
        /// and Query Result Files. </a> 
        /// </para>
        /// </summary>
        public string OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

    }
}