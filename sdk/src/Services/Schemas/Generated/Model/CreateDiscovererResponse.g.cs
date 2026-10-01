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

namespace Amazon.Schemas.Model
{
    /// <summary>
    /// This is the response object from the CreateDiscoverer operation.
    /// </summary>
    public partial class CreateDiscovererResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CrossAccount. 
        /// <para>
        /// The Status if the discoverer will discover schemas from events sent from another account.
        /// </para>
        /// </summary>
        public bool? CrossAccount { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccount property is set.
        /// </summary>
        internal bool IsSetCrossAccount() => this.CrossAccount.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the discoverer.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiscovererArn. 
        /// <para>
        /// The ARN of the discoverer.
        /// </para>
        /// </summary>
        public string DiscovererArn { get; set; }

        /// <summary>
        /// Checks to see if the DiscovererArn property is set.
        /// </summary>
        internal bool IsSetDiscovererArn() => this.DiscovererArn != null;

        /// <summary>
        /// Gets and sets the property DiscovererId. 
        /// <para>
        /// The ID of the discoverer.
        /// </para>
        /// </summary>
        public string DiscovererId { get; set; }

        /// <summary>
        /// Checks to see if the DiscovererId property is set.
        /// </summary>
        internal bool IsSetDiscovererId() => this.DiscovererId != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the event bus.
        /// </para>
        /// </summary>
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the discoverer.
        /// </para>
        /// </summary>
        public DiscovererState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
