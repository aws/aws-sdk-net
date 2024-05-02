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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
namespace Amazon.FIS.Model
{
    /// <summary>
    /// This is the response object from the GetExperiment operation.
    /// </summary>
    public partial class GetExperimentResponse : AmazonWebServiceResponse
    {
        private Experiment _experiment;

        /// <summary>
        /// Gets and sets the property Experiment. 
        /// <para>
        /// Information about the experiment.
        /// </para>
        /// </summary>
        public Experiment Experiment
        {
            get { return this._experiment; }
            set { this._experiment = value; }
        }

        // Check to see if Experiment property is set
        internal bool IsSetExperiment()
        {
            return this._experiment != null;
        }

    }
}