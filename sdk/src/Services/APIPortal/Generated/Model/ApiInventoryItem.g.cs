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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// An API found by discovery.
    /// </summary>
    public partial class ApiInventoryItem
    {
        /// <summary>
        /// Gets and sets the property AccountId. The AWS account ID that owns the API.
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Classification.
        /// </summary>
        public Classification Classification { get; set; }

        /// <summary>
        /// Checks to see if the Classification property is set.
        /// </summary>
        internal bool IsSetClassification() => this.Classification != null;

        /// <summary>
        /// Gets and sets the property DiscoverySource.
        /// </summary>
        [AWSProperty(Required = true)]
        public DiscoverySource DiscoverySource { get; set; }

        /// <summary>
        /// Checks to see if the DiscoverySource property is set.
        /// </summary>
        internal bool IsSetDiscoverySource() => this.DiscoverySource != null;

        /// <summary>
        /// Gets and sets the property FirstSeen. When discovery first observed the API.
        /// </summary>
        public DateTime? FirstSeen { get; set; }

        /// <summary>
        /// Checks to see if the FirstSeen property is set.
        /// </summary>
        internal bool IsSetFirstSeen() => this.FirstSeen.HasValue;

        /// <summary>
        /// Gets and sets the property Host.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property LastSeen. When discovery most recently observed the API.
        /// </summary>
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// Checks to see if the LastSeen property is set.
        /// </summary>
        internal bool IsSetLastSeen() => this.LastSeen.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedBy.
        /// </summary>
        public ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property Method. The HTTP method of the API.
        /// </summary>
        [AWSProperty(Required = true)]
        public HttpMethod Method { get; set; }

        /// <summary>
        /// Checks to see if the Method property is set.
        /// </summary>
        internal bool IsSetMethod() => this.Method != null;

        /// <summary>
        /// Gets and sets the property Path. The request path of the API.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Port. The port the API listens on, from 0 to 65535.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Region. The AWS Region the API was discovered in.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. The ARN of the resource that serves the API,
        /// such as an API Gateway stage or a load balancer.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Visibility.
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;

        /// <summary>
        /// Gets and sets the property WafStatus.
        /// </summary>
        public WafStatus WafStatus { get; set; }

        /// <summary>
        /// Checks to see if the WafStatus property is set.
        /// </summary>
        internal bool IsSetWafStatus() => this.WafStatus != null;

        /// <summary>
        /// Gets and sets the property Workloads. AI protocols seen in this API's traffic, each
        /// listed at most once. Absent when none has been reported, which includes an account
        /// that has not enabled AI discovery.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Workloads { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Workloads property is set.
        /// </summary>
        internal bool IsSetWorkloads() => this.Workloads != null && (this.Workloads.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
