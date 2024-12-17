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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This is an object representing the item returned in the results of a search for a
    /// specific resource type.
    /// </summary>
    public partial class ResultItem
    {
        private EBSResultItem _ebsResultItem;
        private S3ResultItem _s3ResultItem;

        /// <summary>
        /// Gets and sets the property EBSResultItem. 
        /// <para>
        /// These are items returned in the search results of an Amazon EBS search.
        /// </para>
        /// </summary>
        public EBSResultItem EBSResultItem
        {
            get { return this._ebsResultItem; }
            set { this._ebsResultItem = value; }
        }

        // Check to see if EBSResultItem property is set
        internal bool IsSetEBSResultItem()
        {
            return this._ebsResultItem != null;
        }

        /// <summary>
        /// Gets and sets the property S3ResultItem. 
        /// <para>
        /// These are items returned in the search results of an Amazon S3 search.
        /// </para>
        /// </summary>
        public S3ResultItem S3ResultItem
        {
            get { return this._s3ResultItem; }
            set { this._s3ResultItem = value; }
        }

        // Check to see if S3ResultItem property is set
        internal bool IsSetS3ResultItem()
        {
            return this._s3ResultItem != null;
        }

    }
}