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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDomainLayout operation.
    /// Deletes the layout used to view data for a specific domain. This API can only be invoked
    /// from the Amazon Connect admin website.
    /// </summary>
    public partial class DeleteDomainLayoutRequest : AmazonCustomerProfilesRequest
    {
        private string _domainName;
        private string _layoutDefinitionName;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property LayoutDefinitionName. 
        /// <para>
        /// The unique name of the layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string LayoutDefinitionName
        {
            get { return this._layoutDefinitionName; }
            set { this._layoutDefinitionName = value; }
        }

        // Check to see if LayoutDefinitionName property is set
        internal bool IsSetLayoutDefinitionName()
        {
            return this._layoutDefinitionName != null;
        }

    }
}