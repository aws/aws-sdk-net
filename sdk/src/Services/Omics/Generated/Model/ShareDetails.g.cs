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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// The details of a resource share.
    /// </summary>
    public partial class ShareDetails
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the resource share was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The account ID for the data owner. The owner creates the resource share.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PrincipalSubscriber. 
        /// <para>
        /// The principal subscriber is the account that is sharing the resource.
        /// </para>
        /// </summary>
        public string PrincipalSubscriber { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalSubscriber property is set.
        /// </summary>
        internal bool IsSetPrincipalSubscriber() => this.PrincipalSubscriber != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Arn of the shared resource. 
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the shared resource. 
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ShareId. 
        /// <para>
        /// The ID of the resource share.
        /// </para>
        /// </summary>
        public string ShareId { get; set; }

        /// <summary>
        /// Checks to see if the ShareId property is set.
        /// </summary>
        internal bool IsSetShareId() => this.ShareId != null;

        /// <summary>
        /// Gets and sets the property ShareName. 
        /// <para>
        /// The name of the resource share.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ShareName { get; set; }

        /// <summary>
        /// Checks to see if the ShareName property is set.
        /// </summary>
        internal bool IsSetShareName() => this.ShareName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the share.
        /// </para>
        /// </summary>
        public ShareStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for a resource share. It provides additional details about the
        /// share status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp of the resource share update.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
