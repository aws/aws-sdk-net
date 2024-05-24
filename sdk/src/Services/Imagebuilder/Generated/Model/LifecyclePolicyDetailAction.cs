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
    /// Contains selection criteria for the lifecycle policy.
    /// </summary>
    public partial class LifecyclePolicyDetailAction
    {
        private LifecyclePolicyDetailActionIncludeResources _includeResources;
        private LifecyclePolicyDetailActionType _type;

        /// <summary>
        /// Gets and sets the property IncludeResources. 
        /// <para>
        /// Specifies the resources that the lifecycle policy applies to.
        /// </para>
        /// </summary>
        public LifecyclePolicyDetailActionIncludeResources IncludeResources
        {
            get { return this._includeResources; }
            set { this._includeResources = value; }
        }

        // Check to see if IncludeResources property is set
        internal bool IsSetIncludeResources()
        {
            return this._includeResources != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the lifecycle action to take.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecyclePolicyDetailActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}