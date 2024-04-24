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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Step taken during a cluster operation.
    /// </summary>
    public partial class ClusterOperationStep
    {
        private ClusterOperationStepInfo _stepInfo;
        private string _stepName;

        /// <summary>
        /// Gets and sets the property StepInfo.             
        /// <para>
        /// Information about the step and its status.
        /// </para>
        /// </summary>
        public ClusterOperationStepInfo StepInfo
        {
            get { return this._stepInfo; }
            set { this._stepInfo = value; }
        }

        // Check to see if StepInfo property is set
        internal bool IsSetStepInfo()
        {
            return this._stepInfo != null;
        }

        /// <summary>
        /// Gets and sets the property StepName.             
        /// <para>
        /// The name of the step.
        /// </para>
        /// </summary>
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

    }
}