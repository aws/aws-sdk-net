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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Contains a summary of information about a domain.
    /// </summary>
    public partial class DomainSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the domain.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the domain was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property DomainStatus. 
        /// <para>
        /// The current status of the domain.
        /// </para>
        /// </summary>
        public DomainStatus DomainStatus { get; set; }

        /// <summary>
        /// Checks to see if the DomainStatus property is set.
        /// </summary>
        internal bool IsSetDomainStatus() => this.DomainStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The client-provided name for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The server-side encryption configuration containing the KMS key identifier you want
        /// Voice ID to use to encrypt your data.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionConfiguration() => this.ServerSideEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionUpdateDetails. 
        /// <para>
        /// Details about the most recent server-side encryption configuration update. When the
        /// server-side encryption configuration is changed, dependency on the old KMS key is
        /// removed through an asynchronous process. When this update is complete, the domain's
        /// data can only be accessed using the new KMS key.
        /// </para>
        /// </summary>
        public ServerSideEncryptionUpdateDetails ServerSideEncryptionUpdateDetails { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionUpdateDetails property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionUpdateDetails() => this.ServerSideEncryptionUpdateDetails != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the domain was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WatchlistDetails. 
        /// <para>
        /// Provides information about <c>watchlistDetails</c> and <c>DefaultWatchlistID</c>.
        /// 
        /// </para>
        /// </summary>
        public WatchlistDetails WatchlistDetails { get; set; }

        /// <summary>
        /// Checks to see if the WatchlistDetails property is set.
        /// </summary>
        internal bool IsSetWatchlistDetails() => this.WatchlistDetails != null;
    }
}
