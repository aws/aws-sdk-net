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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used in the <a>LocalizedText</a> data type.
    /// </summary>
    public partial class LocalizedTextKey
    {
        private string _facility;
        private string _id;

        /// <summary>
        /// Gets and sets the property Facility. 
        /// <para>
        /// The module response source of the text.
        /// </para>
        /// </summary>
        public string Facility
        {
            get { return this._facility; }
            set { this._facility = value; }
        }

        // Check to see if Facility property is set
        internal bool IsSetFacility()
        {
            return this._facility != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Part of the module response source of the text.
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

    }
}