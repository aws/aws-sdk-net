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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an option group membership for a DB cluster.
    /// </summary>
    public partial class AwsRdsDbClusterOptionGroupMembership
    {
        /// <summary>
        /// Gets and sets the property DbClusterOptionGroupName. 
        /// <para>
        /// The name of the DB cluster option group.
        /// </para>
        /// </summary>
        public string DbClusterOptionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterOptionGroupName property is set.
        /// </summary>
        internal bool IsSetDbClusterOptionGroupName() => this.DbClusterOptionGroupName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB cluster option group.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
