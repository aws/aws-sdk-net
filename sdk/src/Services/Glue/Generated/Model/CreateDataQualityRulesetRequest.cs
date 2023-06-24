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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataQualityRuleset operation.
    /// Creates a data quality ruleset with DQDL rules applied to a specified Glue table.
    /// 
    ///  
    /// <para>
    /// You create the ruleset using the Data Quality Definition Language (DQDL). For more
    /// information, see the Glue developer guide.
    /// </para>
    /// </summary>
    public partial class CreateDataQualityRulesetRequest : AmazonGlueRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;
        private string _ruleset;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DataQualityTargetTable _targetTable;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for idempotency and is recommended to be set to a random ID (such as a UUID)
        /// to avoid creating or starting multiple instances of the same resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data quality ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the data quality ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Ruleset. 
        /// <para>
        /// A Data Quality Definition Language (DQDL) ruleset. For more information, see the Glue
        /// developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public string Ruleset
        {
            get { return this._ruleset; }
            set { this._ruleset = value; }
        }

        // Check to see if Ruleset property is set
        internal bool IsSetRuleset()
        {
            return this._ruleset != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags applied to the data quality ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// A target table associated with the data quality ruleset.
        /// </para>
        /// </summary>
        public DataQualityTargetTable TargetTable
        {
            get { return this._targetTable; }
            set { this._targetTable = value; }
        }

        // Check to see if TargetTable property is set
        internal bool IsSetTargetTable()
        {
            return this._targetTable != null;
        }

    }
}