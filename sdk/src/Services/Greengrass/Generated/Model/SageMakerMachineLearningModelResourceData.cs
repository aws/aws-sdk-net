/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Attributes that define an SageMaker machine learning resource.
    /// </summary>
    public partial class SageMakerMachineLearningModelResourceData
    {
        private string _destinationPath;
        private string _sageMakerJobArn;

        /// <summary>
        /// Gets and sets the property DestinationPath. The absolute local path of the resource
        /// inside the Lambda environment.
        /// </summary>
        public string DestinationPath
        {
            get { return this._destinationPath; }
            set { this._destinationPath = value; }
        }

        // Check to see if DestinationPath property is set
        internal bool IsSetDestinationPath()
        {
            return this._destinationPath != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerJobArn. The ARN of the SageMaker training job
        /// that represents the source model.
        /// </summary>
        public string SageMakerJobArn
        {
            get { return this._sageMakerJobArn; }
            set { this._sageMakerJobArn = value; }
        }

        // Check to see if SageMakerJobArn property is set
        internal bool IsSetSageMakerJobArn()
        {
            return this._sageMakerJobArn != null;
        }

    }
}