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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
        private MpaOperation _action;
        private AssociationState _associationState;
        private MpaStatus _mpaStatus;
        private string _mpaTeamArn;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The protected operation associated with the MPA team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MpaOperation Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        /// The state of the MPA team association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociationState AssociationState
        {
            get { return this._associationState; }
            set { this._associationState = value; }
        }

        // Check to see if AssociationState property is set
        internal bool IsSetAssociationState()
        {
            return this._associationState != null;
        }

        /// <summary>
        /// Gets and sets the property MpaStatus. 
        /// <para>
        /// The MPA session status for the association, if applicable.
        /// </para>
        /// </summary>
        public MpaStatus MpaStatus
        {
            get { return this._mpaStatus; }
            set { this._mpaStatus = value; }
        }

        // Check to see if MpaStatus property is set
        internal bool IsSetMpaStatus()
        {
            return this._mpaStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MpaTeamArn. 
        /// <para>
        /// The ARN of the MPA team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string MpaTeamArn
        {
            get { return this._mpaTeamArn; }
            set { this._mpaTeamArn = value; }
        }

        // Check to see if MpaTeamArn property is set
        internal bool IsSetMpaTeamArn()
        {
            return this._mpaTeamArn != null;
        }

    }
}