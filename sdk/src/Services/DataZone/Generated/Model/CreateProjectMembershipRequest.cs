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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProjectMembership operation.
    /// Creates a project membership in Amazon DataZone.
    /// </summary>
    public partial class CreateProjectMembershipRequest : AmazonDataZoneRequest
    {
        private UserDesignation _designation;
        private string _domainIdentifier;
        private Member _member;
        private string _projectIdentifier;

        /// <summary>
        /// Gets and sets the property Designation. 
        /// <para>
        /// The designation of the project membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserDesignation Designation
        {
            get { return this._designation; }
            set { this._designation = value; }
        }

        // Check to see if Designation property is set
        internal bool IsSetDesignation()
        {
            return this._designation != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which project membership is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Member. 
        /// <para>
        /// The project member whose project membership was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Member Member
        {
            get { return this._member; }
            set { this._member = value; }
        }

        // Check to see if Member property is set
        internal bool IsSetMember()
        {
            return this._member != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The ID of the project for which this project membership was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectIdentifier
        {
            get { return this._projectIdentifier; }
            set { this._projectIdentifier = value; }
        }

        // Check to see if ProjectIdentifier property is set
        internal bool IsSetProjectIdentifier()
        {
            return this._projectIdentifier != null;
        }

    }
}