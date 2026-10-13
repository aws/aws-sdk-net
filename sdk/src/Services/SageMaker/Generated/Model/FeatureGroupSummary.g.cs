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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The name, ARN, <c>CreationTime</c>, <c>FeatureGroup</c> values, <c>LastUpdatedTime</c>
    /// and <c>EnableOnlineStorage</c> status of a <c>FeatureGroup</c>.
    /// </summary>
    public partial class FeatureGroupSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating the time of creation time of the <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// Unique identifier for the <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string FeatureGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupArn property is set.
        /// </summary>
        internal bool IsSetFeatureGroupArn() => this.FeatureGroupArn != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FeatureGroupName { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupName property is set.
        /// </summary>
        internal bool IsSetFeatureGroupName() => this.FeatureGroupName != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupStatus. 
        /// <para>
        /// The status of a FeatureGroup. The status can be any of the following: <c>Creating</c>,
        /// <c>Created</c>, <c>CreateFail</c>, <c>Deleting</c> or <c>DetailFail</c>. 
        /// </para>
        /// </summary>
        public FeatureGroupStatus FeatureGroupStatus { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupStatus property is set.
        /// </summary>
        internal bool IsSetFeatureGroupStatus() => this.FeatureGroupStatus != null;

        /// <summary>
        /// Gets and sets the property OfflineStoreStatus. 
        /// <para>
        /// Notifies you if replicating data into the <c>OfflineStore</c> has failed. Returns
        /// either: <c>Active</c> or <c>Blocked</c>.
        /// </para>
        /// </summary>
        public OfflineStoreStatus OfflineStoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the OfflineStoreStatus property is set.
        /// </summary>
        internal bool IsSetOfflineStoreStatus() => this.OfflineStoreStatus != null;
    }
}
