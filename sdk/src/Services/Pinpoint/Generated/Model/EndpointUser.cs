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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies data for one or more attributes that describe the user who's associated
    /// with an endpoint.
    /// </summary>
    public partial class EndpointUser
    {
        private Dictionary<string, List<string>> _userAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _userId;

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// One or more custom attributes that describe the user by associating a name with an
        /// array of values. For example, the value of an attribute named Interests might be:
        /// ["Science", "Music", "Travel"]. You can use these attributes as filter criteria when
        /// you create segments. Attribute names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// An attribute name can contain up to 50 characters. An attribute value can contain
        /// up to 100 characters. When you define the name of a custom attribute, avoid using
        /// the following characters: number sign (#), colon (:), question mark (?), backslash
        /// (\), and slash (/). The Amazon Pinpoint console can't display attribute names that
        /// contain these characters. This restriction doesn't apply to attribute values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && (this._userAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier for the user.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}