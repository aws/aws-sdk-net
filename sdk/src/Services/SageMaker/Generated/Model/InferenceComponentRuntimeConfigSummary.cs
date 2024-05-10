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
    /// Details about the runtime settings for the model that is deployed with the inference
    /// component.
    /// </summary>
    public partial class InferenceComponentRuntimeConfigSummary
    {
        private int? _currentCopyCount;
        private int? _desiredCopyCount;

        /// <summary>
        /// Gets and sets the property CurrentCopyCount. 
        /// <para>
        /// The number of runtime copies of the model container that are currently deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? CurrentCopyCount
        {
            get { return this._currentCopyCount; }
            set { this._currentCopyCount = value; }
        }

        // Check to see if CurrentCopyCount property is set
        internal bool IsSetCurrentCopyCount()
        {
            return this._currentCopyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCopyCount. 
        /// <para>
        /// The number of runtime copies of the model container that you requested to deploy with
        /// the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? DesiredCopyCount
        {
            get { return this._desiredCopyCount; }
            set { this._desiredCopyCount = value; }
        }

        // Check to see if DesiredCopyCount property is set
        internal bool IsSetDesiredCopyCount()
        {
            return this._desiredCopyCount.HasValue; 
        }

    }
}