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
    /// The access configuration settings for the source ML model for an optimization job,
    /// where you can accept the model end-user license agreement (EULA).
    /// </summary>
    public partial class OptimizationModelAccessConfig
    {
        private bool? _acceptEula;

        /// <summary>
        /// Gets and sets the property AcceptEula. 
        /// <para>
        /// Specifies agreement to the model end-user license agreement (EULA). The <c>AcceptEula</c>
        /// value must be explicitly defined as <c>True</c> in order to accept the EULA that this
        /// model requires. You are responsible for reviewing and complying with any applicable
        /// license terms and making sure they are acceptable for your use case before downloading
        /// or using a model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AcceptEula
        {
            get { return this._acceptEula; }
            set { this._acceptEula = value; }
        }

        // Check to see if AcceptEula property is set
        internal bool IsSetAcceptEula()
        {
            return this._acceptEula.HasValue; 
        }

    }
}