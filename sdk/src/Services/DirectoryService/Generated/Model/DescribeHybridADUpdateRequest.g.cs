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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeHybridADUpdate operation. Retrieves information
    /// about update activities for a hybrid directory. This operation provides details about
    /// configuration changes, administrator account updates, and self-managed instance settings
    /// (IDs and DNS IPs).
    /// </summary>
    public partial class DescribeHybridADUpdateRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the hybrid directory for which to retrieve update information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from a previous request to <a>DescribeHybridADUpdate</a>. Pass
        /// null if this is the first request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The type of update activities to retrieve. Valid values include <c>SelfManagedInstances</c>
        /// and <c>HybridAdministratorAccount</c>.
        /// </para>
        /// </summary>
        public HybridUpdateType UpdateType { get; set; }

        /// <summary>
        /// Checks to see if the UpdateType property is set.
        /// </summary>
        internal bool IsSetUpdateType() => this.UpdateType != null;
    }
}
