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
    /// Item Filters represent all input item properties specified when the search was created.
    /// 
    ///  
    /// <para>
    /// Contains either EBSItemFilters or S3ItemFilters
    /// </para>
    /// </summary>
    public partial class ItemFilters
    {
        private List<EBSItemFilter> _ebsItemFilters = AWSConfigs.InitializeCollections ? new List<EBSItemFilter>() : null;
        private List<S3ItemFilter> _s3ItemFilters = AWSConfigs.InitializeCollections ? new List<S3ItemFilter>() : null;

        /// <summary>
        /// Gets and sets the property EBSItemFilters. 
        /// <para>
        /// This array can contain CreationTimes, FilePaths, LastModificationTimes, or Sizes objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<EBSItemFilter> EBSItemFilters
        {
            get { return this._ebsItemFilters; }
            set { this._ebsItemFilters = value; }
        }

        // Check to see if EBSItemFilters property is set
        internal bool IsSetEBSItemFilters()
        {
            return this._ebsItemFilters != null && (this._ebsItemFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3ItemFilters. 
        /// <para>
        /// This array can contain CreationTimes, ETags, ObjectKeys, Sizes, or VersionIds objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<S3ItemFilter> S3ItemFilters
        {
            get { return this._s3ItemFilters; }
            set { this._s3ItemFilters = value; }
        }

        // Check to see if S3ItemFilters property is set
        internal bool IsSetS3ItemFilters()
        {
            return this._s3ItemFilters != null && (this._s3ItemFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}