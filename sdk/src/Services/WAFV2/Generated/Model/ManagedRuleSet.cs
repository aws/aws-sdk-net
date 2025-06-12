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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A set of rules that is managed by Amazon Web Services and Amazon Web Services Marketplace
    /// sellers to provide versioned managed rule groups for customers of WAF.
    /// 
    ///  <note> 
    /// <para>
    /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
    /// Web Services and Amazon Web Services Marketplace sellers. 
    /// </para>
    ///  
    /// <para>
    /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
    /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
    /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ManagedRuleSet
    {
        private string _arn;
        private string _description;
        private string _id;
        private string _labelNamespace;
        private string _name;
        private Dictionary<string, ManagedRuleSetVersion> _publishedVersions = AWSConfigs.InitializeCollections ? new Dictionary<string, ManagedRuleSetVersion>() : null;
        private string _recommendedVersion;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the set that helps with identification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the managed rule set. The ID is returned in the responses
        /// to commands like <c>list</c>. You provide it to operations like <c>get</c> and <c>update</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LabelNamespace. 
        /// <para>
        /// The label namespace prefix for the managed rule groups that are offered to customers
        /// from this managed rule set. All labels that are added by rules in the managed rule
        /// group have this prefix. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The syntax for the label namespace prefix for a managed rule group is the following:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>awswaf:managed:&lt;vendor&gt;:&lt;rule group name&gt;</c>:
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When a rule with a label matches a web request, WAF adds the fully qualified label
        /// to the request. A fully qualified label is made up of the label namespace from the
        /// rule group or web ACL where the rule is defined and the label from the rule, separated
        /// by a colon: 
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;label namespace&gt;:&lt;label from rule&gt;</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LabelNamespace
        {
            get { return this._labelNamespace; }
            set { this._labelNamespace = value; }
        }

        // Check to see if LabelNamespace property is set
        internal bool IsSetLabelNamespace()
        {
            return this._labelNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed rule set. You use this, along with the rule set ID, to identify
        /// the rule set.
        /// </para>
        ///  
        /// <para>
        /// This name is assigned to the corresponding managed rule group, which your customers
        /// can access and use. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property PublishedVersions. 
        /// <para>
        /// The versions of this managed rule set that are available for use by customers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ManagedRuleSetVersion> PublishedVersions
        {
            get { return this._publishedVersions; }
            set { this._publishedVersions = value; }
        }

        // Check to see if PublishedVersions property is set
        internal bool IsSetPublishedVersions()
        {
            return this._publishedVersions != null && (this._publishedVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecommendedVersion. 
        /// <para>
        /// The version that you would like your customers to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RecommendedVersion
        {
            get { return this._recommendedVersion; }
            set { this._recommendedVersion = value; }
        }

        // Check to see if RecommendedVersion property is set
        internal bool IsSetRecommendedVersion()
        {
            return this._recommendedVersion != null;
        }

    }
}