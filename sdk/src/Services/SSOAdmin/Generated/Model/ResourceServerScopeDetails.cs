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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes details for an IAM Identity Center access scope that is
    /// associated with a resource server.
    /// </summary>
    public partial class ResourceServerScopeDetails
    {
        private string _detailedTitle;
        private string _longDescription;

        /// <summary>
        /// Gets and sets the property DetailedTitle. 
        /// <para>
        /// The title of an access scope for a resource server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DetailedTitle
        {
            get { return this._detailedTitle; }
            set { this._detailedTitle = value; }
        }

        // Check to see if DetailedTitle property is set
        internal bool IsSetDetailedTitle()
        {
            return this._detailedTitle != null;
        }

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// The description of an access scope for a resource server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LongDescription
        {
            get { return this._longDescription; }
            set { this._longDescription = value; }
        }

        // Check to see if LongDescription property is set
        internal bool IsSetLongDescription()
        {
            return this._longDescription != null;
        }

    }
}