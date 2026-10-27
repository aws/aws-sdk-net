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

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// A count of noncompliant resources.
    /// </summary>
    public partial class Summary
    {
        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The timestamp that shows when this summary was generated in this Region. 
        /// </para>
        /// </summary>
        public string LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated != null;

        /// <summary>
        /// Gets and sets the property NonCompliantResources. 
        /// <para>
        /// The count of noncompliant resources.
        /// </para>
        /// </summary>
        public long? NonCompliantResources { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantResources property is set.
        /// </summary>
        internal bool IsSetNonCompliantResources() => this.NonCompliantResources.HasValue;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that the summary applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Amazon Web Services resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The account identifier or the root identifier of the organization. If you don't know
        /// the root ID, you can call the Organizations <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_ListRoots.html">ListRoots</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 68)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;

        /// <summary>
        /// Gets and sets the property TargetIdType. 
        /// <para>
        /// Whether the target is an account, an OU, or the organization root.
        /// </para>
        /// </summary>
        public TargetIdType TargetIdType { get; set; }

        /// <summary>
        /// Checks to see if the TargetIdType property is set.
        /// </summary>
        internal bool IsSetTargetIdType() => this.TargetIdType != null;
    }
}
