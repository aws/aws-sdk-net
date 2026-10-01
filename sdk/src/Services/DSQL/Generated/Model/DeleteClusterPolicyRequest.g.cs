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

namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteClusterPolicy operation. Deletes the resource-based
    /// policy attached to a cluster. This removes all access permissions defined by the policy,
    /// reverting to default access controls.
    /// </summary>
    public partial class DeleteClusterPolicyRequest : AmazonDSQLRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExpectedPolicyVersion. 
        /// <para>
        /// The expected version of the policy to delete. This parameter ensures that you're deleting
        /// the correct version of the policy and helps prevent accidental deletions.
        /// </para>
        /// </summary>
        public string ExpectedPolicyVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedPolicyVersion property is set.
        /// </summary>
        internal bool IsSetExpectedPolicyVersion() => this.ExpectedPolicyVersion != null;

        /// <summary>
        /// Gets and sets the property Identifier.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;
    }
}
