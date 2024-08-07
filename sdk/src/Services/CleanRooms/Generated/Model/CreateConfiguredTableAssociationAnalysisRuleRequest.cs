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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfiguredTableAssociationAnalysisRule operation.
    /// Creates a new analysis rule for an associated configured table.
    /// </summary>
    public partial class CreateConfiguredTableAssociationAnalysisRuleRequest : AmazonCleanRoomsRequest
    {
        private ConfiguredTableAssociationAnalysisRulePolicy _analysisRulePolicy;
        private ConfiguredTableAssociationAnalysisRuleType _analysisRuleType;
        private string _configuredTableAssociationIdentifier;
        private string _membershipIdentifier;

        /// <summary>
        /// Gets and sets the property AnalysisRulePolicy. 
        /// <para>
        /// The analysis rule policy that was created for the configured table association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTableAssociationAnalysisRulePolicy AnalysisRulePolicy
        {
            get { return this._analysisRulePolicy; }
            set { this._analysisRulePolicy = value; }
        }

        // Check to see if AnalysisRulePolicy property is set
        internal bool IsSetAnalysisRulePolicy()
        {
            return this._analysisRulePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisRuleType. 
        /// <para>
        ///  The type of analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTableAssociationAnalysisRuleType AnalysisRuleType
        {
            get { return this._analysisRuleType; }
            set { this._analysisRuleType = value; }
        }

        // Check to see if AnalysisRuleType property is set
        internal bool IsSetAnalysisRuleType()
        {
            return this._analysisRuleType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredTableAssociationIdentifier. 
        /// <para>
        ///  The unique ID for the configured table association. Currently accepts the configured
        /// table association ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ConfiguredTableAssociationIdentifier
        {
            get { return this._configuredTableAssociationIdentifier; }
            set { this._configuredTableAssociationIdentifier = value; }
        }

        // Check to see if ConfiguredTableAssociationIdentifier property is set
        internal bool IsSetConfiguredTableAssociationIdentifier()
        {
            return this._configuredTableAssociationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        ///  A unique identifier for the membership that the configured table association belongs
        /// to. Currently accepts the membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

    }
}