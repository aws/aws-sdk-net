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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Represents the content of an SLA to be returned to agents.
    /// </summary>
    public partial class SlaContent
    {
        private SlaConfiguration _slaConfiguration;

        /// <summary>
        /// Gets and sets the property SlaConfiguration. 
        /// <para>
        /// Represents an SLA configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlaConfiguration SlaConfiguration
        {
            get { return this._slaConfiguration; }
            set { this._slaConfiguration = value; }
        }

        // Check to see if SlaConfiguration property is set
        internal bool IsSetSlaConfiguration()
        {
            return this._slaConfiguration != null;
        }

    }
}