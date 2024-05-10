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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines the stairs traffic pattern for an Inference Recommender load test. This pattern
    /// type consists of multiple steps where the number of users increases at each step.
    /// 
    ///  
    /// <para>
    /// Specify either the stairs or phases traffic pattern.
    /// </para>
    /// </summary>
    public partial class Stairs
    {
        private int? _durationInSeconds;
        private int? _numberOfSteps;
        private int? _usersPerStep;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// Defines how long each traffic step should be.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfSteps. 
        /// <para>
        /// Specifies how many steps to perform during traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? NumberOfSteps
        {
            get { return this._numberOfSteps; }
            set { this._numberOfSteps = value; }
        }

        // Check to see if NumberOfSteps property is set
        internal bool IsSetNumberOfSteps()
        {
            return this._numberOfSteps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsersPerStep. 
        /// <para>
        /// Specifies how many new users to spawn in each step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public int? UsersPerStep
        {
            get { return this._usersPerStep; }
            set { this._usersPerStep = value; }
        }

        // Check to see if UsersPerStep property is set
        internal bool IsSetUsersPerStep()
        {
            return this._usersPerStep.HasValue; 
        }

    }
}