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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.JSONRPC10.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TopLevel
    {
        private Dialog _dialog;
        private List<Dialog> _dialogList = new List<Dialog>();
        private Dictionary<string, Dialog> _dialogMap = new Dictionary<string, Dialog>();

        /// <summary>
        /// Gets and sets the property Dialog.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dialog Dialog
        {
            get { return this._dialog; }
            set { this._dialog = value; }
        }

        // Check to see if Dialog property is set
        internal bool IsSetDialog()
        {
            return this._dialog != null;
        }

        /// <summary>
        /// Gets and sets the property DialogList.
        /// </summary>
        public List<Dialog> DialogList
        {
            get { return this._dialogList; }
            set { this._dialogList = value; }
        }

        // Check to see if DialogList property is set
        internal bool IsSetDialogList()
        {
            return this._dialogList != null && this._dialogList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DialogMap.
        /// </summary>
        public Dictionary<string, Dialog> DialogMap
        {
            get { return this._dialogMap; }
            set { this._dialogMap = value; }
        }

        // Check to see if DialogMap property is set
        internal bool IsSetDialogMap()
        {
            return this._dialogMap != null && this._dialogMap.Count > 0; 
        }

    }
}