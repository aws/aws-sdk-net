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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Filtering options for <i>ListGroups</i> operation. This is only used as input to
    /// Operation.
    /// </summary>
    public partial class ListGroupsFilters
    {
        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// Filters only groups with the provided name prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the NamePrefix property is set.
        /// </summary>
        internal bool IsSetNamePrefix() => this.NamePrefix != null;

        /// <summary>
        /// Gets and sets the property PrimaryEmailPrefix. 
        /// <para>
        /// Filters only groups with the provided primary email prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PrimaryEmailPrefix { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryEmailPrefix property is set.
        /// </summary>
        internal bool IsSetPrimaryEmailPrefix() => this.PrimaryEmailPrefix != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filters only groups with the provided state.
        /// </para>
        /// </summary>
        public EntityState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
