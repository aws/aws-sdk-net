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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// A data structure with information about any primary and secondary clusters associated
    /// with an Neptune global database.
    /// </summary>
    public partial class GlobalClusterMember
    {
        /// <summary>
        /// Gets and sets the property DBClusterArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for each Neptune cluster. 
        /// </para>
        /// </summary>
        public string DBClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterArn property is set.
        /// </summary>
        internal bool IsSetDBClusterArn() => this.DBClusterArn != null;

        /// <summary>
        /// Gets and sets the property IsWriter. 
        /// <para>
        ///  Specifies whether the Neptune cluster is the primary cluster (that is, has read-write
        /// capability) for the Neptune global database with which it is associated. 
        /// </para>
        /// </summary>
        public bool? IsWriter { get; set; }

        /// <summary>
        /// Checks to see if the IsWriter property is set.
        /// </summary>
        internal bool IsSetIsWriter() => this.IsWriter.HasValue;

        /// <summary>
        /// Gets and sets the property Readers. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for each read-only secondary cluster associated with
        /// the Neptune global database. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Readers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Readers property is set.
        /// </summary>
        internal bool IsSetReaders() => this.Readers != null && (this.Readers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
