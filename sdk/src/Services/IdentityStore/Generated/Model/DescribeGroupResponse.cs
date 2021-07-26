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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// This is the response object from the DescribeGroup operation.
    /// </summary>
    public partial class DescribeGroupResponse : AmazonWebServiceResponse
    {
        private string _displayName;
        private string _groupId;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// Contains the group’s display name value. The length limit is 1,024 characters. This
        /// value can consist of letters, accented characters, symbols, numbers, punctuation,
        /// tab, new line, carriage return, space, and nonbreaking space in this attribute. The
        /// characters <code>&lt;&gt;;:%</code> are excluded. This value is specified at the time
        /// that the group is created and stored as an attribute of the group object in the identity
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier for a group in the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=47)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

    }
}