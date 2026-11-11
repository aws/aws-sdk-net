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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the lookup table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key used to encrypt the lookup table data, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the lookup table was last updated, expressed as the number of milliseconds
        /// after <c>Jan 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LookupTableArn. 
        /// <para>
        /// The ARN of the lookup table.
        /// </para>
        /// </summary>
        public string LookupTableArn { get; set; }

        /// <summary>
        /// Checks to see if the LookupTableArn property is set.
        /// </summary>
        internal bool IsSetLookupTableArn() => this.LookupTableArn != null;

        /// <summary>
        /// Gets and sets the property LookupTableName. 
        /// <para>
        /// The name of the lookup table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string LookupTableName { get; set; }

        /// <summary>
        /// Checks to see if the LookupTableName property is set.
        /// </summary>
        internal bool IsSetLookupTableName() => this.LookupTableName != null;

        /// <summary>
        /// Gets and sets the property SizeBytes. 
        /// <para>
        /// The size of the lookup table in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeBytes property is set.
        /// </summary>
        internal bool IsSetSizeBytes() => this.SizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TableBody. 
        /// <para>
        /// The full CSV content of the lookup table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10485760)]
        public string TableBody { get; set; }

        /// <summary>
        /// Checks to see if the TableBody property is set.
        /// </summary>
        internal bool IsSetTableBody() => this.TableBody != null;
    }
}
