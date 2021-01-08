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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeJournalS3Export operation.
    /// Returns information about a journal export job, including the ledger name, export
    /// ID, when it was created, current status, and its start and end time export parameters.
    /// 
    ///  
    /// <para>
    /// This action does not return any expired export jobs. For more information, see <a
    /// href="https://docs.aws.amazon.com/qldb/latest/developerguide/export-journal.request.html#export-journal.request.expiration">Export
    /// Job Expiration</a> in the <i>Amazon QLDB Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the export job with the given <code>ExportId</code> doesn't exist, then throws
    /// <code>ResourceNotFoundException</code>.
    /// </para>
    ///  
    /// <para>
    /// If the ledger with the given <code>Name</code> doesn't exist, then throws <code>ResourceNotFoundException</code>.
    /// </para>
    /// </summary>
    public partial class DescribeJournalS3ExportRequest : AmazonQLDBRequest
    {
        private string _exportId;
        private string _name;

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique ID of the journal export job that you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string ExportId
        {
            get { return this._exportId; }
            set { this._exportId = value; }
        }

        // Check to see if ExportId property is set
        internal bool IsSetExportId()
        {
            return this._exportId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}