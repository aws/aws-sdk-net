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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The input configuration of the recommendation job.
    /// </summary>
    public partial class RecommendationJobInputConfig
    {
        private List<EndpointInputConfiguration> _endpointConfigurations = new List<EndpointInputConfiguration>();
        private int? _jobDurationInSeconds;
        private string _modelPackageVersionArn;
        private RecommendationJobResourceLimit _resourceLimit;
        private TrafficPattern _trafficPattern;

        /// <summary>
        /// Gets and sets the property EndpointConfigurations. 
        /// <para>
        /// Specifies the endpoint configuration to use for a job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EndpointInputConfiguration> EndpointConfigurations
        {
            get { return this._endpointConfigurations; }
            set { this._endpointConfigurations = value; }
        }

        // Check to see if EndpointConfigurations property is set
        internal bool IsSetEndpointConfigurations()
        {
            return this._endpointConfigurations != null && this._endpointConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobDurationInSeconds. 
        /// <para>
        /// Specifies the maximum duration of the job, in seconds.&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int JobDurationInSeconds
        {
            get { return this._jobDurationInSeconds.GetValueOrDefault(); }
            set { this._jobDurationInSeconds = value; }
        }

        // Check to see if JobDurationInSeconds property is set
        internal bool IsSetJobDurationInSeconds()
        {
            return this._jobDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelPackageVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a versioned model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelPackageVersionArn
        {
            get { return this._modelPackageVersionArn; }
            set { this._modelPackageVersionArn = value; }
        }

        // Check to see if ModelPackageVersionArn property is set
        internal bool IsSetModelPackageVersionArn()
        {
            return this._modelPackageVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceLimit. 
        /// <para>
        /// Defines the resource limit of the job.
        /// </para>
        /// </summary>
        public RecommendationJobResourceLimit ResourceLimit
        {
            get { return this._resourceLimit; }
            set { this._resourceLimit = value; }
        }

        // Check to see if ResourceLimit property is set
        internal bool IsSetResourceLimit()
        {
            return this._resourceLimit != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPattern. 
        /// <para>
        /// Specifies the traffic pattern of the job.
        /// </para>
        /// </summary>
        public TrafficPattern TrafficPattern
        {
            get { return this._trafficPattern; }
            set { this._trafficPattern = value; }
        }

        // Check to see if TrafficPattern property is set
        internal bool IsSetTrafficPattern()
        {
            return this._trafficPattern != null;
        }

    }
}