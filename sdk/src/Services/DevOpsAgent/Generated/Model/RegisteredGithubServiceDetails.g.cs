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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Details specific to a registered GitHub service.
    /// </summary>
    public partial class RegisteredGithubServiceDetails
    {
        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The GitHub repository owner name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property OwnerType. 
        /// <para>
        /// The GitHub repository owner type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GithubRepoOwnerType OwnerType { get; set; }

        /// <summary>
        /// Checks to see if the OwnerType property is set.
        /// </summary>
        internal bool IsSetOwnerType() => this.OwnerType != null;

        /// <summary>
        /// Gets and sets the property TargetUrl. 
        /// <para>
        /// The GitHub Enterprise Server instance URL (absent for github.com).
        /// </para>
        /// </summary>
        public string TargetUrl { get; set; }

        /// <summary>
        /// Checks to see if the TargetUrl property is set.
        /// </summary>
        internal bool IsSetTargetUrl() => this.TargetUrl != null;
    }
}
