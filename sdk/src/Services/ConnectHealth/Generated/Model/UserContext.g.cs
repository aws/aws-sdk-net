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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Details for user initiating insights job
    /// </summary>
    public partial class UserContext
    {
        /// <summary>
        /// Gets and sets the property Role.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Specialty.
        /// </summary>
        public Specialty Specialty { get; set; }

        /// <summary>
        /// Checks to see if the Specialty property is set.
        /// </summary>
        internal bool IsSetSpecialty() => this.Specialty != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Unique identifier of the user
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
