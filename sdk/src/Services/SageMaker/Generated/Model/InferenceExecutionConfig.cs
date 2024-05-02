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
    /// Specifies details about how containers in a multi-container endpoint are run.
    /// </summary>
    public partial class InferenceExecutionConfig
    {
        private InferenceExecutionMode _mode;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// How containers in a multi-container are run. The following values are valid.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SERIAL</c> - Containers run as a serial pipeline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIRECT</c> - Only the individual container that you specify is run.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceExecutionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}