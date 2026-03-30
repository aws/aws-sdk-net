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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLookupTable operation.
    /// Updates an existing lookup table by replacing all of its CSV content. After the update
    /// completes, queries that use this table will use the new data.
    /// 
    ///  
    /// <para>
    /// This is a full replacement operation. All existing content is replaced with the new
    /// CSV data.
    /// </para>
    /// </summary>
    public partial class UpdateLookupTableRequest : AmazonCloudWatchLogsRequest
    {
        private string _description;
        private string _kmsKeyId;
        private string _lookupTableArn;
        private string _tableBody;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An updated description of the lookup table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key to use to encrypt the lookup table data. You can use this parameter
        /// to add, update, or remove the KMS key. To remove the KMS key and use an Amazon Web
        /// Services-owned key instead, specify an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property LookupTableArn. 
        /// <para>
        /// The ARN of the lookup table to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LookupTableArn
        {
            get { return this._lookupTableArn; }
            set { this._lookupTableArn = value; }
        }

        // Check to see if LookupTableArn property is set
        internal bool IsSetLookupTableArn()
        {
            return this._lookupTableArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableBody. 
        /// <para>
        /// The new CSV content to replace the existing data. The first row must be a header row
        /// with column names. The content must use UTF-8 encoding and not exceed 10 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10485760)]
        public string TableBody
        {
            get { return this._tableBody; }
            set { this._tableBody = value; }
        }

        // Check to see if TableBody property is set
        internal bool IsSetTableBody()
        {
            return this._tableBody != null;
        }

    }
}