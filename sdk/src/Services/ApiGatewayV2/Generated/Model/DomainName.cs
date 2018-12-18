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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents a domain name.
    /// </summary>
    public partial class DomainName
    {
        private string _apiMappingSelectionExpression;
        private List<DomainNameConfiguration> _domainNameConfigurations = new List<DomainNameConfiguration>();
        private string _name;

        /// <summary>
        /// Gets and sets the property ApiMappingSelectionExpression. 
        /// <para>
        /// The API mapping selection expression.
        /// </para>
        /// </summary>
        public string ApiMappingSelectionExpression
        {
            get { return this._apiMappingSelectionExpression; }
            set { this._apiMappingSelectionExpression = value; }
        }

        // Check to see if ApiMappingSelectionExpression property is set
        internal bool IsSetApiMappingSelectionExpression()
        {
            return this._apiMappingSelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNameConfigurations. 
        /// <para>
        /// The domain name configurations.
        /// </para>
        /// </summary>
        public List<DomainNameConfiguration> DomainNameConfigurations
        {
            get { return this._domainNameConfigurations; }
            set { this._domainNameConfigurations = value; }
        }

        // Check to see if DomainNameConfigurations property is set
        internal bool IsSetDomainNameConfigurations()
        {
            return this._domainNameConfigurations != null && this._domainNameConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the DomainName resource.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}