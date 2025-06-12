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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
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
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// This is the response object from the ListResourcesAssociatedToCustomLineItem operation.
    /// </summary>
    public partial class ListResourcesAssociatedToCustomLineItemResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<ListResourcesAssociatedToCustomLineItemResponseElement> _associatedResources = AWSConfigs.InitializeCollections ? new List<ListResourcesAssociatedToCustomLineItemResponseElement>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The custom line item ARN for which the resource associations are listed. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedResources. 
        /// <para>
        ///  A list of <c>ListResourcesAssociatedToCustomLineItemResponseElement</c> for each
        /// resource association retrieved. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListResourcesAssociatedToCustomLineItemResponseElement> AssociatedResources
        {
            get { return this._associatedResources; }
            set { this._associatedResources = value; }
        }

        // Check to see if AssociatedResources property is set
        internal bool IsSetAssociatedResources()
        {
            return this._associatedResources != null && (this._associatedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token to be used in subsequent requests to retrieve additional results.
        /// 
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

    }
}