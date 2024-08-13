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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The criteria that determine when and how a job abort takes place.
    /// </summary>
    public partial class AbortCriteria
    {
        private AbortAction _action;
        private JobExecutionFailureType _failureType;
        private int? _minNumberOfExecutedThings;
        private double? _thresholdPercentage;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of job action to take to initiate the job abort.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AbortAction Action
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
        /// Gets and sets the property FailureType. 
        /// <para>
        /// The type of job execution failures that can initiate a job abort.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobExecutionFailureType FailureType
        {
            get { return this._failureType; }
            set { this._failureType = value; }
        }

        // Check to see if FailureType property is set
        internal bool IsSetFailureType()
        {
            return this._failureType != null;
        }

        /// <summary>
        /// Gets and sets the property MinNumberOfExecutedThings. 
        /// <para>
        /// The minimum number of things which must receive job execution notifications before
        /// the job can be aborted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MinNumberOfExecutedThings
        {
            get { return this._minNumberOfExecutedThings; }
            set { this._minNumberOfExecutedThings = value; }
        }

        // Check to see if MinNumberOfExecutedThings property is set
        internal bool IsSetMinNumberOfExecutedThings()
        {
            return this._minNumberOfExecutedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdPercentage. 
        /// <para>
        /// The minimum percentage of job execution failures that must occur to initiate the job
        /// abort.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services IoT Core supports up to two digits after the decimal (for example,
        /// 10.9 and 10.99, but not 10.999).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public double? ThresholdPercentage
        {
            get { return this._thresholdPercentage; }
            set { this._thresholdPercentage = value; }
        }

        // Check to see if ThresholdPercentage property is set
        internal bool IsSetThresholdPercentage()
        {
            return this._thresholdPercentage.HasValue; 
        }

    }
}