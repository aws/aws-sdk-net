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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfigurationPolicy operation.
    /// Creates a configuration policy with the defined configuration. Only the Security
    /// Hub delegated administrator can invoke this operation from the home Region.
    /// </summary>
    public partial class CreateConfigurationPolicyRequest : AmazonSecurityHubRequest
    {
        private Policy _configurationPolicy;
        private string _description;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationPolicy. 
        /// <para>
        ///  An object that defines how Security Hub is configured. It includes whether Security
        /// Hub is enabled or disabled, a list of enabled security standards, a list of enabled
        /// or disabled security controls, and a list of custom parameter values for specified
        /// controls. If you provide a list of security controls that are enabled in the configuration
        /// policy, Security Hub disables all other controls (including newly released controls).
        /// If you provide a list of security controls that are disabled in the configuration
        /// policy, Security Hub enables all other controls (including newly released controls).
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Policy ConfigurationPolicy
        {
            get { return this._configurationPolicy; }
            set { this._configurationPolicy = value; }
        }

        // Check to see if ConfigurationPolicy property is set
        internal bool IsSetConfigurationPolicy()
        {
            return this._configurationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the configuration policy. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the configuration policy. Alphanumeric characters and the following ASCII
        /// characters are permitted: <c>-, ., !, *, /</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  User-defined tags associated with a configuration policy. For more information, see
        /// <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/tagging-resources.html">Tagging
        /// Security Hub resources</a> in the <i>Security Hub user guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}