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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains criteria that define when and how to cancel a job.
    /// 
    ///  
    /// <para>
    /// The deployment stops if the following conditions are true:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// The number of things that receive the deployment exceeds the <c>minNumberOfExecutedThings</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The percentage of failures with type <c>failureType</c> exceeds the <c>thresholdPercentage</c>.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class IoTJobAbortCriteria
    {
        private IoTJobAbortAction _action;
        private IoTJobExecutionFailureType _failureType;
        private int? _minNumberOfExecutedThings;
        private double? _thresholdPercentage;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform when the criteria are met.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IoTJobAbortAction Action
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
        /// The type of job deployment failure that can cancel a job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IoTJobExecutionFailureType FailureType
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
        /// The minimum number of things that receive the configuration before the job can cancel.
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
        /// The minimum percentage of <c>failureType</c> failures that occur before the job can
        /// cancel.
        /// </para>
        ///  
        /// <para>
        /// This parameter supports up to two digits after the decimal (for example, you can specify
        /// <c>10.9</c> or <c>10.99</c>, but not <c>10.999</c>).
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