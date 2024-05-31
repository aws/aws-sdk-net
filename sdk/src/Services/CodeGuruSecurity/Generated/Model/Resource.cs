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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Information about a resource that contains a finding.
    /// </summary>
    public partial class Resource
    {
        private string _id;
        private string _subResourceId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The <c>scanName</c> of the scan that was run on the resource.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SubResourceId. 
        /// <para>
        /// The identifier for a section of the resource.
        /// </para>
        /// </summary>
        public string SubResourceId
        {
            get { return this._subResourceId; }
            set { this._subResourceId = value; }
        }

        // Check to see if SubResourceId property is set
        internal bool IsSetSubResourceId()
        {
            return this._subResourceId != null;
        }

    }
}