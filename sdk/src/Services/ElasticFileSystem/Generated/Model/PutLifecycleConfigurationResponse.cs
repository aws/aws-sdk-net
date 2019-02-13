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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// This is the response object from the PutLifecycleConfiguration operation.
    /// </summary>
    public partial class PutLifecycleConfigurationResponse : AmazonWebServiceResponse
    {
        private List<LifecyclePolicy> _lifecyclePolicies = new List<LifecyclePolicy>();

        /// <summary>
        /// Gets and sets the property LifecyclePolicies. 
        /// <para>
        /// An array of lifecycle management policies. Currently, EFS supports a maximum of one
        /// policy per file system.
        /// </para>
        /// </summary>
        public List<LifecyclePolicy> LifecyclePolicies
        {
            get { return this._lifecyclePolicies; }
            set { this._lifecyclePolicies = value; }
        }

        // Check to see if LifecyclePolicies property is set
        internal bool IsSetLifecyclePolicies()
        {
            return this._lifecyclePolicies != null && this._lifecyclePolicies.Count > 0; 
        }

    }
}