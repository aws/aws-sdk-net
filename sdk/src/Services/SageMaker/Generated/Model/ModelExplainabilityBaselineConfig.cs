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
    /// The configuration for a baseline model explainability job.
    /// </summary>
    public partial class ModelExplainabilityBaselineConfig
    {
        private string _baseliningJobName;
        private MonitoringConstraintsResource _constraintsResource;

        /// <summary>
        /// Gets and sets the property BaseliningJobName. 
        /// <para>
        /// The name of the baseline model explainability job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string BaseliningJobName
        {
            get { return this._baseliningJobName; }
            set { this._baseliningJobName = value; }
        }

        // Check to see if BaseliningJobName property is set
        internal bool IsSetBaseliningJobName()
        {
            return this._baseliningJobName != null;
        }

        /// <summary>
        /// Gets and sets the property ConstraintsResource.
        /// </summary>
        public MonitoringConstraintsResource ConstraintsResource
        {
            get { return this._constraintsResource; }
            set { this._constraintsResource = value; }
        }

        // Check to see if ConstraintsResource property is set
        internal bool IsSetConstraintsResource()
        {
            return this._constraintsResource != null;
        }

    }
}