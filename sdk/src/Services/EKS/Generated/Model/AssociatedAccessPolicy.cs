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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// An access policy association.
    /// </summary>
    public partial class AssociatedAccessPolicy
    {
        private AccessScope _accessScope;
        private DateTime? _associatedAt;
        private DateTime? _modifiedAt;
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property AccessScope. 
        /// <para>
        /// The scope of the access policy.
        /// </para>
        /// </summary>
        public AccessScope AccessScope
        {
            get { return this._accessScope; }
            set { this._accessScope = value; }
        }

        // Check to see if AccessScope property is set
        internal bool IsSetAccessScope()
        {
            return this._accessScope != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedAt. 
        /// <para>
        /// The date and time the <c>AccessPolicy</c> was associated with an <c>AccessEntry</c>.
        /// </para>
        /// </summary>
        public DateTime? AssociatedAt
        {
            get { return this._associatedAt; }
            set { this._associatedAt = value; }
        }

        // Check to see if AssociatedAt property is set
        internal bool IsSetAssociatedAt()
        {
            return this._associatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The Unix epoch timestamp for the last modification to the object.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The ARN of the <c>AccessPolicy</c>.
        /// </para>
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

    }
}