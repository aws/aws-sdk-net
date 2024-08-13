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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Network configuration settings for inbound network traffic.
    /// </summary>
    public partial class IngressConfiguration
    {
        private bool? _isPubliclyAccessible;

        /// <summary>
        /// Gets and sets the property IsPubliclyAccessible. 
        /// <para>
        /// Specifies whether your App Runner service is publicly accessible. To make the service
        /// publicly accessible set it to <c>True</c>. To make the service privately accessible,
        /// from only within an Amazon VPC set it to <c>False</c>. 
        /// </para>
        /// </summary>
        public bool? IsPubliclyAccessible
        {
            get { return this._isPubliclyAccessible; }
            set { this._isPubliclyAccessible = value; }
        }

        // Check to see if IsPubliclyAccessible property is set
        internal bool IsSetIsPubliclyAccessible()
        {
            return this._isPubliclyAccessible.HasValue; 
        }

    }
}