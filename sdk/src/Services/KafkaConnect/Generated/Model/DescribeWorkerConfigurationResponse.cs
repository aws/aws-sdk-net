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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeWorkerConfiguration operation.
    /// </summary>
    public partial class DescribeWorkerConfigurationResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private WorkerConfigurationRevisionDescription _latestRevision;
        private string _name;
        private string _workerConfigurationArn;
        private WorkerConfigurationState _workerConfigurationState;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the worker configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the worker configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest revision of the custom configuration.
        /// </para>
        /// </summary>
        public WorkerConfigurationRevisionDescription LatestRevision
        {
            get { return this._latestRevision; }
            set { this._latestRevision = value; }
        }

        // Check to see if LatestRevision property is set
        internal bool IsSetLatestRevision()
        {
            return this._latestRevision != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the worker configuration.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom configuration.
        /// </para>
        /// </summary>
        public string WorkerConfigurationArn
        {
            get { return this._workerConfigurationArn; }
            set { this._workerConfigurationArn = value; }
        }

        // Check to see if WorkerConfigurationArn property is set
        internal bool IsSetWorkerConfigurationArn()
        {
            return this._workerConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerConfigurationState. 
        /// <para>
        /// The state of the worker configuration.
        /// </para>
        /// </summary>
        public WorkerConfigurationState WorkerConfigurationState
        {
            get { return this._workerConfigurationState; }
            set { this._workerConfigurationState = value; }
        }

        // Check to see if WorkerConfigurationState property is set
        internal bool IsSetWorkerConfigurationState()
        {
            return this._workerConfigurationState != null;
        }

    }
}