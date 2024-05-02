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
    /// Specifies an authentication configuration for the private docker registry where your
    /// model image is hosted. Specify a value for this property only if you specified <c>Vpc</c>
    /// as the value for the <c>RepositoryAccessMode</c> field of the <c>ImageConfig</c> object
    /// that you passed to a call to <c>CreateModel</c> and the private Docker registry where
    /// the model image is hosted requires authentication.
    /// </summary>
    public partial class RepositoryAuthConfig
    {
        private string _repositoryCredentialsProviderArn;

        /// <summary>
        /// Gets and sets the property RepositoryCredentialsProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services Lambda function that provides
        /// credentials to authenticate to the private Docker registry where your model image
        /// is hosted. For information about how to create an Amazon Web Services Lambda function,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/getting-started-create-function.html">Create
        /// a Lambda function with the console</a> in the <i>Amazon Web Services Lambda Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RepositoryCredentialsProviderArn
        {
            get { return this._repositoryCredentialsProviderArn; }
            set { this._repositoryCredentialsProviderArn = value; }
        }

        // Check to see if RepositoryCredentialsProviderArn property is set
        internal bool IsSetRepositoryCredentialsProviderArn()
        {
            return this._repositoryCredentialsProviderArn != null;
        }

    }
}