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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// Contains the response to a <c>Suggest</c> request.
    /// </summary>
    public partial class SuggestResponse : AmazonWebServiceResponse
    {
        private SuggestStatus _status;
        private SuggestModel _suggest;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a <c>SuggestRequest</c>. Contains the resource ID (<c>rid</c>) and how
        /// long it took to process the request (<c>timems</c>).
        /// </para>
        /// </summary>
        public SuggestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Suggest. 
        /// <para>
        /// Container for the matching search suggestion information.
        /// </para>
        /// </summary>
        public SuggestModel Suggest
        {
            get { return this._suggest; }
            set { this._suggest = value; }
        }

        // Check to see if Suggest property is set
        internal bool IsSetSuggest()
        {
            return this._suggest != null;
        }

    }
}