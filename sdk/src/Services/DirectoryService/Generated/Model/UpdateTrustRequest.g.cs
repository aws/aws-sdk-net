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
    /// Container for the parameters to the UpdateTrust operation. Updates the trust that
    /// has been set up between your Managed Microsoft AD directory and an self-managed Active
    /// Directory.
    /// </summary>
    public partial class UpdateTrustRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property SelectiveAuth. 
        /// <para>
        /// Updates selective authentication for the trust.
        /// </para>
        /// </summary>
        public SelectiveAuth SelectiveAuth { get; set; }

        /// <summary>
        /// Checks to see if the SelectiveAuth property is set.
        /// </summary>
        internal bool IsSetSelectiveAuth() => this.SelectiveAuth != null;

        /// <summary>
        /// Gets and sets the property TrustId. 
        /// <para>
        /// Identifier of the trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TrustId { get; set; }

        /// <summary>
        /// Checks to see if the TrustId property is set.
        /// </summary>
        internal bool IsSetTrustId() => this.TrustId != null;
    }
}
