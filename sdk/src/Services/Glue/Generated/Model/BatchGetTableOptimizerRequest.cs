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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetTableOptimizer operation.
    /// Returns the configuration for the specified table optimizers.
    /// </summary>
    public partial class BatchGetTableOptimizerRequest : AmazonGlueRequest
    {
        private List<BatchGetTableOptimizerEntry> _entries = AWSConfigs.InitializeCollections ? new List<BatchGetTableOptimizerEntry>() : null;

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// A list of <c>BatchGetTableOptimizerEntry</c> objects specifying the table optimizers
        /// to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetTableOptimizerEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}