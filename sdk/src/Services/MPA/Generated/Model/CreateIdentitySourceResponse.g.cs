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

namespace Amazon.MPA.Model
{
    /// <summary>
    /// This is the response object from the CreateIdentitySource operation.
    /// </summary>
    public partial class CreateIdentitySourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Timestamp when the identity source was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property IdentitySourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the identity source that was created.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string IdentitySourceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentitySourceArn property is set.
        /// </summary>
        internal bool IsSetIdentitySourceArn() => this.IdentitySourceArn != null;

        /// <summary>
        /// Gets and sets the property IdentitySourceType. 
        /// <para>
        /// The type of resource that provided identities to the identity source. For example,
        /// an IAM Identity Center instance.
        /// </para>
        /// </summary>
        public IdentitySourceType IdentitySourceType { get; set; }

        /// <summary>
        /// Checks to see if the IdentitySourceType property is set.
        /// </summary>
        internal bool IsSetIdentitySourceType() => this.IdentitySourceType != null;
    }
}
