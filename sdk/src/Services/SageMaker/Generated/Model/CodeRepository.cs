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
    /// A Git repository that SageMaker automatically displays to users for cloning in the
    /// JupyterServer application.
    /// </summary>
    public partial class CodeRepository
    {
        private string _repositoryUrl;

        /// <summary>
        /// Gets and sets the property RepositoryUrl. 
        /// <para>
        /// The URL of the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string RepositoryUrl
        {
            get { return this._repositoryUrl; }
            set { this._repositoryUrl = value; }
        }

        // Check to see if RepositoryUrl property is set
        internal bool IsSetRepositoryUrl()
        {
            return this._repositoryUrl != null;
        }

    }
}