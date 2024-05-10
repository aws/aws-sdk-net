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
    /// Contains information about attribute-based access control (ABAC) for a training job.
    /// </summary>
    public partial class SessionChainingConfig
    {
        private bool? _enableSessionTagChaining;

        /// <summary>
        /// Gets and sets the property EnableSessionTagChaining. 
        /// <para>
        /// Set to <c>True</c> to allow SageMaker to extract session tags from a training job
        /// creation role and reuse these tags when assuming the training job execution role.
        /// </para>
        /// </summary>
        public bool? EnableSessionTagChaining
        {
            get { return this._enableSessionTagChaining; }
            set { this._enableSessionTagChaining = value; }
        }

        // Check to see if EnableSessionTagChaining property is set
        internal bool IsSetEnableSessionTagChaining()
        {
            return this._enableSessionTagChaining.HasValue; 
        }

    }
}