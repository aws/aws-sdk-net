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
    /// This is the response object from the GetLookupTable operation.
    /// </summary>
    public partial class GetLookupTableResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _kmsKeyId;
        private long? _lastUpdatedTime;
        private string _lookupTableArn;
        private string _lookupTableName;
        private long? _sizeBytes;
        private string _tableBody;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the lookup table.
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
        /// The ARN of the KMS key used to encrypt the lookup table data, if applicable.
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the lookup table was last updated, expressed as the number of milliseconds
        /// after <c>Jan 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LookupTableArn. 
        /// <para>
        /// The ARN of the lookup table.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LookupTableName. 
        /// <para>
        /// The name of the lookup table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string LookupTableName
        {
            get { return this._lookupTableName; }
            set { this._lookupTableName = value; }
        }

        // Check to see if LookupTableName property is set
        internal bool IsSetLookupTableName()
        {
            return this._lookupTableName != null;
        }

        /// <summary>
        /// Gets and sets the property SizeBytes. 
        /// <para>
        /// The size of the lookup table in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? SizeBytes
        {
            get { return this._sizeBytes; }
            set { this._sizeBytes = value; }
        }

        // Check to see if SizeBytes property is set
        internal bool IsSetSizeBytes()
        {
            return this._sizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableBody. 
        /// <para>
        /// The full CSV content of the lookup table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10485760)]
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