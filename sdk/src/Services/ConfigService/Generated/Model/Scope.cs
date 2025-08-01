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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Defines which resources trigger an evaluation for an Config rule. The scope can include
    /// one or more resource types, a combination of a tag key and value, or a combination
    /// of one resource type and one resource ID. Specify a scope to constrain which resources
    /// trigger an evaluation for a rule. Otherwise, evaluations for the rule are triggered
    /// when any resource in your recording group changes in configuration.
    /// </summary>
    public partial class Scope
    {
        private string _complianceResourceId;
        private List<string> _complianceResourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tagKey;
        private string _tagValue;

        /// <summary>
        /// Gets and sets the property ComplianceResourceId. 
        /// <para>
        /// The ID of the only Amazon Web Services resource that you want to trigger an evaluation
        /// for the rule. If you specify a resource ID, you must specify one resource type for
        /// <c>ComplianceResourceTypes</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=768)]
        public string ComplianceResourceId
        {
            get { return this._complianceResourceId; }
            set { this._complianceResourceId = value; }
        }

        // Check to see if ComplianceResourceId property is set
        internal bool IsSetComplianceResourceId()
        {
            return this._complianceResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceResourceTypes. 
        /// <para>
        /// The resource types of only those Amazon Web Services resources that you want to trigger
        /// an evaluation for the rule. You can only specify one type if you also specify a resource
        /// ID for <c>ComplianceResourceId</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ComplianceResourceTypes
        {
            get { return this._complianceResourceTypes; }
            set { this._complianceResourceTypes = value; }
        }

        // Check to see if ComplianceResourceTypes property is set
        internal bool IsSetComplianceResourceTypes()
        {
            return this._complianceResourceTypes != null && (this._complianceResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The tag key that is applied to only those Amazon Web Services resources that you want
        /// to trigger an evaluation for the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The tag value applied to only those Amazon Web Services resources that you want to
        /// trigger an evaluation for the rule. If you specify a value for <c>TagValue</c>, you
        /// must also specify a value for <c>TagKey</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TagValue
        {
            get { return this._tagValue; }
            set { this._tagValue = value; }
        }

        // Check to see if TagValue property is set
        internal bool IsSetTagValue()
        {
            return this._tagValue != null;
        }

    }
}