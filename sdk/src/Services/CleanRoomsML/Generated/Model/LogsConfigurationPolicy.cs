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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Provides the information necessary for a user to access the logs.
    /// </summary>
    public partial class LogsConfigurationPolicy
    {
        private List<string> _allowedAccountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _filterPattern;

        /// <summary>
        /// Gets and sets the property AllowedAccountIds. 
        /// <para>
        /// A list of account IDs that are allowed to access the logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> AllowedAccountIds
        {
            get { return this._allowedAccountIds; }
            set { this._allowedAccountIds = value; }
        }

        // Check to see if AllowedAccountIds property is set
        internal bool IsSetAllowedAccountIds()
        {
            return this._allowedAccountIds != null && (this._allowedAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterPattern. 
        /// <para>
        /// A regular expression pattern that is used to parse the logs and return information
        /// that matches the pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

    }
}