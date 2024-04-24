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
    /// Container for the parameters to the UpdateConfigurationPolicy operation.
    /// Updates a configuration policy. Only the Security Hub delegated administrator can
    /// invoke this operation from the home Region.
    /// </summary>
    public partial class UpdateConfigurationPolicyRequest : AmazonSecurityHubRequest
    {
        private Policy _configurationPolicy;
        private string _description;
        private string _identifier;
        private string _name;
        private string _updatedReason;

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
        ///  
        /// <para>
        /// When updating a configuration policy, provide a complete list of standards that you
        /// want to enable and a complete list of controls that you want to enable or disable.
        /// The updated configuration replaces the current configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Identifier. 
        /// <para>
        ///  The Amazon Resource Name (ARN) or universally unique identifier (UUID) of the configuration
        /// policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the configuration policy. Alphanumeric characters and the following ASCII
        /// characters are permitted: <c>-, ., !, *, /</c>. 
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

        /// <summary>
        /// Gets and sets the property UpdatedReason. 
        /// <para>
        ///  The reason for updating the configuration policy. 
        /// </para>
        /// </summary>
        public string UpdatedReason
        {
            get { return this._updatedReason; }
            set { this._updatedReason = value; }
        }

        // Check to see if UpdatedReason property is set
        internal bool IsSetUpdatedReason()
        {
            return this._updatedReason != null;
        }

    }
}