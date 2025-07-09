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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOrganizationalUnit operation.
    /// Retrieves information about an organizational unit (OU).
    /// 
    ///  
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator.
    /// </para>
    /// </summary>
    public partial class DescribeOrganizationalUnitRequest : AmazonOrganizationsRequest
    {
        private string _organizationalUnitId;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The unique identifier (ID) of the organizational unit that you want details about.
        /// You can get the ID from the <a>ListOrganizationalUnitsForParent</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an organizational
        /// unit ID string requires "ou-" followed by from 4 to 32 lowercase letters or digits
        /// (the ID of the root that contains the OU). This string is followed by a second "-"
        /// dash and from 8 to 32 additional lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=68)]
        public string OrganizationalUnitId
        {
            get { return this._organizationalUnitId; }
            set { this._organizationalUnitId = value; }
        }

        // Check to see if OrganizationalUnitId property is set
        internal bool IsSetOrganizationalUnitId()
        {
            return this._organizationalUnitId != null;
        }

    }
}