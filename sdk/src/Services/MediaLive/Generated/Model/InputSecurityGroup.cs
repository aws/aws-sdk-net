/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// An Input Security Group
    /// </summary>
    public partial class InputSecurityGroup
    {
        private string _arn;
        private string _id;
        private List<string> _inputs = new List<string>();
        private InputSecurityGroupState _state;
        private List<InputWhitelistRule> _whitelistRules = new List<InputWhitelistRule>();

        /// <summary>
        /// Gets and sets the property Arn. Unique ARN of Input Security Group
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The Id of the Input Security Group
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Inputs. The list of inputs currently using this Input Security
        /// Group.
        /// </summary>
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && this._inputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property State. The current state of the Input Security Group.
        /// </summary>
        public InputSecurityGroupState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property WhitelistRules. Whitelist rules and their sync status
        /// </summary>
        public List<InputWhitelistRule> WhitelistRules
        {
            get { return this._whitelistRules; }
            set { this._whitelistRules = value; }
        }

        // Check to see if WhitelistRules property is set
        internal bool IsSetWhitelistRules()
        {
            return this._whitelistRules != null && this._whitelistRules.Count > 0; 
        }

    }
}