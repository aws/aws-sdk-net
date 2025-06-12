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
    /// Container for the parameters to the BatchGetCalculatedAttributeForProfile operation.
    /// Fetch the possible attribute values given the attribute name.
    /// </summary>
    public partial class BatchGetCalculatedAttributeForProfileRequest : AmazonCustomerProfilesRequest
    {
        private string _calculatedAttributeName;
        private ConditionOverrides _conditionOverrides;
        private string _domainName;
        private List<string> _profileIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property ConditionOverrides. 
        /// <para>
        /// Overrides the condition block within the original calculated attribute definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ConditionOverrides ConditionOverrides
        {
            get { return this._conditionOverrides; }
            set { this._conditionOverrides = value; }
        }

        // Check to see if ConditionOverrides property is set
        internal bool IsSetConditionOverrides()
        {
            return this._conditionOverrides != null;
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

        /// <summary>
        /// Gets and sets the property ProfileIds. 
        /// <para>
        /// List of unique identifiers for customer profiles to retrieve.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ProfileIds
        {
            get { return this._profileIds; }
            set { this._profileIds = value; }
        }

        // Check to see if ProfileIds property is set
        internal bool IsSetProfileIds()
        {
            return this._profileIds != null && (this._profileIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}