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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// The configuration of the resource share
    /// </summary>
    public partial class ResourceShareConfiguration
    {
        private bool? _retainSharingOnAccountLeaveOrganization;

        /// <summary>
        /// Gets and sets the property RetainSharingOnAccountLeaveOrganization. 
        /// <para>
        /// Specifies whether the consumer account retains access to the resource share after
        /// leaving the organization.
        /// </para>
        /// </summary>
        public bool RetainSharingOnAccountLeaveOrganization
        {
            get { return this._retainSharingOnAccountLeaveOrganization.GetValueOrDefault(); }
            set { this._retainSharingOnAccountLeaveOrganization = value; }
        }

        // Check to see if RetainSharingOnAccountLeaveOrganization property is set
        internal bool IsSetRetainSharingOnAccountLeaveOrganization()
        {
            return this._retainSharingOnAccountLeaveOrganization.HasValue; 
        }

    }
}