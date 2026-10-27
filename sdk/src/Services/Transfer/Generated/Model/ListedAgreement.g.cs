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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the properties of an agreement.
    /// </summary>
    public partial class ListedAgreement
    {
        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// A unique identifier for the agreement. This identifier is returned when you create
        /// an agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The current description for the agreement. You can change it by calling the <c>UpdateAgreement</c>
        /// operation and providing a new description. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LocalProfileId. 
        /// <para>
        /// A unique identifier for the AS2 local profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string LocalProfileId { get; set; }

        /// <summary>
        /// Checks to see if the LocalProfileId property is set.
        /// </summary>
        internal bool IsSetLocalProfileId() => this.LocalProfileId != null;

        /// <summary>
        /// Gets and sets the property PartnerProfileId. 
        /// <para>
        /// A unique identifier for the partner profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string PartnerProfileId { get; set; }

        /// <summary>
        /// Checks to see if the PartnerProfileId property is set.
        /// </summary>
        internal bool IsSetPartnerProfileId() => this.PartnerProfileId != null;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// The unique identifier for the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string ServerId { get; set; }

        /// <summary>
        /// Checks to see if the ServerId property is set.
        /// </summary>
        internal bool IsSetServerId() => this.ServerId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The agreement can be either <c>ACTIVE</c> or <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        public AgreementStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
