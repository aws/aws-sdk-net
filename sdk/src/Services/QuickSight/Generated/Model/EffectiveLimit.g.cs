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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The effective limit for a resource type that applies to a user, considering all applicable
    /// profile assignments and inheritance rules.
    /// </summary>
    public partial class EffectiveLimit
    {
        /// <summary>
        /// Gets and sets the property LimitUnit. 
        /// <para>
        /// The unit of measurement for the limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LimitUnit LimitUnit { get; set; }

        /// <summary>
        /// Checks to see if the LimitUnit property is set.
        /// </summary>
        internal bool IsSetLimitUnit() => this.LimitUnit != null;

        /// <summary>
        /// Gets and sets the property LimitValue. 
        /// <para>
        /// The maximum allowed value for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? LimitValue { get; set; }

        /// <summary>
        /// Checks to see if the LimitValue property is set.
        /// </summary>
        internal bool IsSetLimitValue() => this.LimitValue.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The identifier of the limits profile that defines this limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource that the limit applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source from which this limit was inherited. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DIRECT_USER</c> – The limit comes from a profile directly assigned to the user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GROUP</c> – The limit comes from a profile assigned to a group the user belongs
        /// to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLE</c> – The limit comes from a profile assigned to a role the user has.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCOUNT</c> – The limit comes from the account-level default profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SYSTEM_DEFAULT</c> – The limit comes from the built-in system default.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public LimitSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
