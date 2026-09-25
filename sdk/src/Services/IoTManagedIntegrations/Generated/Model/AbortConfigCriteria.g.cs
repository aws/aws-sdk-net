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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing one abort config criteria.
    /// </summary>
    public partial class AbortConfigCriteria
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action taken by the abort configuration.
        /// </para>
        /// </summary>
        public AbortCriteriaAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property FailureType. 
        /// <para>
        /// Over-the-air (OTA) task abort criteria failure type.
        /// </para>
        /// </summary>
        public AbortCriteriaFailureType FailureType { get; set; }

        /// <summary>
        /// Checks to see if the FailureType property is set.
        /// </summary>
        internal bool IsSetFailureType() => this.FailureType != null;

        /// <summary>
        /// Gets and sets the property MinNumberOfExecutedThings. 
        /// <para>
        /// The minimum number of things that must receive task execution notifications before
        /// the task can be aborted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MinNumberOfExecutedThings { get; set; }

        /// <summary>
        /// Checks to see if the MinNumberOfExecutedThings property is set.
        /// </summary>
        internal bool IsSetMinNumberOfExecutedThings() => this.MinNumberOfExecutedThings.HasValue;

        /// <summary>
        /// Gets and sets the property ThresholdPercentage. 
        /// <para>
        /// The minimum percentage of over-the-air (OTA) task execution failures that must occur
        /// to initiate the last abort.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public double? ThresholdPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdPercentage property is set.
        /// </summary>
        internal bool IsSetThresholdPercentage() => this.ThresholdPercentage.HasValue;
    }
}
