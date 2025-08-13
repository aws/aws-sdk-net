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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Container for the parameters to the CreateQuantumTask operation.
    /// Creates a quantum task.
    /// </summary>
    public partial class CreateQuantumTaskRequest : AmazonBraketRequest
    {
        private string _action;
        private List<Association> _associations = AWSConfigs.InitializeCollections ? new List<Association>() : null;
        private string _clientToken;
        private string _deviceArn;
        private string _deviceParameters;
        private string _jobToken;
        private string _outputs3Bucket;
        private string _outputs3KeyPrefix;
        private long? _shots;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action associated with the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        /// The list of Amazon Braket resources associated with the quantum task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Association> Associations
        {
            get { return this._associations; }
            set { this._associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this._associations != null && (this._associations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token associated with the request.
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
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device to run the quantum task on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceParameters. 
        /// <para>
        /// The parameters for the device to run the quantum task on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=48000)]
        public string DeviceParameters
        {
            get { return this._deviceParameters; }
            set { this._deviceParameters = value; }
        }

        // Check to see if DeviceParameters property is set
        internal bool IsSetDeviceParameters()
        {
            return this._deviceParameters != null;
        }

        /// <summary>
        /// Gets and sets the property JobToken. 
        /// <para>
        /// The token for an Amazon Braket hybrid job that associates it with the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string JobToken
        {
            get { return this._jobToken; }
            set { this._jobToken = value; }
        }

        // Check to see if JobToken property is set
        internal bool IsSetJobToken()
        {
            return this._jobToken != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3Bucket. 
        /// <para>
        /// The S3 bucket to store quantum task result files in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string OutputS3Bucket
        {
            get { return this._outputs3Bucket; }
            set { this._outputs3Bucket = value; }
        }

        // Check to see if OutputS3Bucket property is set
        internal bool IsSetOutputS3Bucket()
        {
            return this._outputs3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3KeyPrefix. 
        /// <para>
        /// The key prefix for the location in the S3 bucket to store quantum task results in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string OutputS3KeyPrefix
        {
            get { return this._outputs3KeyPrefix; }
            set { this._outputs3KeyPrefix = value; }
        }

        // Check to see if OutputS3KeyPrefix property is set
        internal bool IsSetOutputS3KeyPrefix()
        {
            return this._outputs3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Shots. 
        /// <para>
        /// The number of shots to use for the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Shots
        {
            get { return this._shots; }
            set { this._shots = value; }
        }

        // Check to see if Shots property is set
        internal bool IsSetShots()
        {
            return this._shots.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be added to the quantum task you're creating.
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