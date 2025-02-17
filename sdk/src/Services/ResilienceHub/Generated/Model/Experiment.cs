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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Indicates the FIS experiment detected while running an assessment.
    /// </summary>
    public partial class Experiment
    {
        private string _experimentArn;
        private string _experimentTemplateId;

        /// <summary>
        /// Gets and sets the property ExperimentArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the FIS experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ExperimentArn
        {
            get { return this._experimentArn; }
            set { this._experimentArn = value; }
        }

        // Check to see if ExperimentArn property is set
        internal bool IsSetExperimentArn()
        {
            return this._experimentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentTemplateId. 
        /// <para>
        /// Identifier of the FIS experiment template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ExperimentTemplateId
        {
            get { return this._experimentTemplateId; }
            set { this._experimentTemplateId = value; }
        }

        // Check to see if ExperimentTemplateId property is set
        internal bool IsSetExperimentTemplateId()
        {
            return this._experimentTemplateId != null;
        }

    }
}