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
    /// The single sign-on details in Amazon DataZone.
    /// </summary>
    public partial class SingleSignOn
    {
        private string _idcInstanceArn;
        private AuthType _type;
        private UserAssignment _userAssignment;

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The ARN of the IDC instance.
        /// </para>
        /// </summary>
        public string IdcInstanceArn
        {
            get { return this._idcInstanceArn; }
            set { this._idcInstanceArn = value; }
        }

        // Check to see if IdcInstanceArn property is set
        internal bool IsSetIdcInstanceArn()
        {
            return this._idcInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of single sign-on in Amazon DataZone.
        /// </para>
        /// </summary>
        public AuthType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UserAssignment. 
        /// <para>
        /// The single sign-on user assignment in Amazon DataZone.
        /// </para>
        /// </summary>
        public UserAssignment UserAssignment
        {
            get { return this._userAssignment; }
            set { this._userAssignment = value; }
        }

        // Check to see if UserAssignment property is set
        internal bool IsSetUserAssignment()
        {
            return this._userAssignment != null;
        }

    }
}