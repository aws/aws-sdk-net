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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Describes an Electronic Data Interchange (EDI) entity as described in as defined in
    /// <a href="https://tools.ietf.org/html/rfc5280">Subject Alternative Name</a> in RFC
    /// 5280.
    /// </summary>
    public partial class EdiPartyName
    {
        private string _nameAssigner;
        private string _partyName;

        /// <summary>
        /// Gets and sets the property NameAssigner. 
        /// <para>
        /// Specifies the name assigner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NameAssigner
        {
            get { return this._nameAssigner; }
            set { this._nameAssigner = value; }
        }

        // Check to see if NameAssigner property is set
        internal bool IsSetNameAssigner()
        {
            return this._nameAssigner != null;
        }

        /// <summary>
        /// Gets and sets the property PartyName. 
        /// <para>
        /// Specifies the party name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string PartyName
        {
            get { return this._partyName; }
            set { this._partyName = value; }
        }

        // Check to see if PartyName property is set
        internal bool IsSetPartyName()
        {
            return this._partyName != null;
        }

    }
}