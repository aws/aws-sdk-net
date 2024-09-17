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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// An object that defines the public-access settings for a function.
    /// </summary>
    public partial class PublicAccessBlockConfig
    {
        private bool? _blockPublicPolicy;
        private bool? _restrictPublicResource;

        /// <summary>
        /// Gets and sets the property BlockPublicPolicy. 
        /// <para>
        /// To block the creation of resource-based policies that would grant public access to
        /// your function, set <c>BlockPublicPolicy</c> to <c>true</c>. To allow the creation
        /// of resource-based policies that would grant public access to your function, set <c>BlockPublicPolicy</c>
        /// to <c>false</c>.
        /// </para>
        /// </summary>
        public bool BlockPublicPolicy
        {
            get { return this._blockPublicPolicy.GetValueOrDefault(); }
            set { this._blockPublicPolicy = value; }
        }

        // Check to see if BlockPublicPolicy property is set
        internal bool IsSetBlockPublicPolicy()
        {
            return this._blockPublicPolicy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestrictPublicResource. 
        /// <para>
        /// To block public access to your function, even if its resource-based policy allows
        /// it, set <c>RestrictPublicResource</c> to <c>true</c>. To allow public access to a
        /// function with a resource-based policy that permits it, set <c>RestrictPublicResource</c>
        /// to <c>false</c>.
        /// </para>
        /// </summary>
        public bool RestrictPublicResource
        {
            get { return this._restrictPublicResource.GetValueOrDefault(); }
            set { this._restrictPublicResource = value; }
        }

        // Check to see if RestrictPublicResource property is set
        internal bool IsSetRestrictPublicResource()
        {
            return this._restrictPublicResource.HasValue; 
        }

    }
}