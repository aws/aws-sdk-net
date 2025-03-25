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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes whether the resource is managed by a service provider and, if so, describes
    /// the service provider that manages it.
    /// </summary>
    public partial class OperatorResponse
    {
        private bool? _managed;
        private string _principal;

        /// <summary>
        /// Gets and sets the property Managed. 
        /// <para>
        /// If <c>true</c>, the resource is managed by a service provider.
        /// </para>
        /// </summary>
        public bool? Managed
        {
            get { return this._managed; }
            set { this._managed = value; }
        }

        // Check to see if Managed property is set
        internal bool IsSetManaged()
        {
            return this._managed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// If <c>managed</c> is <c>true</c>, then the principal is returned. The principal is
        /// the service provider that manages the resource.
        /// </para>
        /// </summary>
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

    }
}