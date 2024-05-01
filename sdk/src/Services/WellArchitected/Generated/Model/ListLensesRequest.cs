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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the ListLenses operation.
    /// List the available lenses.
    /// </summary>
    public partial class ListLensesRequest : AmazonWellArchitectedRequest
    {
        private string _lensName;
        private LensStatusType _lensStatus;
        private LensType _lensType;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LensName.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LensName
        {
            get { return this._lensName; }
            set { this._lensName = value; }
        }

        // Check to see if LensName property is set
        internal bool IsSetLensName()
        {
            return this._lensName != null;
        }

        /// <summary>
        /// Gets and sets the property LensStatus. 
        /// <para>
        /// The status of lenses to be returned.
        /// </para>
        /// </summary>
        public LensStatusType LensStatus
        {
            get { return this._lensStatus; }
            set { this._lensStatus = value; }
        }

        // Check to see if LensStatus property is set
        internal bool IsSetLensStatus()
        {
            return this._lensStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LensType. 
        /// <para>
        /// The type of lenses to be returned.
        /// </para>
        /// </summary>
        public LensType LensType
        {
            get { return this._lensType; }
            set { this._lensType = value; }
        }

        // Check to see if LensType property is set
        internal bool IsSetLensType()
        {
            return this._lensType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}