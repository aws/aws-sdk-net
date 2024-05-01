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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// An impersonation role for the given WorkMail organization.
    /// </summary>
    public partial class ImpersonationRole
    {
        private DateTime? _dateCreated;
        private DateTime? _dateModified;
        private string _impersonationRoleId;
        private string _name;
        private ImpersonationRoleType _type;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when the impersonation role was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateModified. 
        /// <para>
        /// The date when the impersonation role was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateModified
        {
            get { return this._dateModified; }
            set { this._dateModified = value; }
        }

        // Check to see if DateModified property is set
        internal bool IsSetDateModified()
        {
            return this._dateModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImpersonationRoleId. 
        /// <para>
        /// The identifier of the impersonation role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ImpersonationRoleId
        {
            get { return this._impersonationRoleId; }
            set { this._impersonationRoleId = value; }
        }

        // Check to see if ImpersonationRoleId property is set
        internal bool IsSetImpersonationRoleId()
        {
            return this._impersonationRoleId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The impersonation role name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The impersonation role type.
        /// </para>
        /// </summary>
        public ImpersonationRoleType Type
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