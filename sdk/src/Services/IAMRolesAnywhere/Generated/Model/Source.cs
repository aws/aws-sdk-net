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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// The trust anchor type and its related certificate data.
    /// </summary>
    public partial class Source
    {
        private SourceData _sourceData;
        private TrustAnchorType _sourceType;

        /// <summary>
        /// Gets and sets the property SourceData. 
        /// <para>
        /// The data field of the trust anchor depending on its type. 
        /// </para>
        /// </summary>
        public SourceData SourceData
        {
            get { return this._sourceData; }
            set { this._sourceData = value; }
        }

        // Check to see if SourceData property is set
        internal bool IsSetSourceData()
        {
            return this._sourceData != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the trust anchor. 
        /// </para>
        /// </summary>
        public TrustAnchorType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}