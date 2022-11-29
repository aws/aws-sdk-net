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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of a finding aggregation by Amazon EC2 instance.
    /// </summary>
    public partial class Ec2InstanceAggregationResponse
    {
        private string _accountId;
        private string _ami;
        private string _instanceId;
        private Dictionary<string, string> _instanceTags = new Dictionary<string, string>();
        private long? _networkFindings;
        private string _operatingSystem;
        private SeverityCounts _severityCounts;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account for the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Ami. 
        /// <para>
        /// The Amazon Machine Image (AMI) of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string Ami
        {
            get { return this._ami; }
            set { this._ami = value; }
        }

        // Check to see if Ami property is set
        internal bool IsSetAmi()
        {
            return this._ami != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon EC2 instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTags. 
        /// <para>
        /// The tags attached to the instance.
        /// </para>
        /// </summary>
        public Dictionary<string, string> InstanceTags
        {
            get { return this._instanceTags; }
            set { this._instanceTags = value; }
        }

        // Check to see if InstanceTags property is set
        internal bool IsSetInstanceTags()
        {
            return this._instanceTags != null && this._instanceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkFindings. 
        /// <para>
        /// The number of network findings for the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public long NetworkFindings
        {
            get { return this._networkFindings.GetValueOrDefault(); }
            set { this._networkFindings = value; }
        }

        // Check to see if NetworkFindings property is set
        internal bool IsSetNetworkFindings()
        {
            return this._networkFindings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// An object that contains the count of matched findings per severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts
        {
            get { return this._severityCounts; }
            set { this._severityCounts = value; }
        }

        // Check to see if SeverityCounts property is set
        internal bool IsSetSeverityCounts()
        {
            return this._severityCounts != null;
        }

    }
}