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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Allow or deny permissions for an Active Directory group to enroll or autoenroll certificates
    /// for a template.
    /// </summary>
    public partial class AccessRights
    {
        private AccessRight _autoEnroll;
        private AccessRight _enroll;

        /// <summary>
        /// Gets and sets the property AutoEnroll. 
        /// <para>
        /// Allow or deny an Active Directory group from autoenrolling certificates issued against
        /// a template. The Active Directory group must be allowed to enroll to allow autoenrollment
        /// </para>
        /// </summary>
        public AccessRight AutoEnroll
        {
            get { return this._autoEnroll; }
            set { this._autoEnroll = value; }
        }

        // Check to see if AutoEnroll property is set
        internal bool IsSetAutoEnroll()
        {
            return this._autoEnroll != null;
        }

        /// <summary>
        /// Gets and sets the property Enroll. 
        /// <para>
        /// Allow or deny an Active Directory group from enrolling certificates issued against
        /// a template.
        /// </para>
        /// </summary>
        public AccessRight Enroll
        {
            get { return this._enroll; }
            set { this._enroll = value; }
        }

        // Check to see if Enroll property is set
        internal bool IsSetEnroll()
        {
            return this._enroll != null;
        }

    }
}