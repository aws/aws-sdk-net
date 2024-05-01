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
    /// Container for the parameters to the DeleteCalculatedAttributeDefinition operation.
    /// Deletes an existing calculated attribute definition. Note that deleting a default
    /// calculated attribute is possible, however once deleted, you will be unable to undo
    /// that action and will need to recreate it on your own using the CreateCalculatedAttributeDefinition
    /// API if you want it back.
    /// </summary>
    public partial class DeleteCalculatedAttributeDefinitionRequest : AmazonCustomerProfilesRequest
    {
        private string _calculatedAttributeName;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property CalculatedAttributeName. 
        /// <para>
        /// The unique name of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CalculatedAttributeName
        {
            get { return this._calculatedAttributeName; }
            set { this._calculatedAttributeName = value; }
        }

        // Check to see if CalculatedAttributeName property is set
        internal bool IsSetCalculatedAttributeName()
        {
            return this._calculatedAttributeName != null;
        }

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

    }
}