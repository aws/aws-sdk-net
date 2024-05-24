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
    /// An array of configuration policy associations, one for each configuration policy
    /// association identifier, that was specified in a <c>BatchGetConfigurationPolicyAssociations</c>
    /// request but couldn’t be processed due to an error.
    /// </summary>
    public partial class UnprocessedConfigurationPolicyAssociation
    {
        private ConfigurationPolicyAssociation _configurationPolicyAssociationIdentifiers;
        private string _errorCode;
        private string _errorReason;

        /// <summary>
        /// Gets and sets the property ConfigurationPolicyAssociationIdentifiers. 
        /// <para>
        ///  Configuration policy association identifiers that were specified in a <c>BatchGetConfigurationPolicyAssociations</c>
        /// request but couldn’t be processed due to an error. 
        /// </para>
        /// </summary>
        public ConfigurationPolicyAssociation ConfigurationPolicyAssociationIdentifiers
        {
            get { return this._configurationPolicyAssociationIdentifiers; }
            set { this._configurationPolicyAssociationIdentifiers = value; }
        }

        // Check to see if ConfigurationPolicyAssociationIdentifiers property is set
        internal bool IsSetConfigurationPolicyAssociationIdentifiers()
        {
            return this._configurationPolicyAssociationIdentifiers != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  An HTTP status code that identifies why the configuration policy association failed.
        /// 
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorReason. 
        /// <para>
        ///  A string that identifies why the configuration policy association failed. 
        /// </para>
        /// </summary>
        public string ErrorReason
        {
            get { return this._errorReason; }
            set { this._errorReason = value; }
        }

        // Check to see if ErrorReason property is set
        internal bool IsSetErrorReason()
        {
            return this._errorReason != null;
        }

    }
}