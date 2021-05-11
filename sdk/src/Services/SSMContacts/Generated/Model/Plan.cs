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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// The stages that an escalation plan or engagement plan engages contacts and contact
    /// methods in.
    /// </summary>
    public partial class Plan
    {
        private List<Stage> _stages = new List<Stage>();

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// A list of stages that the escalation plan or engagement plan uses to engage contacts
        /// and contact methods.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Stage> Stages
        {
            get { return this._stages; }
            set { this._stages = value; }
        }

        // Check to see if Stages property is set
        internal bool IsSetStages()
        {
            return this._stages != null && this._stages.Count > 0; 
        }

    }
}