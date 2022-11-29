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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies criteria for sorting the results of a query for information about S3 buckets.
    /// </summary>
    public partial class BucketSortCriteria
    {
        private string _attributeName;
        private OrderBy _orderBy;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the bucket property to sort the results by. This value can be one of the
        /// following properties that Amazon Macie defines as bucket metadata: accountId, bucketName,
        /// classifiableObjectCount, classifiableSizeInBytes, objectCount, sensitivityScore, or
        /// sizeInBytes.
        /// </para>
        /// </summary>
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// The sort order to apply to the results, based on the value specified by the attributeName
        /// property. Valid values are: ASC, sort the results in ascending order; and, DESC, sort
        /// the results in descending order.
        /// </para>
        /// </summary>
        public OrderBy OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null;
        }

    }
}