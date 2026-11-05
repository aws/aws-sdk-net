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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Specific configuration settings for a DocumentDB event source.
    /// </summary>
    public partial class DocumentDBEventSourceConfig
    {
        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        ///  The name of the collection to consume within the database. If you do not specify
        /// a collection, Lambda consumes all collections. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 57)]
        public string CollectionName { get; set; }

        /// <summary>
        /// Checks to see if the CollectionName property is set.
        /// </summary>
        internal bool IsSetCollectionName() => this.CollectionName != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The name of the database to consume within the DocumentDB cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property FullDocument. 
        /// <para>
        ///  Determines what DocumentDB sends to your event stream during document update operations.
        /// If set to UpdateLookup, DocumentDB sends a delta describing the changes, along with
        /// a copy of the entire document. Otherwise, DocumentDB sends only a partial document
        /// that contains the changes. 
        /// </para>
        /// </summary>
        public FullDocument FullDocument { get; set; }

        /// <summary>
        /// Checks to see if the FullDocument property is set.
        /// </summary>
        internal bool IsSetFullDocument() => this.FullDocument != null;
    }
}
