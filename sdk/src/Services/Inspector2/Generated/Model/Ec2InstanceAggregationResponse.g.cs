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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of a finding aggregation by Amazon EC2 instance.
    /// </summary>
    public partial class Ec2InstanceAggregationResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account for the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Ami. 
        /// <para>
        /// The Amazon Machine Image (AMI) of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string Ami { get; set; }

        /// <summary>
        /// Checks to see if the Ami property is set.
        /// </summary>
        internal bool IsSetAmi() => this.Ami != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon EC2 instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceTags. 
        /// <para>
        /// The tags attached to the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> InstanceTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTags property is set.
        /// </summary>
        internal bool IsSetInstanceTags() => this.InstanceTags != null && (this.InstanceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkFindings. 
        /// <para>
        /// The number of network findings for the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public long? NetworkFindings { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFindings property is set.
        /// </summary>
        internal bool IsSetNetworkFindings() => this.NetworkFindings.HasValue;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// An object that contains the count of matched findings per severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts { get; set; }

        /// <summary>
        /// Checks to see if the SeverityCounts property is set.
        /// </summary>
        internal bool IsSetSeverityCounts() => this.SeverityCounts != null;
    }
}
