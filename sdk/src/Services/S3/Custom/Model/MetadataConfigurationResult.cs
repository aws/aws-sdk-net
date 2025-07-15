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
    public partial class MetadataConfigurationResult
    {
        private DestinationResult _destinationResult;
        private InventoryTableConfigurationResult _inventoryTableConfigurationResult;
        private JournalTableConfigurationResult _journalTableConfigurationResult;

        /// <summary>
        /// Gets and sets the property DestinationResult. 
        /// <para>
        ///  The destination settings for a metadata configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationResult DestinationResult
        {
            get { return this._destinationResult; }
            set { this._destinationResult = value; }
        }

        // Check to see if DestinationResult property is set
        internal bool IsSetDestinationResult()
        {
            return this._destinationResult != null;
        }

        /// <summary>
        /// Gets and sets the property InventoryTableConfigurationResult. 
        /// <para>
        ///  The inventory table configuration for a metadata configuration. 
        /// </para>
        /// </summary>
        public InventoryTableConfigurationResult InventoryTableConfigurationResult
        {
            get { return this._inventoryTableConfigurationResult; }
            set { this._inventoryTableConfigurationResult = value; }
        }

        // Check to see if InventoryTableConfigurationResult property is set
        internal bool IsSetInventoryTableConfigurationResult()
        {
            return this._inventoryTableConfigurationResult != null;
        }

        /// <summary>
        /// Gets and sets the property JournalTableConfigurationResult. 
        /// <para>
        ///  The journal table configuration for a metadata configuration. 
        /// </para>
        /// </summary>
        public JournalTableConfigurationResult JournalTableConfigurationResult
        {
            get { return this._journalTableConfigurationResult; }
            set { this._journalTableConfigurationResult = value; }
        }

        // Check to see if JournalTableConfigurationResult property is set
        internal bool IsSetJournalTableConfigurationResult()
        {
            return this._journalTableConfigurationResult != null;
        }

    }
}