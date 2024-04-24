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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides the details of a policy finding.
    /// </summary>
    public partial class PolicyDetails
    {
        private FindingAction _action;
        private FindingActor _actor;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that produced the finding.
        /// </para>
        /// </summary>
        public FindingAction Action
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
        /// Gets and sets the property Actor. 
        /// <para>
        /// The entity that performed the action that produced the finding.
        /// </para>
        /// </summary>
        public FindingActor Actor
        {
            get { return this._actor; }
            set { this._actor = value; }
        }

        // Check to see if Actor property is set
        internal bool IsSetActor()
        {
            return this._actor != null;
        }

    }
}