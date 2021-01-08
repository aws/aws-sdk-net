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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The name, Arn, <code>CreationTime</code>, <code>FeatureGroup</code> values, <code>LastUpdatedTime</code>
    /// and <code>EnableOnlineStorage</code> status of a <code>FeatureGroup</code>.
    /// </summary>
    public partial class FeatureGroupSummary
    {
        private DateTime? _creationTime;
        private string _featureGroupArn;
        private string _featureGroupName;
        private FeatureGroupStatus _featureGroupStatus;
        private OfflineStoreStatus _offlineStoreStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating the time of creation time of the <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// Unique identifier for the <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FeatureGroupArn
        {
            get { return this._featureGroupArn; }
            set { this._featureGroupArn = value; }
        }

        // Check to see if FeatureGroupArn property is set
        internal bool IsSetFeatureGroupArn()
        {
            return this._featureGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupStatus. 
        /// <para>
        /// The status of a FeatureGroup. The status can be any of the following: <code>Creating</code>,
        /// <code>Created</code>, <code>CreateFail</code>, <code>Deleting</code> or <code>DetailFail</code>.
        /// 
        /// </para>
        /// </summary>
        public FeatureGroupStatus FeatureGroupStatus
        {
            get { return this._featureGroupStatus; }
            set { this._featureGroupStatus = value; }
        }

        // Check to see if FeatureGroupStatus property is set
        internal bool IsSetFeatureGroupStatus()
        {
            return this._featureGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OfflineStoreStatus. 
        /// <para>
        /// Notifies you if replicating data into the <code>OfflineStore</code> has failed. Returns
        /// either: <code>Active</code> or <code>Blocked</code>.
        /// </para>
        /// </summary>
        public OfflineStoreStatus OfflineStoreStatus
        {
            get { return this._offlineStoreStatus; }
            set { this._offlineStoreStatus = value; }
        }

        // Check to see if OfflineStoreStatus property is set
        internal bool IsSetOfflineStoreStatus()
        {
            return this._offlineStoreStatus != null;
        }

    }
}