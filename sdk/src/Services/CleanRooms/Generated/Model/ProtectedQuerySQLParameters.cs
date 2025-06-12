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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The parameters for the SQL type Protected Query.
    /// </summary>
    public partial class ProtectedQuerySQLParameters
    {
        private string _analysisTemplateArn;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _queryString;

        /// <summary>
        /// Gets and sets the property AnalysisTemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the analysis template within a collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string AnalysisTemplateArn
        {
            get { return this._analysisTemplateArn; }
            set { this._analysisTemplateArn = value; }
        }

        // Check to see if AnalysisTemplateArn property is set
        internal bool IsSetAnalysisTemplateArn()
        {
            return this._analysisTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The protected query SQL parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string to be submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500000)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

    }
}