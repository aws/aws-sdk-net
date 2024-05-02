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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the ListCrossAccountResources operation.
    /// List the cross-account resources available to work with.
    /// </summary>
    public partial class ListCrossAccountResourcesRequest : AmazonGlobalAcceleratorRequest
    {
        private string _acceleratorArn;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceOwnerAwsAccountId;

        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an accelerator in a cross-account attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string AcceleratorArn
        {
            get { return this._acceleratorArn; }
            set { this._acceleratorArn = value; }
        }

        // Check to see if AcceleratorArn property is set
        internal bool IsSetAcceleratorArn()
        {
            return this._acceleratorArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of cross-account resource objects that you want to return with this call.
        /// The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token for the next set of results. You receive this token from a previous call.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property ResourceOwnerAwsAccountId. 
        /// <para>
        /// The account ID of a resource owner in a cross-account attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string ResourceOwnerAwsAccountId
        {
            get { return this._resourceOwnerAwsAccountId; }
            set { this._resourceOwnerAwsAccountId = value; }
        }

        // Check to see if ResourceOwnerAwsAccountId property is set
        internal bool IsSetResourceOwnerAwsAccountId()
        {
            return this._resourceOwnerAwsAccountId != null;
        }

    }
}