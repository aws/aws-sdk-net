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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// This is the response object from the GetLifecyclePolicy operation.
    /// </summary>
    public partial class GetLifecyclePolicyResponse : AmazonWebServiceResponse
    {
        private string _lifecyclePolicy;

        /// <summary>
        /// Gets and sets the property LifecyclePolicy. 
        /// <para>
        /// The object lifecycle policy that is assigned to the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=8192)]
        public string LifecyclePolicy
        {
            get { return this._lifecyclePolicy; }
            set { this._lifecyclePolicy = value; }
        }

        // Check to see if LifecyclePolicy property is set
        internal bool IsSetLifecyclePolicy()
        {
            return this._lifecyclePolicy != null;
        }

    }
}