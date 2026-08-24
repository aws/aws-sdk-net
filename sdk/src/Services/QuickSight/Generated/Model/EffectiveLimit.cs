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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private LimitUnit _limitUnit;
        private long? _limitValue;
        private string _profileId;
        private ResourceType _resourceType;
        private LimitSource _source;

        /// <summary>
        /// Gets and sets the property LimitUnit. 
        /// <para>
        /// The unit of measurement for the limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LimitUnit LimitUnit
        {
            get { return this._limitUnit; }
            set { this._limitUnit = value; }
        }

        // Check to see if LimitUnit property is set
        internal bool IsSetLimitUnit()
        {
            return this._limitUnit != null;
        }

        /// <summary>
        /// Gets and sets the property LimitValue. 
        /// <para>
        /// The maximum allowed value for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? LimitValue
        {
            get { return this._limitValue; }
            set { this._limitValue = value; }
        }

        // Check to see if LimitValue property is set
        internal bool IsSetLimitValue()
        {
            return this._limitValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The identifier of the limits profile that defines this limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource that the limit applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

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
        [AWSProperty(Required=true)]
        public LimitSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}