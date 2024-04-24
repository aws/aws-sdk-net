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
    /// Container for the parameters to the PutContainerRecipePolicy operation.
    /// Applies a policy to a container image. We recommend that you call the RAM API CreateResourceShare
    /// (https://docs.aws.amazon.com//ram/latest/APIReference/API_CreateResourceShare.html)
    /// to share resources. If you call the Image Builder API <c>PutContainerImagePolicy</c>,
    /// you must also call the RAM API PromoteResourceShareCreatedFromPolicy (https://docs.aws.amazon.com//ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html)
    /// in order for the resource to be visible to all principals with whom the resource is
    /// shared.
    /// </summary>
    public partial class PutContainerRecipePolicyRequest : AmazonImagebuilderRequest
    {
        private string _containerRecipeArn;
        private string _policy;

        /// <summary>
        /// Gets and sets the property ContainerRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container recipe that this policy should be
        /// applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContainerRecipeArn
        {
            get { return this._containerRecipeArn; }
            set { this._containerRecipeArn = value; }
        }

        // Check to see if ContainerRecipeArn property is set
        internal bool IsSetContainerRecipeArn()
        {
            return this._containerRecipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy to apply to the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30000)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}