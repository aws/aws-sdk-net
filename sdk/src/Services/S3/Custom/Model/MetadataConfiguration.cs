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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The S3 Metadata configuration for a general purpose bucket.
    /// </summary>
    public partial class MetadataConfiguration
    {
        private InventoryTableConfiguration _inventoryTableConfiguration;
        private JournalTableConfiguration _journalTableConfiguration;

        /// <summary>
        /// Gets and sets the property InventoryTableConfiguration. 
        /// <para>
        ///  The inventory table configuration for a metadata configuration. 
        /// </para>
        /// </summary>
        public InventoryTableConfiguration InventoryTableConfiguration
        {
            get { return this._inventoryTableConfiguration; }
            set { this._inventoryTableConfiguration = value; }
        }

        // Check to see if InventoryTableConfiguration property is set
        internal bool IsSetInventoryTableConfiguration()
        {
            return this._inventoryTableConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property JournalTableConfiguration. 
        /// <para>
        ///  The journal table configuration for a metadata configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JournalTableConfiguration JournalTableConfiguration
        {
            get { return this._journalTableConfiguration; }
            set { this._journalTableConfiguration = value; }
        }

        // Check to see if JournalTableConfiguration property is set
        internal bool IsSetJournalTableConfiguration()
        {
            return this._journalTableConfiguration != null;
        }

    }
}