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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeScreenAutomation operation.
    /// The InvokeScreenAutomation API allows invoking an action defined in a screen in a
    /// Honeycode app. The API allows setting local variables, which can then be used in the
    /// automation being invoked. This allows automating the Honeycode app interactions to
    /// write, update or delete data in the workbook.
    /// </summary>
    public partial class InvokeScreenAutomationRequest : AmazonHoneycodeRequest
    {
        private string _appId;
        private string _clientRequestToken;
        private string _rowId;
        private string _screenAutomationId;
        private string _screenId;
        private Dictionary<string, VariableValue> _variables = new Dictionary<string, VariableValue>();
        private string _workbookId;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The ID of the app that contains the screen automation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  The request token for performing the automation action. Request tokens help to identify
        /// duplicate requests. If a call times out or fails due to a transient error like a failed
        /// network connection, you can retry the call with the same request token. The service
        /// ensures that if the first call using that request token is successfully performed,
        /// the second call will return the response of the previous call rather than performing
        /// the action again. 
        /// </para>
        ///  
        /// <para>
        ///  Note that request tokens are valid only for a few minutes. You cannot use request
        /// tokens to dedupe requests spanning hours or days. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property RowId. 
        /// <para>
        ///  The row ID for the automation if the automation is defined inside a block with source
        /// or list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=77, Max=77)]
        public string RowId
        {
            get { return this._rowId; }
            set { this._rowId = value; }
        }

        // Check to see if RowId property is set
        internal bool IsSetRowId()
        {
            return this._rowId != null;
        }

        /// <summary>
        /// Gets and sets the property ScreenAutomationId. 
        /// <para>
        /// The ID of the automation action to be performed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ScreenAutomationId
        {
            get { return this._screenAutomationId; }
            set { this._screenAutomationId = value; }
        }

        // Check to see if ScreenAutomationId property is set
        internal bool IsSetScreenAutomationId()
        {
            return this._screenAutomationId != null;
        }

        /// <summary>
        /// Gets and sets the property ScreenId. 
        /// <para>
        /// The ID of the screen that contains the screen automation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ScreenId
        {
            get { return this._screenId; }
            set { this._screenId = value; }
        }

        // Check to see if ScreenId property is set
        internal bool IsSetScreenId()
        {
            return this._screenId != null;
        }

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        ///  Variables are specified as a map where the key is the name of the variable as defined
        /// on the screen. The value is an object which currently has only one property, rawValue,
        /// which holds the value of the variable to be passed to the screen. Any variables defined
        /// in a screen are required to be passed in the call. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, VariableValue> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && this._variables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkbookId. 
        /// <para>
        /// The ID of the workbook that contains the screen automation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WorkbookId
        {
            get { return this._workbookId; }
            set { this._workbookId = value; }
        }

        // Check to see if WorkbookId property is set
        internal bool IsSetWorkbookId()
        {
            return this._workbookId != null;
        }

    }
}