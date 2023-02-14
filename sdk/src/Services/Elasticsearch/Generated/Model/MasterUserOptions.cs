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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Credentials for the master user: username and password, ARN, or both.
    /// </summary>
    public partial class MasterUserOptions
    {
        private string _masterUserARN;
        private string _masterUserName;
        private string _masterUserPassword;

        /// <summary>
        /// Gets and sets the property MasterUserARN. 
        /// <para>
        /// ARN for the master user (if IAM is enabled).
        /// </para>
        /// </summary>
        public string MasterUserARN
        {
            get { return this._masterUserARN; }
            set { this._masterUserARN = value; }
        }

        // Check to see if MasterUserARN property is set
        internal bool IsSetMasterUserARN()
        {
            return this._masterUserARN != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserName. 
        /// <para>
        /// The master user's username, which is stored in the Amazon Elasticsearch Service domain's
        /// internal database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string MasterUserName
        {
            get { return this._masterUserName; }
            set { this._masterUserName = value; }
        }

        // Check to see if MasterUserName property is set
        internal bool IsSetMasterUserName()
        {
            return this._masterUserName != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The master user's password, which is stored in the Amazon Elasticsearch Service domain's
        /// internal database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=8)]
        public string MasterUserPassword
        {
            get { return this._masterUserPassword; }
            set { this._masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this._masterUserPassword != null;
        }

    }
}