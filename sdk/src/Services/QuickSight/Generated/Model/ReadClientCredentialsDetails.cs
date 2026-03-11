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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Read-only details for OAuth2 client credentials, containing non-sensitive configuration
    /// information.
    /// </summary>
    public partial class ReadClientCredentialsDetails
    {
        private ReadClientCredentialsGrantDetails _readClientCredentialsGrantDetails;

        /// <summary>
        /// Gets and sets the property ReadClientCredentialsGrantDetails. 
        /// <para>
        /// The read-only client credentials grant configuration details.
        /// </para>
        /// </summary>
        public ReadClientCredentialsGrantDetails ReadClientCredentialsGrantDetails
        {
            get { return this._readClientCredentialsGrantDetails; }
            set { this._readClientCredentialsGrantDetails = value; }
        }

        // Check to see if ReadClientCredentialsGrantDetails property is set
        internal bool IsSetReadClientCredentialsGrantDetails()
        {
            return this._readClientCredentialsGrantDetails != null;
        }

    }
}