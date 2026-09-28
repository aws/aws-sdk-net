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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of the published asset for which the subscription grant is created.
    /// </summary>
    public partial class SubscribedListing
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Item. 
        /// <para>
        /// The published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscribedListingItem Item { get; set; }

        /// <summary>
        /// Checks to see if the Item property is set.
        /// </summary>
        internal bool IsSetItem() => this.Item != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerProjectId. 
        /// <para>
        /// The identifier of the project of the published asset for which the subscription grant
        /// is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwnerProjectId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerProjectId property is set.
        /// </summary>
        internal bool IsSetOwnerProjectId() => this.OwnerProjectId != null;

        /// <summary>
        /// Gets and sets the property OwnerProjectName. 
        /// <para>
        /// The name of the project that owns the published asset for which the subscription grant
        /// is created.
        /// </para>
        /// </summary>
        public string OwnerProjectName { get; set; }

        /// <summary>
        /// Checks to see if the OwnerProjectName property is set.
        /// </summary>
        internal bool IsSetOwnerProjectName() => this.OwnerProjectName != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;
    }
}
