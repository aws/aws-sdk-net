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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
    /// Container for the parameters to the CreateFleet operation.
    /// Creates a fleet. Fleets gather information relating to compute, or capacity, for renders
    /// within your farms. You can choose to manage your own capacity or opt to have fleets
    /// fully managed by Deadline Cloud.
    /// </summary>
    public partial class CreateFleetRequest : AmazonDeadlineRequest
    {
        private string _clientToken;
        private FleetConfiguration _configuration;
        private string _description;
        private string _displayName;
        private string _farmId;
        private HostConfiguration _hostConfiguration;
        private int? _maxWorkerCount;
        private int? _minWorkerCount;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique token which the server uses to recognize retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration settings for the fleet. Customer managed fleets are self-managed.
        /// Service managed Amazon EC2 fleets are managed by Deadline Cloud.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FleetConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

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
        [AWSProperty(Sensitive=true, Min=0, Max=100)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the farm to connect to the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property HostConfiguration. 
        /// <para>
        /// Provides a script that runs as a worker is starting up that you can use to provide
        /// additional configuration for workers in your fleet.
        /// </para>
        /// </summary>
        public HostConfiguration HostConfiguration
        {
            get { return this._hostConfiguration; }
            set { this._hostConfiguration = value; }
        }

        // Check to see if HostConfiguration property is set
        internal bool IsSetHostConfiguration()
        {
            return this._hostConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. 
        /// <para>
        /// The maximum number of workers for the fleet.
        /// </para>
        ///  
        /// <para>
        /// Deadline Cloud limits the number of workers to less than or equal to the fleet's maximum
        /// worker count. The service maintains eventual consistency for the worker count. If
        /// you make multiple rapid calls to <c>CreateWorker</c> before the field updates, you
        /// might exceed your fleet's maximum worker count. For example, if your <c>maxWorkerCount</c>
        /// is 10 and you currently have 9 workers, making two quick <c>CreateWorker</c> calls
        /// might successfully create 2 workers instead of 1, resulting in 11 total workers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? MaxWorkerCount
        {
            get { return this._maxWorkerCount; }
            set { this._maxWorkerCount = value; }
        }

        // Check to see if MaxWorkerCount property is set
        internal bool IsSetMaxWorkerCount()
        {
            return this._maxWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinWorkerCount. 
        /// <para>
        /// The minimum number of workers for the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MinWorkerCount
        {
            get { return this._minWorkerCount; }
            set { this._minWorkerCount = value; }
        }

        // Check to see if MinWorkerCount property is set
        internal bool IsSetMinWorkerCount()
        {
            return this._minWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN for the role that the fleet's workers will use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a tag key and a tag value. Tag keys and values are both required,
        /// but tag values can be empty strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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