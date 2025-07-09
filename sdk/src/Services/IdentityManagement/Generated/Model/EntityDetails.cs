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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// An object that contains details about when the IAM entities (users or roles) were
    /// last used in an attempt to access the specified Amazon Web Services service.
    /// 
    ///  
    /// <para>
    /// This data type is a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetailsWithEntities.html">GetServiceLastAccessedDetailsWithEntities</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class EntityDetails
    {
        private EntityInfo _entityInfo;
        private DateTime? _lastAuthenticated;

        /// <summary>
        /// Gets and sets the property EntityInfo. 
        /// <para>
        /// The <c>EntityInfo</c> object that contains details about the entity (user or role).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityInfo EntityInfo
        {
            get { return this._entityInfo; }
            set { this._entityInfo = value; }
        }

        // Check to see if EntityInfo property is set
        internal bool IsSetEntityInfo()
        {
            return this._entityInfo != null;
        }

        /// <summary>
        /// Gets and sets the property LastAuthenticated. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the authenticated entity last attempted to access Amazon Web Services.
        /// Amazon Web Services does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        public DateTime? LastAuthenticated
        {
            get { return this._lastAuthenticated; }
            set { this._lastAuthenticated = value; }
        }

        // Check to see if LastAuthenticated property is set
        internal bool IsSetLastAuthenticated()
        {
            return this._lastAuthenticated.HasValue; 
        }

    }
}