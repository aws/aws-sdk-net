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
    /// Container for the parameters to the DescribeCodeRepository operation.
    /// Gets details about the specified Git repository.
    /// </summary>
    public partial class DescribeCodeRepositoryRequest : AmazonSageMakerRequest
    {
        private string _codeRepositoryName;

        /// <summary>
        /// Gets and sets the property CodeRepositoryName. 
        /// <para>
        /// The name of the Git repository to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string CodeRepositoryName
        {
            get { return this._codeRepositoryName; }
            set { this._codeRepositoryName = value; }
        }

        // Check to see if CodeRepositoryName property is set
        internal bool IsSetCodeRepositoryName()
        {
            return this._codeRepositoryName != null;
        }

    }
}