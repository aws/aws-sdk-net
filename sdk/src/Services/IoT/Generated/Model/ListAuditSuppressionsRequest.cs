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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListAuditSuppressions operation.
    /// Lists your Device Defender audit listings. 
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditSuppressions</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListAuditSuppressionsRequest : AmazonIoTRequest
    {
        private bool? _ascendingOrder;
        private string _checkName;
        private int? _maxResults;
        private string _nextToken;
        private ResourceIdentifier _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property AscendingOrder. 
        /// <para>
        ///  Determines whether suppressions are listed in ascending order by expiration date
        /// or not. If parameter isn't provided, <c>ascendingOrder=true</c>. 
        /// </para>
        /// </summary>
        public bool? AscendingOrder
        {
            get { return this._ascendingOrder; }
            set { this._ascendingOrder = value; }
        }

        // Check to see if AscendingOrder property is set
        internal bool IsSetAscendingOrder()
        {
            return this._ascendingOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckName.
        /// </summary>
        public string CheckName
        {
            get { return this._checkName; }
            set { this._checkName = value; }
        }

        // Check to see if CheckName property is set
        internal bool IsSetCheckName()
        {
            return this._checkName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return at one time. The default is 25. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// <para>
        ///  The token for the next set of results. 
        /// </para>
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

        /// <summary>
        /// Gets and sets the property ResourceIdentifier.
        /// </summary>
        public ResourceIdentifier ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}