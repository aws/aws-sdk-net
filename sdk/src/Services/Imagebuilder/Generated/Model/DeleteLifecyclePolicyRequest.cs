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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLifecyclePolicy operation.
    /// Delete the specified lifecycle policy resource.
    /// </summary>
    public partial class DeleteLifecyclePolicyRequest : AmazonImagebuilderRequest
    {
        private string _lifecyclePolicyArn;

        /// <summary>
        /// Gets and sets the property LifecyclePolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle policy resource to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string LifecyclePolicyArn
        {
            get { return this._lifecyclePolicyArn; }
            set { this._lifecyclePolicyArn = value; }
        }

        // Check to see if LifecyclePolicyArn property is set
        internal bool IsSetLifecyclePolicyArn()
        {
            return this._lifecyclePolicyArn != null;
        }

    }
}