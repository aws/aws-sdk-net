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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// A service configuration associated with a resource group. The configuration options
    /// are determined by the Amazon Web Services service that defines the <code>Type</code>,
    /// and specifies which resources can be included in the group. You can add a service
    /// configuration when you create the group by using <a>CreateGroup</a>, or later by using
    /// the <a>PutGroupConfiguration</a> operation. For details about group service configuration
    /// syntax, see <a href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
    /// configurations for resource groups</a>.
    /// </summary>
    public partial class GroupConfiguration
    {
        private List<GroupConfigurationItem> _configuration = new List<GroupConfigurationItem>();
        private string _failureReason;
        private List<GroupConfigurationItem> _proposedConfiguration = new List<GroupConfigurationItem>();
        private GroupConfigurationStatus _status;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration currently associated with the group and in effect.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<GroupConfigurationItem> Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null && this._configuration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If present, the reason why a request to update the group configuration failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property ProposedConfiguration. 
        /// <para>
        /// If present, the new configuration that is in the process of being applied to the group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<GroupConfigurationItem> ProposedConfiguration
        {
            get { return this._proposedConfiguration; }
            set { this._proposedConfiguration = value; }
        }

        // Check to see if ProposedConfiguration property is set
        internal bool IsSetProposedConfiguration()
        {
            return this._proposedConfiguration != null && this._proposedConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of an attempt to update the group configuration.
        /// </para>
        /// </summary>
        public GroupConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}