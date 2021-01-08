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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// This is the response object from the DescribeEnvironments operation.
    /// </summary>
    public partial class DescribeEnvironmentsResponse : AmazonWebServiceResponse
    {
        private List<Environment> _environments = new List<Environment>();

        /// <summary>
        /// Gets and sets the property Environments. 
        /// <para>
        /// Information about the environments that are returned.
        /// </para>
        /// </summary>
        public List<Environment> Environments
        {
            get { return this._environments; }
            set { this._environments = value; }
        }

        // Check to see if Environments property is set
        internal bool IsSetEnvironments()
        {
            return this._environments != null && this._environments.Count > 0; 
        }

    }
}