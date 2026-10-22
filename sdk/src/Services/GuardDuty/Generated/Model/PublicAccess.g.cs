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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Describes the public access policies that apply to the S3 bucket.
    /// </summary>
    public partial class PublicAccess
    {
        /// <summary>
        /// Gets and sets the property EffectivePermission. 
        /// <para>
        /// Describes the effective permission on this bucket after factoring all attached policies.
        /// </para>
        /// </summary>
        public string EffectivePermission { get; set; }

        /// <summary>
        /// Checks to see if the EffectivePermission property is set.
        /// </summary>
        internal bool IsSetEffectivePermission() => this.EffectivePermission != null;

        /// <summary>
        /// Gets and sets the property PermissionConfiguration. 
        /// <para>
        /// Contains information about how permissions are configured for the S3 bucket.
        /// </para>
        /// </summary>
        public PermissionConfiguration PermissionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PermissionConfiguration property is set.
        /// </summary>
        internal bool IsSetPermissionConfiguration() => this.PermissionConfiguration != null;
    }
}
