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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies one or more attributes to remove from all the endpoints that are associated
    /// with an application.
    /// </summary>
    public partial class UpdateAttributesRequest
    {
        private List<string> _blacklist = new List<string>();

        /// <summary>
        /// Gets and sets the property Blacklist. 
        /// <para>
        /// An array of the attributes to remove from all the endpoints that are associated with
        /// the application. The array can specify the complete, exact name of each attribute
        /// to remove or it can specify a glob pattern that an attribute name must match in order
        /// for the attribute to be removed.
        /// </para>
        /// </summary>
        public List<string> Blacklist
        {
            get { return this._blacklist; }
            set { this._blacklist = value; }
        }

        // Check to see if Blacklist property is set
        internal bool IsSetBlacklist()
        {
            return this._blacklist != null && this._blacklist.Count > 0; 
        }

    }
}