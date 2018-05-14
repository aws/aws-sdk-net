/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the MoveAccount operation.
    /// Moves an account from its current source parent root or organizational unit (OU) to
    /// the specified destination parent root or OU.
    /// 
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    /// </summary>
    public partial class MoveAccountRequest : AmazonOrganizationsRequest
    {
        private string _accountId;
        private string _destinationParentId;
        private string _sourceParentId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier (ID) of the account that you want to move.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an account ID
        /// string requires exactly 12 digits.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationParentId. 
        /// <para>
        /// The unique identifier (ID) of the root or organizational unit that you want to move
        /// the account to.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a parent ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Root: a string that begins with "r-" followed by from 4 to 32 lower-case letters or
        /// digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit (OU): a string that begins with "ou-" followed by from 4 to 32
        /// lower-case letters or digits (the ID of the root that the OU is in) followed by a
        /// second "-" dash and from 8 to 32 additional lower-case letters or digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DestinationParentId
        {
            get { return this._destinationParentId; }
            set { this._destinationParentId = value; }
        }

        // Check to see if DestinationParentId property is set
        internal bool IsSetDestinationParentId()
        {
            return this._destinationParentId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceParentId. 
        /// <para>
        /// The unique identifier (ID) of the root or organizational unit that you want to move
        /// the account from.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a parent ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Root: a string that begins with "r-" followed by from 4 to 32 lower-case letters or
        /// digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit (OU): a string that begins with "ou-" followed by from 4 to 32
        /// lower-case letters or digits (the ID of the root that the OU is in) followed by a
        /// second "-" dash and from 8 to 32 additional lower-case letters or digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceParentId
        {
            get { return this._sourceParentId; }
            set { this._sourceParentId = value; }
        }

        // Check to see if SourceParentId property is set
        internal bool IsSetSourceParentId()
        {
            return this._sourceParentId != null;
        }

    }
}