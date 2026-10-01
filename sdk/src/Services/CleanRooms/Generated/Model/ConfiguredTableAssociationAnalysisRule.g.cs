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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// An analysis rule for a configured table association. This analysis rule specifies
    /// how data from the table can be used within its associated collaboration. In the console,
    /// the <c>ConfiguredTableAssociationAnalysisRule</c> is referred to as the <i>collaboration
    /// analysis rule</i>.
    /// </summary>
    public partial class ConfiguredTableAssociationAnalysisRule
    {
        /// <summary>
        /// Gets and sets the property ConfiguredTableAssociationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the configured table association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string ConfiguredTableAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredTableAssociationArn property is set.
        /// </summary>
        internal bool IsSetConfiguredTableAssociationArn() => this.ConfiguredTableAssociationArn != null;

        /// <summary>
        /// Gets and sets the property ConfiguredTableAssociationId. 
        /// <para>
        ///  The unique identifier for the configured table association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ConfiguredTableAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredTableAssociationId property is set.
        /// </summary>
        internal bool IsSetConfiguredTableAssociationId() => this.ConfiguredTableAssociationId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        ///  The creation time of the configured table association analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        ///  The membership identifier for the configured table association analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        ///  The policy of the configured table association analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfiguredTableAssociationAnalysisRulePolicy Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the configured table association analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfiguredTableAssociationAnalysisRuleType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  The update time of the configured table association analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
