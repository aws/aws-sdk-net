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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The action that starts at the beginning of an incident. The response plan defines
    /// the action.
    /// </summary>
    public partial class Action
    {
        private SsmAutomation _ssmAutomation;

        /// <summary>
        /// Gets and sets the property SsmAutomation. 
        /// <para>
        /// The Systems Manager automation document to start as the runbook at the beginning of
        /// the incident.
        /// </para>
        /// </summary>
        public SsmAutomation SsmAutomation
        {
            get { return this._ssmAutomation; }
            set { this._ssmAutomation = value; }
        }

        // Check to see if SsmAutomation property is set
        internal bool IsSetSsmAutomation()
        {
            return this._ssmAutomation != null;
        }

    }
}