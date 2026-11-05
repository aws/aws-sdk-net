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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a <c>RevisionTarget</c>.
    /// </summary>
    public partial class RevisionTarget
    {
        /// <summary>
        /// Gets and sets the property DatabaseRevision. 
        /// <para>
        /// A unique string that identifies the version to update the cluster to. You can use
        /// this value in <a>ModifyClusterDbRevision</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DatabaseRevision { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseRevision property is set.
        /// </summary>
        internal bool IsSetDatabaseRevision() => this.DatabaseRevision != null;

        /// <summary>
        /// Gets and sets the property DatabaseRevisionReleaseDate. 
        /// <para>
        /// The date on which the database revision was released.
        /// </para>
        /// </summary>
        public DateTime? DatabaseRevisionReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseRevisionReleaseDate property is set.
        /// </summary>
        internal bool IsSetDatabaseRevisionReleaseDate() => this.DatabaseRevisionReleaseDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A string that describes the changes and features that will be applied to the cluster
        /// when it is updated to the corresponding <a>ClusterDbRevision</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
