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
    /// Specifies whether the model container is in Amazon ECR or a private Docker registry
    /// accessible from your Amazon Virtual Private Cloud (VPC).
    /// </summary>
    public partial class ImageConfig
    {
        private RepositoryAccessMode _repositoryAccessMode;

        /// <summary>
        /// Gets and sets the property RepositoryAccessMode. 
        /// <para>
        /// Set this to one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Platform</code> - The model image is hosted in Amazon ECR.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Vpc</code> - The model image is hosted in a private Docker registry in your
        /// VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositoryAccessMode RepositoryAccessMode
        {
            get { return this._repositoryAccessMode; }
            set { this._repositoryAccessMode = value; }
        }

        // Check to see if RepositoryAccessMode property is set
        internal bool IsSetRepositoryAccessMode()
        {
            return this._repositoryAccessMode != null;
        }

    }
}