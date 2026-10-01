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
    /// Contains details for an identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
    /// source</a> in the <i>Multi-party approval User Guide</i>.
    /// </summary>
    public partial class IdentitySourceForList
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
        /// Amazon Resource Name (ARN) for the identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string IdentitySourceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentitySourceArn property is set.
        /// </summary>
        internal bool IsSetIdentitySourceArn() => this.IdentitySourceArn != null;

        /// <summary>
        /// Gets and sets the property IdentitySourceParameters. 
        /// <para>
        /// A <c>IdentitySourceParametersForList</c> object. Contains details for the resource
        /// that provides identities to the identity source. For example, an IAM Identity Center
        /// instance.
        /// </para>
        /// </summary>
        public IdentitySourceParametersForList IdentitySourceParameters { get; set; }

        /// <summary>
        /// Checks to see if the IdentitySourceParameters property is set.
        /// </summary>
        internal bool IsSetIdentitySourceParameters() => this.IdentitySourceParameters != null;

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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the identity source. For example, if the identity source is <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        public IdentitySourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Status code of the identity source.
        /// </para>
        /// </summary>
        public IdentitySourceStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Message describing the status for the identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
