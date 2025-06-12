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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies a property-based condition that determines whether an S3 bucket is included
    /// or excluded from a classification job.
    /// </summary>
    public partial class SimpleCriterionForJob
    {
        private JobComparator _comparator;
        private SimpleCriterionKeyForJob _key;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// The operator to use in the condition. Valid values are EQ (equals) and NE (not equals).
        /// </para>
        /// </summary>
        public JobComparator Comparator
        {
            get { return this._comparator; }
            set { this._comparator = value; }
        }

        // Check to see if Comparator property is set
        internal bool IsSetComparator()
        {
            return this._comparator != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The property to use in the condition.
        /// </para>
        /// </summary>
        public SimpleCriterionKeyForJob Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// An array that lists one or more values to use in the condition. If you specify multiple
        /// values, Amazon Macie uses OR logic to join the values. Valid values for each supported
        /// property (key) are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ACCOUNT_ID - A string that represents the unique identifier for the Amazon Web Services
        /// account that owns the bucket.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_BUCKET_EFFECTIVE_PERMISSION - A string that represents an enumerated value that
        /// Macie defines for the <a href="https://docs.aws.amazon.com/macie/latest/APIReference/datasources-s3.html#datasources-s3-prop-bucketpublicaccess-effectivepermission">BucketPublicAccess.effectivePermission</a>
        /// property of a bucket.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_BUCKET_NAME - A string that represents the name of a bucket.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_BUCKET_SHARED_ACCESS - A string that represents an enumerated value that Macie
        /// defines for the <a href="https://docs.aws.amazon.com/macie/latest/APIReference/datasources-s3.html#datasources-s3-prop-bucketmetadata-sharedaccess">BucketMetadata.sharedAccess</a>
        /// property of a bucket.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// Values are case sensitive. Also, Macie doesn't support use of partial values or wildcard
        /// characters in these values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}