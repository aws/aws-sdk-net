/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mobile.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeProject operation.
    /// Gets details about a project in AWS Mobile Hub.
    /// </summary>
    public partial class DescribeProjectRequest : AmazonMobileRequest
    {
        private string _projectId;
        private bool? _syncFromResources;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        ///  Unique project identifier. 
        /// </para>
        /// </summary>
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property SyncFromResources. 
        /// <para>
        ///  If set to true, causes AWS Mobile Hub to synchronize information from other services,
        /// e.g., update state of AWS CloudFormation stacks in the AWS Mobile Hub project. 
        /// </para>
        /// </summary>
        public bool SyncFromResources
        {
            get { return this._syncFromResources.GetValueOrDefault(); }
            set { this._syncFromResources = value; }
        }

        // Check to see if SyncFromResources property is set
        internal bool IsSetSyncFromResources()
        {
            return this._syncFromResources.HasValue; 
        }

    }
}