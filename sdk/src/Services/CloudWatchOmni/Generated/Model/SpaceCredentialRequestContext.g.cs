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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Identifies what the credentials are for: either an existing space, or a target account
    /// in a domain. Specify spaceId, or both domainId and targetAccountId.
    /// </summary>
    public partial class SpaceCredentialRequestContext
    {
        /// <summary>
        /// Gets and sets the property DomainId. The ID of the domain, when returning credentials
        /// for a target account that does not yet have a space.
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property SpaceId. The ID of an existing space to return credentials
        /// for.
        /// </summary>
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property TargetAccountId. The ID of the target member account. Required
        /// when domainId is set.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string TargetAccountId { get; set; }

        /// <summary>
        /// Checks to see if the TargetAccountId property is set.
        /// </summary>
        internal bool IsSetTargetAccountId() => this.TargetAccountId != null;
    }
}
