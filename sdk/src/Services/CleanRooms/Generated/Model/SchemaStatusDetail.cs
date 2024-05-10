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
    /// Information about the schema status.
    /// 
    ///  
    /// <para>
    /// A status of <c>READY</c> means that based on the schema analysis rule, queries of
    /// the given analysis rule type are properly configured to run queries on this schema.
    /// </para>
    /// </summary>
    public partial class SchemaStatusDetail
    {
        private AnalysisRuleType _analysisRuleType;
        private List<string> _configurations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<SchemaStatusReason> _reasons = AWSConfigs.InitializeCollections ? new List<SchemaStatusReason>() : null;
        private SchemaStatus _status;

        /// <summary>
        /// Gets and sets the property AnalysisRuleType. 
        /// <para>
        /// The analysis rule type for which the schema status has been evaluated.
        /// </para>
        /// </summary>
        public AnalysisRuleType AnalysisRuleType
        {
            get { return this._analysisRuleType; }
            set { this._analysisRuleType = value; }
        }

        // Check to see if AnalysisRuleType property is set
        internal bool IsSetAnalysisRuleType()
        {
            return this._analysisRuleType != null;
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// The configuration details of the schema analysis rule for the given type.
        /// </para>
        /// </summary>
        public List<string> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && (this._configurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// The reasons why the schema status is set to its current state.
        /// </para>
        /// </summary>
        public List<SchemaStatusReason> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && (this._reasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}