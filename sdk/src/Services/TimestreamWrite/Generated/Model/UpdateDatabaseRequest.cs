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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDatabase operation.
    /// Modifies the KMS key for an existing database. While updating the database, you must
    /// specify the database name and the identifier of the new KMS key to be used (<code>KmsKeyId</code>).
    /// If there are any concurrent <code>UpdateDatabase</code> requests, first writer wins.
    /// </summary>
    public partial class UpdateDatabaseRequest : AmazonTimestreamWriteRequest
    {
        private string _databaseName;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The name of the database. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The identifier of the new KMS key (<code>KmsKeyId</code>) to be used to encrypt the
        /// data stored in the database. If the <code>KmsKeyId</code> currently registered with
        /// the database is the same as the <code>KmsKeyId</code> in the request, there will not
        /// be any update. 
        /// </para>
        ///  
        /// <para>
        /// You can specify the <code>KmsKeyId</code> using any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-1:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <code>arn:aws:kms:us-east-1:111122223333:alias/ExampleAlias</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

    }
}