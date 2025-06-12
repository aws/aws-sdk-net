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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The parameters that you can use to configure a <a href="https://docs.aws.amazon.com/redshift-serverless/latest/APIReference/API_CreateScheduledAction.html">scheduled
    /// action</a> to create a snapshot. For more information about creating a scheduled action,
    /// see <a href="https://docs.aws.amazon.com/redshift-serverless/latest/APIReference/API_CreateScheduledAction.html">CreateScheduledAction</a>.
    /// </summary>
    public partial class CreateSnapshotScheduleActionParameters
    {
        private string _namespaceName;
        private int? _retentionPeriod;
        private string _snapshotNamePrefix;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace for which you want to configure a scheduled action to create
        /// a snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The retention period of the snapshot created by the scheduled action.
        /// </para>
        /// </summary>
        public int? RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotNamePrefix. 
        /// <para>
        /// A string prefix that is attached to the name of the snapshot created by the scheduled
        /// action. The final name of the snapshot is the string prefix appended by the date and
        /// time of when the snapshot was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=235)]
        public string SnapshotNamePrefix
        {
            get { return this._snapshotNamePrefix; }
            set { this._snapshotNamePrefix = value; }
        }

        // Check to see if SnapshotNamePrefix property is set
        internal bool IsSetSnapshotNamePrefix()
        {
            return this._snapshotNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of <a href="https://docs.aws.amazon.com/redshift-serverless/latest/APIReference/API_Tag.html">Tag
        /// objects</a> to associate with the snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}