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
    /// The model deployment settings for the SageMaker Canvas application.
    /// 
    ///  <note> 
    /// <para>
    /// In order to enable model deployment for Canvas, the SageMaker Domain's or user profile's
    /// Amazon Web Services IAM execution role must have the <c>AmazonSageMakerCanvasDirectDeployAccess</c>
    /// policy attached. You can also turn on model deployment permissions through the SageMaker
    /// Domain's or user profile's settings in the SageMaker console.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DirectDeploySettings
    {
        private FeatureStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes whether model deployment permissions are enabled or disabled in the Canvas
        /// application.
        /// </para>
        /// </summary>
        public FeatureStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}