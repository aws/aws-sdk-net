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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The Cybersecurity and Infrastructure Security Agency (CISA) details for a specific
    /// vulnerability.
    /// </summary>
    public partial class CisaData
    {
        private string _action;
        private DateTime? _dateAdded;
        private DateTime? _dateDue;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The remediation action recommended by CISA for this vulnerability.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public string Action
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
        /// Gets and sets the property DateAdded. 
        /// <para>
        /// The date and time CISA added this vulnerability to their catalogue.
        /// </para>
        /// </summary>
        public DateTime? DateAdded
        {
            get { return this._dateAdded; }
            set { this._dateAdded = value; }
        }

        // Check to see if DateAdded property is set
        internal bool IsSetDateAdded()
        {
            return this._dateAdded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateDue. 
        /// <para>
        /// The date and time CISA expects a fix to have been provided vulnerability.
        /// </para>
        /// </summary>
        public DateTime? DateDue
        {
            get { return this._dateDue; }
            set { this._dateDue = value; }
        }

        // Check to see if DateDue property is set
        internal bool IsSetDateDue()
        {
            return this._dateDue.HasValue; 
        }

    }
}