/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteImportData operation.
    /// Deletes one or more import tasks, each identified by their import ID. Each import
    /// task has a number of records that can identify servers or applications. 
    /// 
    ///  
    /// <para>
    /// AWS Application Discovery Service has built-in matching logic that will identify when
    /// discovered servers match existing entries that you've previously discovered, the information
    /// for the already-existing discovered server is updated. When you delete an import task
    /// that contains records that were used to match, the information in those matched records
    /// that comes from the deleted records will also be deleted.
    /// </para>
    /// </summary>
    public partial class BatchDeleteImportDataRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _importTaskIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ImportTaskIds. 
        /// <para>
        /// The IDs for the import tasks that you want to delete.
        /// </para>
        /// </summary>
        public List<string> ImportTaskIds
        {
            get { return this._importTaskIds; }
            set { this._importTaskIds = value; }
        }

        // Check to see if ImportTaskIds property is set
        internal bool IsSetImportTaskIds()
        {
            return this._importTaskIds != null && this._importTaskIds.Count > 0; 
        }

    }
}