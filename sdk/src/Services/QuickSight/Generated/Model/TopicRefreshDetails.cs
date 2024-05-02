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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The details about the refresh of a topic.
    /// </summary>
    public partial class TopicRefreshDetails
    {
        private string _refreshArn;
        private string _refreshId;
        private TopicRefreshStatus _refreshStatus;

        /// <summary>
        /// Gets and sets the property RefreshArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the topic refresh.
        /// </para>
        /// </summary>
        public string RefreshArn
        {
            get { return this._refreshArn; }
            set { this._refreshArn = value; }
        }

        // Check to see if RefreshArn property is set
        internal bool IsSetRefreshArn()
        {
            return this._refreshArn != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshId. 
        /// <para>
        /// The ID of the refresh, which occurs as a result of topic creation or topic update.
        /// </para>
        /// </summary>
        public string RefreshId
        {
            get { return this._refreshId; }
            set { this._refreshId = value; }
        }

        // Check to see if RefreshId property is set
        internal bool IsSetRefreshId()
        {
            return this._refreshId != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshStatus. 
        /// <para>
        /// The status of the refresh job that indicates whether the job is still running, completed
        /// successfully, or failed.
        /// </para>
        /// </summary>
        public TopicRefreshStatus RefreshStatus
        {
            get { return this._refreshStatus; }
            set { this._refreshStatus = value; }
        }

        // Check to see if RefreshStatus property is set
        internal bool IsSetRefreshStatus()
        {
            return this._refreshStatus != null;
        }

    }
}