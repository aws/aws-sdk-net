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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Returns the path to the <code>ObjectIdentifiers</code> that is associated with the
    /// directory.
    /// </summary>
    public partial class PathToObjectIdentifiers
    {
        private List<string> _objectIdentifiers = new List<string>();
        private string _path;

        /// <summary>
        /// Gets and sets the property ObjectIdentifiers. 
        /// <para>
        /// Lists <code>ObjectIdentifiers</code> starting from directory root to the object in
        /// the request.
        /// </para>
        /// </summary>
        public List<string> ObjectIdentifiers
        {
            get { return this._objectIdentifiers; }
            set { this._objectIdentifiers = value; }
        }

        // Check to see if ObjectIdentifiers property is set
        internal bool IsSetObjectIdentifiers()
        {
            return this._objectIdentifiers != null && this._objectIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path that is used to identify the object starting from directory root.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}