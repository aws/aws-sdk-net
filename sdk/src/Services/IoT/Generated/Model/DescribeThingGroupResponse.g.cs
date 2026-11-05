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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeThingGroup operation.
    /// </summary>
    public partial class DescribeThingGroupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The dynamic thing group index name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The dynamic thing group search query string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property QueryVersion. 
        /// <para>
        /// The dynamic thing group query version.
        /// </para>
        /// </summary>
        public string QueryVersion { get; set; }

        /// <summary>
        /// Checks to see if the QueryVersion property is set.
        /// </summary>
        internal bool IsSetQueryVersion() => this.QueryVersion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The dynamic thing group status.
        /// </para>
        /// </summary>
        public DynamicGroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ThingGroupArn. 
        /// <para>
        /// The thing group ARN.
        /// </para>
        /// </summary>
        public string ThingGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupArn property is set.
        /// </summary>
        internal bool IsSetThingGroupArn() => this.ThingGroupArn != null;

        /// <summary>
        /// Gets and sets the property ThingGroupId. 
        /// <para>
        /// The thing group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupId property is set.
        /// </summary>
        internal bool IsSetThingGroupId() => this.ThingGroupId != null;

        /// <summary>
        /// Gets and sets the property ThingGroupMetadata. 
        /// <para>
        /// Thing group metadata.
        /// </para>
        /// </summary>
        public ThingGroupMetadata ThingGroupMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupMetadata property is set.
        /// </summary>
        internal bool IsSetThingGroupMetadata() => this.ThingGroupMetadata != null;

        /// <summary>
        /// Gets and sets the property ThingGroupName. 
        /// <para>
        /// The name of the thing group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupName property is set.
        /// </summary>
        internal bool IsSetThingGroupName() => this.ThingGroupName != null;

        /// <summary>
        /// Gets and sets the property ThingGroupProperties. 
        /// <para>
        /// The thing group properties.
        /// </para>
        /// </summary>
        public ThingGroupProperties ThingGroupProperties { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupProperties property is set.
        /// </summary>
        internal bool IsSetThingGroupProperties() => this.ThingGroupProperties != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the thing group.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
