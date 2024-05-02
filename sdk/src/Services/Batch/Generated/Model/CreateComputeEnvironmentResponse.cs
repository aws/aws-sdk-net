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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the CreateComputeEnvironment operation.
    /// </summary>
    public partial class CreateComputeEnvironmentResponse : AmazonWebServiceResponse
    {
        private string _computeEnvironmentArn;
        private string _computeEnvironmentName;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the compute environment.
        /// </para>
        /// </summary>
        public string ComputeEnvironmentArn
        {
            get { return this._computeEnvironmentArn; }
            set { this._computeEnvironmentArn = value; }
        }

        // Check to see if ComputeEnvironmentArn property is set
        internal bool IsSetComputeEnvironmentArn()
        {
            return this._computeEnvironmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentName. 
        /// <para>
        /// The name of the compute environment. It can be up to 128 characters long. It can contain
        /// uppercase and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        public string ComputeEnvironmentName
        {
            get { return this._computeEnvironmentName; }
            set { this._computeEnvironmentName = value; }
        }

        // Check to see if ComputeEnvironmentName property is set
        internal bool IsSetComputeEnvironmentName()
        {
            return this._computeEnvironmentName != null;
        }

    }
}