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
    /// Container for the parameters to the GetSearchResultExportJob operation.
    /// This operation retrieves the metadata of an export job.
    /// 
    ///  
    /// <para>
    /// An export job is an operation that transmits the results of a search job to a specified
    /// S3 bucket in a .csv file.
    /// </para>
    ///  
    /// <para>
    /// An export job allows you to retain results of a search beyond the search job's scheduled
    /// retention of 7 days.
    /// </para>
    /// </summary>
    public partial class GetSearchResultExportJobRequest : AmazonBackupSearchRequest
    {
        private string _exportJobIdentifier;

        /// <summary>
        /// Gets and sets the property ExportJobIdentifier. 
        /// <para>
        /// This is the unique string that identifies a specific export job.
        /// </para>
        ///  
        /// <para>
        /// Required for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExportJobIdentifier
        {
            get { return this._exportJobIdentifier; }
            set { this._exportJobIdentifier = value; }
        }

        // Check to see if ExportJobIdentifier property is set
        internal bool IsSetExportJobIdentifier()
        {
            return this._exportJobIdentifier != null;
        }

    }
}