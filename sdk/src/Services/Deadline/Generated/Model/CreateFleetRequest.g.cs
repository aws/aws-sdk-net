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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFleet operation. Creates a fleet. Fleets
    /// gather information relating to compute, or capacity, for renders within your farms.
    /// You can choose to manage your own capacity or opt to have fleets fully managed by
    /// Deadline Cloud.
    /// </summary>
    public partial class CreateFleetRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. The unique token which the server uses to
        /// recognize retries of the same request.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. The configuration settings for the fleet.
        /// Customer managed fleets are self-managed. Service managed Amazon EC2 fleets are managed
        /// by Deadline Cloud.
        /// </summary>
        [AWSProperty(Required = true)]
        public FleetConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the farm to connect to the fleet.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property HostConfiguration. Provides a script that runs as a worker
        /// is starting up that you can use to provide additional configuration for workers in
        /// your fleet.
        /// </summary>
        public HostConfiguration HostConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HostConfiguration property is set.
        /// </summary>
        internal bool IsSetHostConfiguration() => this.HostConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. The maximum number of workers for the fleet.
        /// Deadline Cloud limits the number of workers to less than or equal to the fleet's maximum
        /// worker count. The service maintains eventual consistency for the worker count. If
        /// you make multiple rapid calls to <c>CreateWorker</c> before the field updates, you
        /// might exceed your fleet's maximum worker count. For example, if your <c>maxWorkerCount</c>
        /// is 10 and you currently have 9 workers, making two quick <c>CreateWorker</c> calls
        /// might successfully create 2 workers instead of 1, resulting in 11 total workers.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? MaxWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxWorkerCount property is set.
        /// </summary>
        internal bool IsSetMaxWorkerCount() => this.MaxWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinWorkerCount. The minimum number of workers for the fleet.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MinWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MinWorkerCount property is set.
        /// </summary>
        internal bool IsSetMinWorkerCount() => this.MinWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. The IAM role ARN for the role that the fleet's
        /// workers will use.
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. Each tag consists of a tag key and a tag value. Tag
        /// keys and values are both required, but tag values can be empty strings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
