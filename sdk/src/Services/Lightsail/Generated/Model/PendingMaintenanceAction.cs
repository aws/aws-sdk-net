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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a pending database maintenance action.
    /// </summary>
    public partial class PendingMaintenanceAction
    {
        private string _action;
        private DateTime? _currentApplyDate;
        private string _description;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of pending database maintenance action.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CurrentApplyDate. 
        /// <para>
        /// The effective date of the pending database maintenance action.
        /// </para>
        /// </summary>
        public DateTime? CurrentApplyDate
        {
            get { return this._currentApplyDate; }
            set { this._currentApplyDate = value; }
        }

        // Check to see if CurrentApplyDate property is set
        internal bool IsSetCurrentApplyDate()
        {
            return this._currentApplyDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Additional detail about the pending database maintenance action.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}