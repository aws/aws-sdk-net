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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Details about the latest launch of an application.
    /// </summary>
    public partial class LaunchDetails
    {
        private DateTime? _latestLaunchTime;
        private string _stackId;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property LatestLaunchTime. 
        /// <para>
        /// Latest time this application was launched successfully.
        /// </para>
        /// </summary>
        public DateTime LatestLaunchTime
        {
            get { return this._latestLaunchTime.GetValueOrDefault(); }
            set { this._latestLaunchTime = value; }
        }

        // Check to see if LatestLaunchTime property is set
        internal bool IsSetLatestLaunchTime()
        {
            return this._latestLaunchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// Identifier of the latest stack launched for this application.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// Name of the latest stack launched for this application.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

    }
}