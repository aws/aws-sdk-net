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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// The details of an MPA team association with a protected operation.
    /// </summary>
    public partial class MpaTeamAssociation
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The protected operation associated with the MPA team.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MpaOperation Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        /// The state of the MPA team association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationState AssociationState { get; set; }

        /// <summary>
        /// Checks to see if the AssociationState property is set.
        /// </summary>
        internal bool IsSetAssociationState() => this.AssociationState != null;

        /// <summary>
        /// Gets and sets the property MpaStatus. 
        /// <para>
        /// The MPA session status for the association, if applicable.
        /// </para>
        /// </summary>
        public MpaStatus MpaStatus { get; set; }

        /// <summary>
        /// Checks to see if the MpaStatus property is set.
        /// </summary>
        internal bool IsSetMpaStatus() => this.MpaStatus != null;

        /// <summary>
        /// Gets and sets the property MpaTeamArn. 
        /// <para>
        /// The ARN of the MPA team.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string MpaTeamArn { get; set; }

        /// <summary>
        /// Checks to see if the MpaTeamArn property is set.
        /// </summary>
        internal bool IsSetMpaTeamArn() => this.MpaTeamArn != null;
    }
}
