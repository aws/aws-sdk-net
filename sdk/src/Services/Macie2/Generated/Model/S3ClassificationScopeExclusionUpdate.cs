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
    /// Specifies S3 buckets to add or remove from the exclusion list defined by the classification
    /// scope for an Amazon Macie account.
    /// </summary>
    public partial class S3ClassificationScopeExclusionUpdate
    {
        private List<string> _bucketNames = new List<string>();
        private ClassificationScopeUpdateOperation _operation;

        /// <summary>
        /// Gets and sets the property BucketNames. 
        /// <para>
        /// Depending on the value specified for the update operation (ClassificationScopeUpdateOperation),
        /// an array of strings that: lists the names of buckets to add or remove from the list,
        /// or specifies a new set of bucket names that overwrites all existing names in the list.
        /// Each string must be the full name of an S3 bucket. Values are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> BucketNames
        {
            get { return this._bucketNames; }
            set { this._bucketNames = value; }
        }

        // Check to see if BucketNames property is set
        internal bool IsSetBucketNames()
        {
            return this._bucketNames != null && this._bucketNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// Specifies how to apply the changes to the exclusion list. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ADD - Append the specified bucket names to the current list.
        /// </para>
        /// </li> <li>
        /// <para>
        /// REMOVE - Remove the specified bucket names from the current list.
        /// </para>
        /// </li> <li>
        /// <para>
        /// REPLACE - Overwrite the current list with the specified list of bucket names. If you
        /// specify this value, Amazon Macie removes all existing names from the list and adds
        /// all the specified names to the list.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClassificationScopeUpdateOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

    }
}