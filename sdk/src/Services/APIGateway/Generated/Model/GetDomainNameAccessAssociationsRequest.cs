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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetDomainNameAccessAssociations operation.
    /// Represents a collection on DomainNameAccessAssociations resources.
    /// </summary>
    public partial class GetDomainNameAccessAssociationsRequest : AmazonAPIGatewayRequest
    {
        private int? _limit;
        private string _position;
        private ResourceOwner _resourceOwner;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of returned results per page. The default value is 25 and the maximum
        /// value is 500. 
        /// </para>
        /// </summary>
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The current pagination position in the paged result set. 
        /// </para>
        /// </summary>
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        ///  The owner of the domain name access association. Use <c>SELF</c> to only list the
        /// domain name access associations owned by your own account. Use <c>OTHER_ACCOUNTS</c>
        /// to list the domain name access associations with your private custom domain names
        /// that are owned by other AWS accounts.
        /// </para>
        /// </summary>
        public ResourceOwner ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

    }
}