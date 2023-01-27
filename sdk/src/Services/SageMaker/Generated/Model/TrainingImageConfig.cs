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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration to use an image from a private Docker registry for a training job.
    /// </summary>
    public partial class TrainingImageConfig
    {
        private TrainingRepositoryAccessMode _trainingRepositoryAccessMode;
        private TrainingRepositoryAuthConfig _trainingRepositoryAuthConfig;

        /// <summary>
        /// Gets and sets the property TrainingRepositoryAccessMode. 
        /// <para>
        /// The method that your training job will use to gain access to the images in your private
        /// Docker registry. For access to an image in a private Docker registry, set to <code>Vpc</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingRepositoryAccessMode TrainingRepositoryAccessMode
        {
            get { return this._trainingRepositoryAccessMode; }
            set { this._trainingRepositoryAccessMode = value; }
        }

        // Check to see if TrainingRepositoryAccessMode property is set
        internal bool IsSetTrainingRepositoryAccessMode()
        {
            return this._trainingRepositoryAccessMode != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingRepositoryAuthConfig. 
        /// <para>
        /// An object containing authentication information for a private Docker registry containing
        /// your training images.
        /// </para>
        /// </summary>
        public TrainingRepositoryAuthConfig TrainingRepositoryAuthConfig
        {
            get { return this._trainingRepositoryAuthConfig; }
            set { this._trainingRepositoryAuthConfig = value; }
        }

        // Check to see if TrainingRepositoryAuthConfig property is set
        internal bool IsSetTrainingRepositoryAuthConfig()
        {
            return this._trainingRepositoryAuthConfig != null;
        }

    }
}