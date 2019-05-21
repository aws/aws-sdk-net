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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EndpointOptions
    {
        private bool? _fips;
        private bool? _privateLink;

        /// <summary>
        /// Gets and sets the property Fips.
        /// </summary>
        public bool Fips
        {
            get { return this._fips.GetValueOrDefault(); }
            set { this._fips = value; }
        }

        // Check to see if Fips property is set
        internal bool IsSetFips()
        {
            return this._fips.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateLink.
        /// </summary>
        public bool PrivateLink
        {
            get { return this._privateLink.GetValueOrDefault(); }
            set { this._privateLink = value; }
        }

        // Check to see if PrivateLink property is set
        internal bool IsSetPrivateLink()
        {
            return this._privateLink.HasValue; 
        }

    }
}