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
    /// Container for the parameters to the GetScreenData operation.
    /// The GetScreenData API allows retrieval of data from a screen in a Honeycode app.
    /// The API allows setting local variables in the screen to filter, sort or otherwise
    /// affect what will be displayed on the screen.
    /// </summary>
    public partial class GetScreenDataRequest : AmazonHoneycodeRequest
    {
        private string _appId;
        private int? _maxResults;
        private string _nextToken;
        private string _screenId;
        private Dictionary<string, VariableValue> _variables = new Dictionary<string, VariableValue>();
        private string _workbookId;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The ID of the app that contains the screen.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The number of results to be returned on a single page. Specify a number between 1
        /// and 100. The maximum value is 100. 
        /// </para>
        ///  
        /// <para>
        ///  This parameter is optional. If you don't specify this parameter, the default page
        /// size is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  This parameter is optional. If a nextToken is not specified, the API returns the
        /// first page of data. 
        /// </para>
        ///  
        /// <para>
        ///  Pagination tokens expire after 1 hour. If you use a token that was returned more
        /// than an hour back, the API will throw ValidationException. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ScreenId. 
        /// <para>
        /// The ID of the screen.
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
        ///  Variables are optional and are needed only if the screen requires them to render
        /// correctly. Variables are specified as a map where the key is the name of the variable
        /// as defined on the screen. The value is an object which currently has only one property,
        /// rawValue, which holds the value of the variable to be passed to the screen. 
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
        /// The ID of the workbook that contains the screen.
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