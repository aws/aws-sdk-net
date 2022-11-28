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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Applications list filters.
    /// </summary>
    public partial class ListApplicationsRequestFilters
    {
        private List<string> _applicationiDs = new List<string>();
        private bool? _isArchived;
        private List<string> _waveiDs = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplicationIDs. 
        /// <para>
        /// Filter applications list by application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> ApplicationIDs
        {
            get { return this._applicationiDs; }
            set { this._applicationiDs = value; }
        }

        // Check to see if ApplicationIDs property is set
        internal bool IsSetApplicationIDs()
        {
            return this._applicationiDs != null && this._applicationiDs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Filter applications list by archival status.
        /// </para>
        /// </summary>
        public bool IsArchived
        {
            get { return this._isArchived.GetValueOrDefault(); }
            set { this._isArchived = value; }
        }

        // Check to see if IsArchived property is set
        internal bool IsSetIsArchived()
        {
            return this._isArchived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WaveIDs. 
        /// <para>
        /// Filter applications list by wave ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> WaveIDs
        {
            get { return this._waveiDs; }
            set { this._waveiDs = value; }
        }

        // Check to see if WaveIDs property is set
        internal bool IsSetWaveIDs()
        {
            return this._waveiDs != null && this._waveiDs.Count > 0; 
        }

    }
}