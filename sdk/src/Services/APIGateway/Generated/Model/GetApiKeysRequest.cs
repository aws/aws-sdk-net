/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetApiKeys operation.
    /// Gets information about the current <a>ApiKeys</a> resource.
    /// </summary>
    public partial class GetApiKeysRequest : AmazonAPIGatewayRequest
    {
        private string _customerId;
        private bool? _includeValues;
        private int? _limit;
        private string _nameQuery;
        private string _position;

        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// The identifier of a customer in AWS Marketplace or an external system, such as a developer
        /// portal.
        /// </para>
        /// </summary>
        public string CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }

        // Check to see if CustomerId property is set
        internal bool IsSetCustomerId()
        {
            return this._customerId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeValues. 
        /// <para>
        /// A boolean flag to specify whether (<code>true</code>) or not (<code>false</code>)
        /// the result contains key values.
        /// </para>
        /// </summary>
        public bool IncludeValues
        {
            get { return this._includeValues.GetValueOrDefault(); }
            set { this._includeValues = value; }
        }

        // Check to see if IncludeValues property is set
        internal bool IsSetIncludeValues()
        {
            return this._includeValues.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of returned results per page. The default value is 25 and the maximum
        /// value is 500.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NameQuery. 
        /// <para>
        /// The name of queried API keys.
        /// </para>
        /// </summary>
        public string NameQuery
        {
            get { return this._nameQuery; }
            set { this._nameQuery = value; }
        }

        // Check to see if NameQuery property is set
        internal bool IsSetNameQuery()
        {
            return this._nameQuery != null;
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

    }
}